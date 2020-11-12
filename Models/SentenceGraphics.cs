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
    public class SentenceGraphics
    {
        public static Size DEFAULT_IMAGE_SIZE = new Size(400, 400);
        public static Font DEFAULT_FONT = new Font(FontFamily.GenericSerif, 20, FontStyle.Regular);
        public static Color DEFAULT_BACK_COLOR = Color.White;
        private Font font;
        private Size imageSize;
        private Color backColor;
        private List<string> textLines;

        public SentenceGraphics(string text)
        {
            this.imageSize = DEFAULT_IMAGE_SIZE;
            this.font = DEFAULT_FONT;
            this.backColor = DEFAULT_BACK_COLOR;
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

        public void AutoReLine(double paddingPercenteage)
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
                if(sizef.Width > this.imageSize.Width * (1.0 - paddingPercenteage / 100))
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
            float startY = -lineHeight * (this.textLines.Count / 2f) + lineHeight / 2f;

            for (int i=0;i<this.textLines.Count;i++)
            {
                string text = this.textLines[i];
                SizeF textSize = graphics.MeasureString(text, this.font);
                graphics.DrawString(text, this.font, Brushes.Black, imWid / 2f - textSize.Width / 2f, startY + imHei / 2f - textSize.Height / 2f + lineHeight*i);
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
                EncoderParameter e1 = new EncoderParameter(Encoder.Quality, 92L);
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
            foreach(PropertyInfo prop in properties)
            {
                if(prop.Name.ToLower() == formatName.ToLower())
                {
                    return (ImageFormat)prop.GetMethod.Invoke(null, null);
                }
            }
            switch(formatName.ToLower())
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
