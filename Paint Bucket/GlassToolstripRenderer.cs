using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace VisualBounds.Imaging.PaintBucket
{
    public class GlassToolstripRenderer : ToolStripSystemRenderer
    {
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            if (!e.Item.IsOnDropDown)
            {
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                e.Graphics.DrawString(e.Text, e.TextFont, new SolidBrush(e.TextColor), e.TextRectangle);
            } else
                base.OnRenderItemText(e);
        }
    }
}
