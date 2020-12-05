using SentencesToImages.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using HorizontalAlignment = SentencesToImages.Models.HorizontalAlignment;

namespace SentencesToImages
{
    public partial class SentencesToImages : Form
    {
        private readonly List<SentenceGraphics> _sentences;
        private float previewZoom = 1f;
        private static readonly float MAX_PREVIEW_ZOOM = (float)Math.Pow(1.25, 6); // ~ 3.81
        private static readonly float MIN_PREVIEW_ZOOM = (float)Math.Pow(0.8, 12); // ~ 0.07
        public SentencesToImages()
        {
            InitializeComponent();
            _sentences = new List<SentenceGraphics>();
            DefaultBackColorBox.BackColor = Color.White;
            ImageFormatComboBox.SelectedIndex = 1;

            foreach (VerticalAlignment vert in Enum.GetValues(typeof(VerticalAlignment)))
            {
                CurrentVertAlignComboBox.Items.Add(vert);
                DefaultVertAlignComboBox.Items.Add(vert);
            }

            foreach (HorizontalAlignment hori in Enum.GetValues(typeof(HorizontalAlignment)))
            {
                CurrentHoriAlignComboBox.Items.Add(hori);
                DefaultHoriAlignComboBox.Items.Add(hori);
            }

            DefaultVertAlignComboBox.SelectedItem = VerticalAlignment.Center;
            DefaultHoriAlignComboBox.SelectedItem = HorizontalAlignment.Center;
        }

        #region Sentences ListBox

        private void AddSensFileButton_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var reader = new StreamReader(fileDialog.FileName);

                Font font = new Font(family: FontFamily.GenericSansSerif, defaultFontSizeTrackBar.Value, FontStyle.Regular);
                Size size = new Size(DefaultImageWidthTrackBar.Value, DefaultImageHeightTrackBar.Value);
                Color backColor = DefaultBackColorBox.BackColor;
                VerticalAlignment vert = (VerticalAlignment)DefaultVertAlignComboBox.SelectedItem;
                HorizontalAlignment hori = (HorizontalAlignment)DefaultHoriAlignComboBox.SelectedItem;

                while (reader.EndOfStream == false)
                {
                    var sentence = new SentenceGraphics(font, size, backColor, vert, hori, reader.ReadLine());
                    sentence.AutoReLine();
                    _sentences.Add(sentence);
                }
                reader.Close();
            }
            RefreshSentencesListBox();
        }

        private void SentencesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if (sentence == null)
                return;
            //previewZoom = 1f;
            CurrentBackColorBox.BackColor = sentence.GetBackColor();
            CurrentFontSizeTrackBar.Value = (int)sentence.GetFont().Size;
            CurrentImageWidthTrackBar.Value = sentence.GetImageSize().Width;
            CurrentImageHeightTrackBar.Value = sentence.GetImageSize().Height;
            CurrentFontSizeLabel.Text = sentence.GetFont().Size.ToString();
            CurrentImageWidthLabel.Text = sentence.GetImageSize().Width.ToString();
            CurrentImageHeightLabel.Text = sentence.GetImageSize().Height.ToString();
            CurrentVertAlignComboBox.SelectedItem = sentence.GetVerticalAlignment();
            CurrentHoriAlignComboBox.SelectedItem = sentence.GetHorizontalAlignment();
            PreviewSentence();
        }

        private void RefreshSentencesListBox()
        {
            sentencesListBox.Items.Clear();
            sentencesListBox.Items.AddRange(_sentences.ToArray());
        }

        private void SentencesListBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    {
                        var index = sentencesListBox.SelectedIndex;
                        if (index < 0)
                            return;
                        SentenceGraphics sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
                        _sentences.Remove(sentence);
                        RefreshSentencesListBox();
                        if (sentencesListBox.Items.Count <= index)
                            index--;
                        if (sentencesListBox.Items.Count > 0)
                            sentencesListBox.SelectedIndex = index;
                    }
                    break;
            }
        }

        #endregion

        #region Preview

        public void PreviewSentence()
        {
            SentenceGraphics sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if (sentence == null)
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

        public void PreviewPictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            SentenceGraphics sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if (sentence == null)
                return;

            float numberOfScrolls = e.Delta * SystemInformation.MouseWheelScrollLines / 120f;
            previewZoom *= numberOfScrolls > 0 ? 1.25f : 0.8f;

            if (previewZoom > MAX_PREVIEW_ZOOM)
            {
                previewZoom = MAX_PREVIEW_ZOOM;
                return;
            }
            if (previewZoom < MIN_PREVIEW_ZOOM)
            {
                previewZoom = MIN_PREVIEW_ZOOM;
                return;
            }

            ZoomLabel.Text = String.Format("x{0:F2}", previewZoom);

            PreviewSentence();
        }

        #endregion

        #region Default

        private void DefaultBackColorBox_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK)
                return;
            DefaultBackColorBox.BackColor = colorDialog1.Color;
        }

        private void DefaultFontSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            int fontSize = defaultFontSizeTrackBar.Value;
            DefaultFontSizeLabel.Text = fontSize.ToString();
        }

        private void DefaultImageWidthTrackBar_Scroll(object sender, EventArgs e)
        {
            int imageWidth = DefaultImageWidthTrackBar.Value;
            DefaultImageWidthLabel.Text = imageWidth.ToString();
        }

        private void DefaultImageHeightTrackBar_Scroll(object sender, EventArgs e)
        {
            int imageHeight = DefaultImageHeightTrackBar.Value;
            DefaultImageHeightLabel.Text = imageHeight.ToString();
        }

        private void SetDefaultStyleToCurrentButton_Click(object sender, EventArgs e)
        {
            SentenceGraphics sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if (sentence == null)
                return;
            CurrentFontSizeTrackBar.Value = defaultFontSizeTrackBar.Value;
            CurrentFontSizeTrackBar_Scroll(sender, e);
            CurrentImageWidthTrackBar.Value = DefaultImageWidthTrackBar.Value;
            CurrentImageHeightTrackBar.Value = DefaultImageHeightTrackBar.Value;
            CurrentImageWidthTrackBar_Scroll(sender, e);
            CurrentImageHeightTrackBar_Scroll(sender, e);
            CurrentVertAlignComboBox.SelectedItem = DefaultVertAlignComboBox.SelectedItem;
            CurrentHoriAlignComboBox.SelectedItem = DefaultHoriAlignComboBox.SelectedItem;
            sentence.SetBackColor(DefaultBackColorBox.BackColor);
            SentencesListBox_SelectedIndexChanged(sender, e);
        }

        private void SetDefaultStyleToAllButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to change all the sentences to the default settings?",
                "Set all sentences",
                MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            int fontSize = defaultFontSizeTrackBar.Value;
            int imageWidth = DefaultImageWidthTrackBar.Value;
            int imageHeight = DefaultImageHeightTrackBar.Value;
            Color backColor = DefaultBackColorBox.BackColor;
            VerticalAlignment vert = (VerticalAlignment)DefaultVertAlignComboBox.SelectedItem;
            HorizontalAlignment hori = (HorizontalAlignment)DefaultHoriAlignComboBox.SelectedItem;
            foreach (SentenceGraphics sentence in sentencesListBox.Items)
            {
                sentence.SetFont(new Font(family: FontFamily.GenericSansSerif, fontSize, FontStyle.Regular));
                sentence.SetImageSize(new Size(imageWidth, imageHeight));
                sentence.SetBackColor(backColor);
                sentence.SetVerticalAlignment(vert);
                sentence.SetHorizontalAlignment(hori);
                sentence.AutoReLine();
            }

            SetDefaultStyleToCurrentButton_Click(sender, e);
        }

        #endregion

        #region Current

        private void CurrentBackColorBox_DoubleClick(object sender, EventArgs e)
        {
            var sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if (sentence == null)
            {
                MessageBox.Show("Please select a sentence first to change its background color", "Background color", MessageBoxButtons.OK);
                return;
            }

            if (colorDialog1.ShowDialog() != DialogResult.OK)
                return;
            sentence.SetBackColor(colorDialog1.Color);
            CurrentBackColorBox.BackColor = colorDialog1.Color;
            PreviewSentence();
        }

        private void CurrentFontSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            SentenceGraphics sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if (sentence == null)
                return;
            int fontSize = CurrentFontSizeTrackBar.Value;
            if (sentence.GetFont().Size == fontSize)
                return;
            sentence.SetFont(new Font(family: FontFamily.GenericSansSerif, fontSize, FontStyle.Regular));
            CurrentFontSizeLabel.Text = fontSize.ToString();
            sentence.AutoReLine();
            PreviewSentence();
        }

        private void CurrentImageWidthTrackBar_Scroll(object sender, EventArgs e)
        {
            SentenceGraphics sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if (sentence == null)
                return;
            int imageWidth = CurrentImageWidthTrackBar.Value;
            if (sentence.GetImageSize().Width == imageWidth)
                return;
            sentence.SetImageSize(new Size(imageWidth, sentence.GetImageSize().Height));
            CurrentImageWidthLabel.Text = imageWidth.ToString();
            sentence.AutoReLine();
            PreviewSentence();
        }

        private void CurrentImageHeightTrackBar_Scroll(object sender, EventArgs e)
        {
            SentenceGraphics sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if (sentence == null)
                return;
            int imageHeight = CurrentImageHeightTrackBar.Value;
            if (sentence.GetImageSize().Height == imageHeight)
                return;
            sentence.SetImageSize(new Size(sentence.GetImageSize().Width, imageHeight));
            CurrentImageHeightLabel.Text = imageHeight.ToString();
            sentence.AutoReLine();
            PreviewSentence();
        }

        private void CurrentVertAlignComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SentenceGraphics sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if (sentence == null)
                return;
            sentence.SetVerticalAlignment((VerticalAlignment)CurrentVertAlignComboBox.SelectedItem);
            PreviewSentence();
        }

        private void CurrentHoriAlignComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SentenceGraphics sentence = (SentenceGraphics)sentencesListBox.SelectedItem;
            if (sentence == null)
                return;
            sentence.SetHorizontalAlignment((HorizontalAlignment)CurrentHoriAlignComboBox.SelectedItem);
            PreviewSentence();
        }

        #endregion

        #region Output

        private void ChooseOutputFolderButton_Click(object sender, EventArgs e)
        {
            if (outputFolderDialog.ShowDialog() == DialogResult.OK)
            {
                outputFolderTextBox.Text = outputFolderDialog.SelectedPath;
            }
        }

        private void SaveImagesButton_Click(object sender, EventArgs e)
        {
            var path = outputFolderTextBox.Text;
            if (Directory.Exists(path) == false)
            {
                MessageBox.Show("Folder path '" + path + "' does not exist", "Save Folder", MessageBoxButtons.OK);
                return;
            }
            for (var i = 0; i < this._sentences.Count; i++)
            {
                var sentence = this._sentences[i];
                sentence.SaveBitmap(path, (i + 1).ToString(), ImageFormatComboBox.SelectedItem.ToString());
            }
            if (MessageBox.Show("Finished, do you want to open the folder?", "Finished", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.Start("explorer.exe", path);
            }
        }
        #endregion

        
    }
}
