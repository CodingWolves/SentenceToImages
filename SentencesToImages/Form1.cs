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
        private float previewZoom = 1f;
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
            previewZoom = 1f;
            currentBackColorBox.BackColor = sentence.GetBackColor();
            currentFontSizeTrackBar.Value = (int)sentence.GetFont().Size;
            currentImageSizeTrackBar.Value = sentence.GetImageSize().Width;
            previewSentence();
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

        private void sentencesListBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Delete:
                    {
                        int index = sentencesListBox.SelectedIndex;
                        SentenceGraphics sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
                        sentences.Remove(sentence);
                        RefreshSentencesListBox();
                        if(sentencesListBox.Items.Count <= index)
                            index--;
                        if(sentencesListBox.Items.Count > 0)
                            sentencesListBox.SelectedIndex = index;
                    }
                    break;
            }
        }

        private void applyBackColorToSentenceButton_Click(object sender, EventArgs e)
        {
            SentenceGraphics sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if(sentence == null)
                return;
            sentence.SetBackColor(currentBackColorBox.BackColor);
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

        public void previewSentence()
        {
            SentenceGraphics sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if(sentence == null)
                return;
            Image originalImage = sentence.MakeBitmap();
            Image newPreview = new Bitmap((int)(originalImage.Width * previewZoom), (int)(originalImage.Height * previewZoom));
            Graphics graphics = Graphics.FromImage(newPreview);
            graphics.ScaleTransform(previewZoom, previewZoom);
            graphics.Clear(sentence.GetBackColor());
            graphics.DrawImage(originalImage, new Point(0, 0));
            graphics.Flush();
            graphics.Dispose();
            originalImage.Dispose();
            previewPictureBox.Image.Dispose();

            previewPictureBox.Image = newPreview;
        }

        public void previewPictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            SentenceGraphics sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if(sentence == null)
                return;

            float numberOfScrolls = e.Delta * SystemInformation.MouseWheelScrollLines / 120f;
            previewZoom *= 1f + (Math.Sign(numberOfScrolls) / 4.0f);

            previewSentence();
        }


        private void defaultBackColorBox_DoubleClick(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                SentenceGraphics.DEFAULT_BACK_COLOR = colorDialog1.Color;
                defaultBackColorBox.BackColor = SentenceGraphics.DEFAULT_BACK_COLOR;
            }
        }

        private void defaultFontSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            int fontSize = defaultFontSizeTrackBar.Value;
            Font oldFont = SentenceGraphics.DEFAULT_FONT;
            SentenceGraphics.DEFAULT_FONT = new Font(oldFont.FontFamily, fontSize, oldFont.Style);
        }

        private void defaultImageSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            int imageSize = defaultImageSizeTrackBar.Value;
            SentenceGraphics.DEFAULT_IMAGE_SIZE = new Size(imageSize, imageSize);
        }

        private void currentFontSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            SentenceGraphics sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if(sentence == null)
                return;
            int fontSize = currentFontSizeTrackBar.Value;
            if(sentence.GetFont().Size == fontSize)
                return;
            Font oldFont = SentenceGraphics.DEFAULT_FONT;
            sentence.SetFont(new Font(oldFont.FontFamily, fontSize, oldFont.Style));
            sentence.AutoReLine(10);
            //sentencesListBox_SelectedIndexChanged(sender, e);
            previewSentence();
        }

        private void currentImageSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            SentenceGraphics sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if(sentence == null)
                return;
            int imageSize = currentImageSizeTrackBar.Value;
            if(sentence.GetImageSize().Width == imageSize)
                return;
            sentence.SetImageSize(new Size(imageSize, imageSize));
            sentence.AutoReLine(10);
            //sentencesListBox_SelectedIndexChanged(sender, e);
            previewSentence();
        }
    }
}
