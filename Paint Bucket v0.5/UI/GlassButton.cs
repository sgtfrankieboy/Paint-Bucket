using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace VisualBounds.Imaging.PaintBucket.UI
{
    [ToolboxBitmap(typeof(Button))]
    public class GlassButton : Button
    {
        public GlassButton()
        {
            this.UseCompatibleTextRendering = true;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            string text = this.Text;
            this.Text = "";
            base.OnPaint(pevent);
            this.Text = text;

            Bitmap map = new Bitmap(pevent.ClipRectangle.Width, pevent.ClipRectangle.Height, pevent.Graphics);

            using (Graphics g = Graphics.FromImage(map))
            {
                SizeF size = pevent.Graphics.MeasureString(this.Text, this.Font);
                int x = ((int)(pevent.ClipRectangle.Width - size.Width) / 2);
                int y = ((int)(pevent.ClipRectangle.Height - size.Height) / 2);
                pevent.Graphics.TextContrast = 6;
                pevent.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), new PointF(x, y));
            }

            pevent.Graphics.DrawImageUnscaled(map, new Point(0, 0));
        }
    }
}
