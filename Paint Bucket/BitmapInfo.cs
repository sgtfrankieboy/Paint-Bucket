using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisualBounds.Imaging.PaintBucket
{
    public class BitmapInfo
    {
        public bool Visible { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }


        public BitmapInfo(bool Visible, int Width, int Height, int X, int Y)
        {
            this.Visible = Visible;
            this.Width = Width;
            this.Height = Height;
            this.X = X;
            this.Y = Y;
        }
    }
}
