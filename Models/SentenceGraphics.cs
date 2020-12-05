using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Encoder = System.Drawing.Imaging.Encoder;

namespace SentencesToImages.Models
{
    public enum VerticalAlignment
    {
        Top,
        Center,
        Bottom
    }
    public enum HorizontalAlignment
    {
        Left,
        Center,
        Right
    }

    public class SentenceGraphics
    {
        private Font font;
        private Size imageSize;
        private Color backColor;
        private VerticalAlignment vertical;
        private HorizontalAlignment horizontal;
        private float padPercent = 5f;
        private List<string> textLines;

        public SentenceGraphics(Font font, Size imageSize, Color backColor, VerticalAlignment vertical, HorizontalAlignment horizontal, string text)
        {
            this.font = font;
            this.imageSize = imageSize;
            this.backColor = backColor;
            this.vertical = vertical;
            this.horizontal = horizontal;
            this.textLines = new List<string>();
            this.textLines.Add(text.Trim(' '));
        }

        public Size GetImageSize()
        {
            return this.imageSize;
        }
        public void SetImageSize(Size size)
        {
            this.imageSize = size;
        }

        public Font GetFont()
        {
            return this.font;
        }
        public void SetFont(Font font)
        {
            this.font = font;
        }

        public Color GetBackColor()
        {
            return this.backColor;
        }
        public void SetBackColor(Color backColor)
        {
            this.backColor = backColor;
        }

        public VerticalAlignment GetVerticalAlignment()
        {
            return this.vertical;
        }
        public void SetVerticalAlignment(VerticalAlignment vertical)
        {
            this.vertical = vertical;
        }

        public HorizontalAlignment GetHorizontalAlignment()
        {
            return this.horizontal;
        }
        public void SetHorizontalAlignment(HorizontalAlignment horizontal)
        {
            this.horizontal = horizontal;
        }


        public string GetLine(int index)
        {
            if(index < this.textLines.Count)
            {
                return this.textLines[index];
            }
            return "";
        }

        public void SplitLine(int lineIndex, int spaceIndex)
        {
            if(lineIndex >= this.textLines.Count)
                return;
            string textLine = this.textLines[lineIndex];

            int splitIndex = 0;
            for(int i = spaceIndex; i > 0; i--)
            {
                splitIndex = textLine.IndexOf(' ', splitIndex+1);
            }
            if(splitIndex <= 0)
                return;
            this.textLines.Insert(lineIndex + 1, textLine.Substring(splitIndex).Trim(' '));
            this.textLines[lineIndex] = textLine.Substring(0, splitIndex).Trim(' ');
        }

        public void JoinLineAndNext(int index)
        {
            if(index >= this.textLines.Count - 1)
                return;

            this.textLines[index] += ' ' + this.textLines[index + 1];
            this.textLines.RemoveAt(index + 1);
        }

        public void AutoReLine()
        {
            while(this.textLines.Count > 1)
                JoinLineAndNext(0);

            Bitmap bitmap = new Bitmap(this.imageSize.Width, this.imageSize.Height);
            Graphics graphics = Graphics.FromImage(bitmap);

            int spacesFromEnd = 0;
            for(int i = 0; i < this.textLines.Count; i++)
            {
                string text = this.textLines[i];
                SizeF sizef = graphics.MeasureString(text, this.font);
                if(sizef.Width > this.imageSize.Width * (1.0 - padPercent / 100))
                {
                    if(spacesFromEnd > 0)
                    {
                        JoinLineAndNext(i);
                        text = this.textLines[i];
                    }
                    SplitLine(i, text.Count((char ch) => ch == ' ') - spacesFromEnd);
                    spacesFromEnd++;
                    if(spacesFromEnd >= text.Count((char ch) => ch == ' '))
                    {
                        spacesFromEnd = 0;
                        i++;
                    }
                    i--;
                    continue;
                }
                spacesFromEnd = 0;
            }
            graphics.Dispose();
            bitmap.Dispose();
        }

        public Bitmap MakeBitmap()
        {
            int imWid = this.imageSize.Width;
            int imHei = this.imageSize.Height;
            Bitmap bitmap = new Bitmap(imWid, imHei);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(this.backColor);

            float lineHeight = graphics.MeasureString("iLgypj", this.font).Height;
            float startY = 0;
            switch (vertical)
            {
                case VerticalAlignment.Top:
                    startY = 0; break;
                case VerticalAlignment.Center:
                    startY = imHei / 2f - lineHeight * (this.textLines.Count / 2f); break;
                case VerticalAlignment.Bottom:
                    startY = (float)imHei - (float)this.textLines.Count * lineHeight; break;
            }

            for (int i=0;i<this.textLines.Count;i++)
            {
                string text = this.textLines[i];
                SizeF textSize = graphics.MeasureString(text, this.font);
                float drawX = 0;
                switch (horizontal)
                {
                    case HorizontalAlignment.Left:
                        drawX = 0; break;
                    case HorizontalAlignment.Center:
                        drawX = imWid / 2f - textSize.Width / 2f; break;
                    case HorizontalAlignment.Right:
                        drawX = imWid - textSize.Width; break;
                }
                graphics.DrawString(text, this.font, Brushes.Black, drawX, startY + lineHeight * i);
            }

            graphics.Flush();
            graphics.Dispose();
            return bitmap;
        }

        public void SaveBitmap(string path, string filename, string formatName)
        {
            string fullPath;
            Bitmap bitmap = MakeBitmap();
            ImageFormat format = GetImageFormatByString(formatName);
            if(format.Equals(ImageFormat.Jpeg))
            {
                fullPath = path + "\\" + filename + ".jpg";

                ImageCodecInfo codec = GetJpgCodec();
                EncoderParameters eps = new EncoderParameters();
                EncoderParameter e1 = new EncoderParameter(Encoder.Quality, 90L);
                eps.Param = new EncoderParameter[] { e1 };
                bitmap.Save(fullPath, codec, eps);
                return;
            }
            fullPath = path + '\\' + filename + '.' + format.ToString().ToLower();
            bitmap.Save(fullPath, format);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach(string text in this.textLines)
            {
                builder.Append(text);
                builder.Append(' ');
            }
            builder.Remove(builder.Length - 1, 1);
            return builder.ToString();
        }


        private static ImageCodecInfo JpgCodec = null;
        private static ImageCodecInfo GetJpgCodec()
        {
            if(JpgCodec != null)
                return JpgCodec;

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach(ImageCodecInfo codec in codecs)
            {
                if(codec.FormatID == ImageFormat.Jpeg.Guid)
                {
                    JpgCodec = codec;
                    return codec;
                }
            }
            return null;
        }
        private static ImageFormat GetImageFormatByString(string formatName)
        {
            PropertyInfo[] properties = typeof(ImageFormat).GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                if (prop.Name.ToLower() == formatName.ToLower())
                {
                    return (ImageFormat)prop.GetMethod.Invoke(null, null);
                }
            }
            switch (formatName.ToLower())
            {
                case "jpg":
                    return ImageFormat.Jpeg;
                case "ico":
                    return ImageFormat.Icon;
            }
            return null;
        }
    }
}
