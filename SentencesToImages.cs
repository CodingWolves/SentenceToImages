using SentencesToImages.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace SentencesToImages
{
    public partial class SentencesToImages : Form
    {
        private readonly List<SentenceGraphics> _sentences;
        private float previewZoom = 1f;
        public SentencesToImages()
        {
            InitializeComponent();
            _sentences = new List<SentenceGraphics>();
            DefaultBackColorBox.BackColor = SentenceGraphics.DEFAULT_BACK_COLOR;
            ImageFormatComboBox.SelectedIndex = 1;
        }

        public void PreviewSentence()
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
            previewPictureBox.Image?.Dispose();

            previewPictureBox.Image = newPreview;
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
            if(sentence == null)
                return;
            //previewZoom = 1f;
            currentBackColorBox.BackColor = sentence.GetBackColor();
            currentFontSizeTrackBar.Value = (int)sentence.GetFont().Size;
            currentImageSizeTrackBar.Value = sentence.GetImageSize().Width;
            CurrentFontSizeLabel.Text = sentence.GetFont().Size.ToString();
            CurrentImageSizeLabel.Text = sentence.GetImageSize().Width.ToString();
            PreviewSentence();
        }

        private void CurrentBackColorBox_DoubleClick(object sender, EventArgs e)
        {
            var sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if(sentence == null)
            {
                MessageBox.Show("Please select a sentence first to change its background color", "Background color", MessageBoxButtons.OK);
                return;
            }

            if(colorDialog1.ShowDialog() != DialogResult.OK)
                return;
            sentence.SetBackColor(colorDialog1.Color);
            currentBackColorBox.BackColor = colorDialog1.Color;
            PreviewSentence();
        }

        private void DefaultBackColorBox_DoubleClick(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() != DialogResult.OK)
                return;
            SentenceGraphics.DEFAULT_BACK_COLOR = colorDialog1.Color;
            DefaultBackColorBox.BackColor = SentenceGraphics.DEFAULT_BACK_COLOR;
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
                        SentenceGraphics sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
                        _sentences.Remove(sentence);
                        RefreshSentencesListBox();
                        if(sentencesListBox.Items.Count <= index)
                            index--;
                        if(sentencesListBox.Items.Count > 0)
                            sentencesListBox.SelectedIndex = index;
                    }
                    break;
            }
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
                sentence.SaveBitmap(path, (i + 1).ToString(), ImageFormatComboBox.SelectedItem.ToString());
            }
            if(MessageBox.Show("Finished, do you want to open the folder?", "Finished", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.Start("explorer.exe", path);
            }
        }

        public void PreviewPictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            SentenceGraphics sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if(sentence == null)
                return;

            float numberOfScrolls = e.Delta * SystemInformation.MouseWheelScrollLines / 120f;
            previewZoom *= numberOfScrolls > 0 ? 1.25f : 0.8f;

            ZoomLabel.Text = String.Format("x{0:F2}", previewZoom);

            PreviewSentence();
        }

        private void DefaultFontSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            int fontSize = defaultFontSizeTrackBar.Value;
            Font oldFont = SentenceGraphics.DEFAULT_FONT;
            SentenceGraphics.DEFAULT_FONT = new Font(oldFont.FontFamily, fontSize, oldFont.Style);
            DefaultFontSizeLabel.Text = fontSize.ToString();
        }

        private void DefaultImageSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            int imageSize = defaultImageSizeTrackBar.Value;
            SentenceGraphics.DEFAULT_IMAGE_SIZE = new Size(imageSize, imageSize);
            DefaultImageSizeLabel.Text = imageSize.ToString();
        }

        private void CurrentFontSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            SentenceGraphics sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if(sentence == null)
                return;
            int fontSize = currentFontSizeTrackBar.Value;
            if(sentence.GetFont().Size == fontSize)
                return;
            Font oldFont = SentenceGraphics.DEFAULT_FONT;
            sentence.SetFont(new Font(oldFont.FontFamily, fontSize, oldFont.Style));
            CurrentFontSizeLabel.Text = fontSize.ToString();
            sentence.AutoReLine(10);
            //sentencesListBox_SelectedIndexChanged(sender, e);
            PreviewSentence();
        }

        private void CurrentImageSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            SentenceGraphics sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if(sentence == null)
                return;
            int imageSize = currentImageSizeTrackBar.Value;
            if(sentence.GetImageSize().Width == imageSize)
                return;
            sentence.SetImageSize(new Size(imageSize, imageSize));
            CurrentImageSizeLabel.Text = imageSize.ToString();
            sentence.AutoReLine(10);
            //sentencesListBox_SelectedIndexChanged(sender, e);
            PreviewSentence();
        }

        private void ResetStyleToDefault_Click(object sender, EventArgs e)
        {
            SentenceGraphics sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if(sentence == null)
                return;
            currentFontSizeTrackBar.Value = defaultFontSizeTrackBar.Value;
            CurrentFontSizeTrackBar_Scroll(sender, e);
            currentImageSizeTrackBar.Value = defaultImageSizeTrackBar.Value;
            CurrentImageSizeTrackBar_Scroll(sender, e);
            sentence.SetBackColor(DefaultBackColorBox.BackColor);
            SentencesListBox_SelectedIndexChanged(sender, e);
        }

        private void ResetAllToDefault_Click(object sender, EventArgs e)
        {
            int fontSize = defaultFontSizeTrackBar.Value;
            int imageSize = defaultImageSizeTrackBar.Value;
            Color backColor = DefaultBackColorBox.BackColor;
            foreach(SentenceGraphics sentence in sentencesListBox.Items)
            {
                Font oldFont = SentenceGraphics.DEFAULT_FONT;
                sentence.SetFont(new Font(oldFont.FontFamily, fontSize, oldFont.Style));
                sentence.SetImageSize(new Size(imageSize, imageSize));
                sentence.SetBackColor(backColor);
                sentence.AutoReLine(10);
            }

            ResetStyleToDefault_Click(sender, e);
        }
    }
}
