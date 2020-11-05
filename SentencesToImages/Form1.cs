using SentencesToImages.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace SentencesToImages
{
    public partial class Form1 : Form
    {
        private readonly List<SentenceGraphics> _sentences;
        public Form1()
        {
            InitializeComponent();
            _sentences = new List<SentenceGraphics>();
            defaultBackColorBox.BackColor = SentenceGraphics.DEFAULT_BACK_COLOR;
        }

        private void RefreshSentencesListBox()
        {
            sentencesListBox.Items.Clear();
            sentencesListBox.Items.AddRange(_sentences.ToArray());
        }

        private void ChooseOutputFolderButton_Click(object sender, EventArgs e)
        {
            if(outputFolderDialog.ShowDialog() == DialogResult.OK)
            {
                outputFolderTextBox.Text = outputFolderDialog.SelectedPath;
            }
        }

        private void AddSensFileButton_Click(object sender, EventArgs e)
        {
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                var reader = new StreamReader(fileDialog.FileName);
                while(reader.EndOfStream == false)
                {
                    var sentence = new SentenceGraphics(reader.ReadLine());
                    sentence.AutoReLine(15);
                    _sentences.Add(sentence);
                }
                reader.Close();
            }
            RefreshSentencesListBox();
        }

        private void SentencesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if(sentence == null) return;
            previewPictureBox.Image?.Dispose();
            backgroundColorBox.BackColor = sentence.GetBackColor();
            previewPictureBox.Image = sentence.MakeBitmap();
        }

        private void SentenceBackColorBox_DoubleClick(object sender, EventArgs e)
        {
            var sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if(sentence == null)
            {
                MessageBox.Show("Please select a sentence first to change its background color", "Background color", MessageBoxButtons.OK);
                return;
            }

            if (colorDialog1.ShowDialog() != DialogResult.OK) return;
            sentence.SetBackColor(colorDialog1.Color);
            SentencesListBox_SelectedIndexChanged(sender, e);
        }

        private void DefaultBackColorBox_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;
            SentenceGraphics.DEFAULT_BACK_COLOR = colorDialog1.Color;
            defaultBackColorBox.BackColor = SentenceGraphics.DEFAULT_BACK_COLOR;
        }

        private void SentencesListBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Delete:
                    {
                        var index = sentencesListBox.SelectedIndex;
                        if(index < 0)
                            return;
                        sentencesListBox.SelectedIndex = index - 1;
                        sentencesListBox.Items.RemoveAt(index);
                    }
                    break;
            }
        }

        private void applyBackColorToSentenceButton_Click(object sender, EventArgs e)
        {
            SentenceGraphics sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if(sentence == null)
                return;
            sentence.SetBackColor(backgroundColorBox.BackColor);
            SentencesListBox_SelectedIndexChanged(sender, e);
        }

        private void SaveImagesButton_Click(object sender, EventArgs e)
        {
            var path = outputFolderTextBox.Text;
            if(Directory.Exists(path) == false)
            {
                MessageBox.Show("Folder path '" + path + "' does not exist", "Save Folder", MessageBoxButtons.OK);
                return;
            }
            for(var i = 0; i < this._sentences.Count; i++)
            {
                var sentence = this._sentences[i];
                sentence.MakeBitmap().Save(path + "\\" + (i + 1) + ".png", ImageFormat.Png);
            }
            if(MessageBox.Show("Finished, do you want to open the folder?", "Finished", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.Start("explorer.exe", path);
            }
        }
    }
}
