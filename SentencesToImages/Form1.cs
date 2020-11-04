using SentencesToImages.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentencesToImages
{
    public partial class Form1 : Form
    {
        private List<SentenceGraphics> sentences;
        public Form1()
        {
            InitializeComponent();
            sentences = new List<SentenceGraphics>();
            defaultBackColorBox.BackColor = SentenceGraphics.DEFAULT_BACK_COLOR;
        }

        private void RefreshSentencesListBox()
        {
            sentencesListBox.Items.Clear();
            sentencesListBox.Items.AddRange(sentences.ToArray());
        }

        private void chooseOutputFolderButton_Click(object sender, EventArgs e)
        {
            if(outputFolderDialog.ShowDialog() == DialogResult.OK)
            {
                outputFolderTextBox.Text = outputFolderDialog.SelectedPath;
            }
        }

        private void addSensFileButton_Click(object sender, EventArgs e)
        {
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(fileDialog.FileName);
                while(reader.EndOfStream == false)
                {
                    SentenceGraphics sentence = new SentenceGraphics(reader.ReadLine());
                    sentence.AutoReLine(15);
                    sentences.Add(sentence);
                }
                reader.Close();
            }
            RefreshSentencesListBox();
        }

        private void sentencesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SentenceGraphics sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if(sentence == null)
                return;
            if(previewPictureBox.Image != null)
                previewPictureBox.Image.Dispose();
            backgroundColorBox.BackColor = sentence.GetBackColor();
            previewPictureBox.Image = sentence.MakeBitmap();
        }

        private void sentenceBackColorBox_DoubleClick(object sender, EventArgs e)
        {
            SentenceGraphics sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if(sentence == null)
            {
                MessageBox.Show("Please select a sentence first to change its background color", "Background color", MessageBoxButtons.OK);
                return;
            }
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                sentence.SetBackColor(colorDialog1.Color);
                sentencesListBox_SelectedIndexChanged(sender, e);
            }
        }

        private void defaultBackColorBox_DoubleClick(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                SentenceGraphics.DEFAULT_BACK_COLOR = colorDialog1.Color;
                defaultBackColorBox.BackColor = SentenceGraphics.DEFAULT_BACK_COLOR;
            }
        }

        private void sentencesListBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Delete:
                    {
                        int index = sentencesListBox.SelectedIndex;
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
            sentencesListBox_SelectedIndexChanged(sender, e);
        }

        private void saveImagesButton_Click(object sender, EventArgs e)
        {
            string path = outputFolderTextBox.Text;
            if(Directory.Exists(path) == false)
            {
                MessageBox.Show("Folder path '" + path + "' does not exist", "Save Folder", MessageBoxButtons.OK);
                return;
            }
            for(int i = 0; i < this.sentences.Count; i++)
            {
                SentenceGraphics sentence = this.sentences[i];
                sentence.MakeBitmap().Save(path + "\\" + (i + 1).ToString() + ".png", ImageFormat.Png);
            }
            if(MessageBox.Show("Finished, do you want to open the folder?", "Finished", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.Start("explorer.exe", path);
            }
        }
    }
}
