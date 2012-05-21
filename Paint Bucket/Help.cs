using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace VisualBounds.Imaging.PaintBucket
{
    public class Help
    {
        public static byte GetIntensityByte(Color color)
        {
            return (byte)(7471 * color.B + 38470 * color.G + 19595 * color.R >> 16);
        }

        public static Color ToGray(Color color)
        {
            byte i = GetIntensityByte(color);
            return Color.FromArgb(color.A, i, i, i);
        }

    }
}
