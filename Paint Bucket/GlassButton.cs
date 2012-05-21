using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace VisualBounds.Imaging.PaintBucket
{
    class GlassButton : Button
    {
        // New Text object for drawing the Text.
        [Browsable(true)]
        public string text { get; set; }

        // Disable default Text object.
        // Making it not draw.
        [Browsable(false)]
        public override String Text
        {
            get { return ""; }
            set { text = value; }
        }

        // Redraw the text on the button. Using a different Graphics.
        // Otherwise the text will turn transparent.
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Bitmap map = new Bitmap(pevent.ClipRectangle.Width, pevent.ClipRectangle.Height, pevent.Graphics);

            using (Graphics g = Graphics.FromImage(map))
            {
                SizeF size = pevent.Graphics.MeasureString(this.text, this.Font);
                int x = ((int)(pevent.ClipRectangle.Width - size.Width) / 2);
                int y = ((int)(pevent.ClipRectangle.Height - size.Height) / 2);
                pevent.Graphics.TextContrast = 6;
                pevent.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.DrawString(this.text, this.Font, new SolidBrush(this.ForeColor), new PointF(x, y));
            }

            pevent.Graphics.DrawImageUnscaled(map, new Point(0, 0));
        }
    }
}
