using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace VisualBounds.Imaging.PaintBucket
{
    public class EImage
    {
        public Dictionary<BitmapInfo, Bitmap> Layers { get; private set; }
        private float _ZoomFactor;
        public float ZoomFactor
        {
            get { return _ZoomFactor; }
            set
            {
                if (value < 0.25)
                    _ZoomFactor = 0.25f;
                else
                    _ZoomFactor = value;
            }
        }

        public EImage(int Width, int Height)
        {
            Layers = new Dictionary<BitmapInfo, Bitmap>();
            ZoomFactor = 1f;
            Layers.Add(new BitmapInfo(true, Width, Height, 0, 0), new Bitmap(Width, Height));
        }

        public EImage(Image source)
        {
            Layers = new Dictionary<BitmapInfo, Bitmap>();
            ZoomFactor = 1f;
            Layers.Add(new BitmapInfo(true, source.Width, source.Height, 0, 0), new Bitmap(source));
        }

        public Image UnscaledPreview()
        {
            Bitmap preview = Layers.Values.ElementAt(0);
            using (Graphics g = Graphics.FromImage(preview))
            {
                foreach (KeyValuePair<BitmapInfo, Bitmap> map in Layers)
                {
                    if (map.Key.Visible)
                    {
                        g.DrawImage(map.Value, map.Key.X, map.Key.Y, map.Key.Width, map.Key.Height);
                    }
                }
            }

            return preview;
        }

        public Image ScaledPreview()
        {
            Bitmap preview = new Bitmap(UnscaledPreview());

            int newWidth = (int)(preview.Width * ZoomFactor);
            int newHeight = (int)(preview.Height * ZoomFactor);
            Bitmap prev = new Bitmap(newWidth, newHeight);

            using (Graphics g = Graphics.FromImage(prev))
            {
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.CompositingQuality = CompositingQuality.AssumeLinear;
                g.SmoothingMode = SmoothingMode.None;

                g.DrawImage(preview, 0, 0, newWidth, newHeight);
            }

            return prev;
        }

        public void MakeTransparent(int Layer, Color color)
        {
            Layers.Values.ElementAt(Layer).MakeTransparent(color);
        }

        public void GrayScale()
        {
            ImageAttributes at = new ImageAttributes();
            at.SetColorMatrix(new ColorMatrix(new float[][]
                    {
                        new float[] {0.30f, 0.30f, 0.30f, 0, 0},
                        new float[] {0.59f, 0.59f, 0.59f, 0, 0},
                        new float[] {0.11f, 0.11f, 0.11f, 0, 0},
                        new float[] {0, 0, 0, 1, 0},
                        new float[] {0, 0, 0, 0, 1}
                    }));

            foreach (KeyValuePair<BitmapInfo, Bitmap> map in Layers)
            {
                using (Graphics g = Graphics.FromImage(map.Value))
                {
                    g.DrawImage(map.Value, new Rectangle(0, 0, map.Value.Width, map.Value.Height), 0, 0, map.Value.Width, map.Value.Height, GraphicsUnit.Pixel, at);
                }
            }
        }

        public void Invert()
        {
            ImageAttributes at = new ImageAttributes();
            at.SetColorMatrix(new ColorMatrix(new float[][]
            {
                new float[] {-1, 0, 0, 0, 0},
                new float[] {0, -1, 0, 0, 0},
                new float[] {0, 0, -1, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {1, 1, 1, 0, 1}
            }));

            foreach (KeyValuePair<BitmapInfo, Bitmap> map in Layers)
            {
                using (Graphics g = Graphics.FromImage(map.Value))
                {
                    g.DrawImage(map.Value, new Rectangle(0, 0, map.Value.Width, map.Value.Height), 0, 0, map.Value.Width, map.Value.Height, GraphicsUnit.Pixel, at);
                }
            }
        }
    }
}