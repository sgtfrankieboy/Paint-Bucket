using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace VisualBounds.Imaging.PaintBucket
{
    public class GlassToolstripRenderer : ToolStripSystemRenderer
    {
        Color highlightColor;
        Color hotTrackColor;
        Color backFillColorTop;
        Color backFillColorBottom;
        Color insetOutlineColor;
        Color outlineColor;

        public GlassToolstripRenderer()
        {
            highlightColor = SystemColors.Highlight;
            hotTrackColor = SystemColors.HotTrack;
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            if (e.Item.IsOnDropDown)
                e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            else
                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            Color drawColor = Color.Black;
            if (!e.Item.Enabled)
                drawColor = SystemColors.GrayText;

            e.Graphics.DrawString(e.Text, e.TextFont, new SolidBrush(drawColor), e.TextRectangle);
        }

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            if ((e.ToolStrip is ContextMenuStrip) ||
                (e.ToolStrip is ToolStripDropDownMenu))
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(252, 252, 252)), e.AffectedBounds);
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 255)), new Rectangle(0, 0, 24, e.AffectedBounds.Height));
                e.Graphics.DrawLine(new Pen(Color.FromArgb(226, 227, 227)), new Point(25, 0), new Point(25, e.AffectedBounds.Height));
            }
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            if ((e.ToolStrip is ContextMenuStrip) ||
                (e.ToolStrip is ToolStripDropDownMenu))
            {
                e.Graphics.DrawRectangle(new Pen(Color.FromArgb(151, 151, 151)), e.AffectedBounds);
            }
            e.Graphics.FillRectangle(Brushes.Red, e.AffectedBounds);
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
           
            if (!e.Vertical)
                e.Graphics.DrawLine(new Pen(Color.FromArgb(224, 224, 224)), new Point(26, 0), new Point(e.Item.Width + 1, 0));
            else
                base.OnRenderSeparator(e);
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            e.Graphics.PixelOffsetMode = PixelOffsetMode.None;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (e.Item.Pressed || e.Item.Selected)
            {
                if (!e.Item.Enabled)
                {
                    backFillColorTop = Help.ToGray(backFillColorTop);
                    backFillColorBottom = Help.ToGray(backFillColorBottom);
                    insetOutlineColor = Help.ToGray(insetOutlineColor);
                    outlineColor = Help.ToGray(outlineColor);
                }
                else
                {
                    backFillColorTop = Color.FromArgb(32, highlightColor);
                    backFillColorBottom = Color.FromArgb(128, highlightColor);
                    insetOutlineColor = Color.FromArgb(64, SystemColors.Window);
                    outlineColor = Color.FromArgb(255, highlightColor);
                }

                Rectangle rect = e.Item.ContentRectangle;

                e.Graphics.FillRectangle(new LinearGradientBrush(
                    new Point(0,0),
                    new Point(0, e.Item.ContentRectangle.Height),
                    backFillColorTop,
                    backFillColorBottom), rect);

                e.Graphics.DrawLines(new Pen(outlineColor), GraphicsHelper.getRoundedLines(rect));

                rect = Rectangle.Inflate(rect, -1, -1);

                e.Graphics.DrawLines(new Pen(insetOutlineColor), GraphicsHelper.getRoundedLines(rect));

            }
        }

        protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
        {

            Rectangle rect = Rectangle.Inflate(e.ImageRectangle, 3, 2);

            e.Graphics.FillRectangle(new LinearGradientBrush(
                    new Point(0, 0),
                    new Point(0, e.Item.ContentRectangle.Height),
                    backFillColorTop,
                    backFillColorBottom), rect);

            e.Graphics.DrawLines(new Pen(outlineColor), GraphicsHelper.getRoundedLines(rect));

            rect = Rectangle.Inflate(rect, -1, -1);

            e.Graphics.DrawLines(new Pen(insetOutlineColor), GraphicsHelper.getRoundedLines(rect));

            rect = Rectangle.Inflate(rect, -2, -1);

            try
            {
                if (e.Item.Image == null)
                    e.Graphics.DrawImageUnscaled(Properties.Resources.bullet_black, rect);
            }
            catch
            {
                base.OnRenderItemCheck(e);
            }
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            try
            {
                e.ArrowRectangle = Rectangle.Inflate(e.ArrowRectangle, 5, -2);

                if (e.Direction == ArrowDirection.Down)
                    e.Graphics.DrawImageUnscaled(Properties.Resources.bullet_arrow_down, e.ArrowRectangle);
                else if (e.Direction == ArrowDirection.Up)
                    e.Graphics.DrawImageUnscaled(Properties.Resources.bullet_arrow_up, e.ArrowRectangle);
                else if (e.Direction == ArrowDirection.Left)
                    e.Graphics.DrawImageUnscaled(Properties.Resources.bullet_arrow_left, e.ArrowRectangle);
                else if (e.Direction == ArrowDirection.Right)
                    e.Graphics.DrawImageUnscaled(Properties.Resources.bullet_arrow_right, e.ArrowRectangle);

                //e.Graphics.FillRectangle(Brushes.Red, e.ArrowRectangle);
            }
            catch
            {
                base.OnRenderArrow(e);
            }
        }

    }
}
