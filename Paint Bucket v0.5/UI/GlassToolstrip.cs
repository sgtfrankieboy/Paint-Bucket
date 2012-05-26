using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace VisualBounds.Imaging.PaintBucket.UI
{
    [ToolboxBitmap(typeof(ToolStrip))]
    public class GlassToolstrip : ToolStrip
    {
        public GlassToolstrip()
        {
            this.Renderer = new GlassToolstripRenderer();
            this.GripStyle = ToolStripGripStyle.Hidden;
        }
    }
}
