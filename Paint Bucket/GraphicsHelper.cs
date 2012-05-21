using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace VisualBounds.Imaging.PaintBucket
{
    public class GraphicsHelper
    {
        public static Point[] getRoundedLines(Rectangle rect)
        {
            Point[] point = new Point[9];
            point[0] = new Point(rect.Left + 1, rect.Top);
            point[1] = new Point(rect.Right - 2, rect.Top);
            point[2] = new Point(rect.Right - 1, rect.Top + 1);
            point[3] = new Point(rect.Right - 1, rect.Bottom - 2);
            point[4] = new Point(rect.Right - 2, rect.Bottom - 1);
            point[5] = new Point(rect.Left + 1, rect.Bottom - 1);
            point[6] = new Point(rect.Left, rect.Bottom - 2);
            point[7] = new Point(rect.Left, rect.Top + 1);
            point[8] = new Point(rect.Left + 1, rect.Top);
            return point;
        }

        public static Image CreateColorImage(Color colour)
        {
            Image img = new Bitmap(22, 22);
            using (Graphics g = Graphics.FromImage(img))
            {
                g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.GammaCorrected;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                g.FillRectangle(new SolidBrush(colour), new Rectangle(1, 1, 20, 20));
                g.DrawLines(Pens.Black, new Point[] {
                    new Point(0,0),
                    new Point(0, 21),
                    new Point(21, 21),
                    new Point(21, 0),
                    new Point(0, 0)
                });
                g.DrawLines(Pens.Black, new Point[] {
                    new Point(0,0),
                    new Point(0, 21),
                    new Point(21, 21),
                    new Point(21, 0),
                    new Point(0, 0)
                });
            }
            return img;
        }
    }
}
