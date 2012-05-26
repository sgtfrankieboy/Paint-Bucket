using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace VisualBounds.Imaging.PaintBucket.UI
{
    public partial class ImageControl : UserControl
    {
        #region Declaration

        private int width, height, x, y;

        private Image _image;
        /// <summary>
        /// Gets or sets the image that is displayed by VisualBounds.Imaging.PaintBucket.UI.ImageControl.
        /// </summary>
        [Browsable(true), Description("The image displayed in the ImageControl.")]
        public Image Image
        {
            get
            {
                return _image;
            }
            set
            {
                _image = value;
                Invalidate();
            }
        }

        private float _scaleFactor = 1f;
        /// <summary>
        /// Gets or sets the scaling factor between the normal Image and the displayed Image.
        /// </summary>
        [Browsable(true), Description("Specifies the scaling factor between the normal Image and the displayed Image.")]
        public float ScaleFactor
        {
            get
            {
                return _scaleFactor;
            }
            set
            {
                _scaleFactor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether a dropshadow should be rendered below the image.
        /// </summary>
        [Browsable(true), Description("Indicates whether a dropshadow should be rendered below the image.")]
        public bool DropShadow { get; set; }

        #endregion

        [Browsable(false)]
        public override bool AutoScroll
        {
            get
            {
                return base.AutoScroll;
            }
            set
            {
                base.AutoScroll = true;
            }
        }

        public ImageControl()
        {
            InitializeComponent();
            this.AutoScroll = true;
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.Image == null)
                return;

            width = (int)(Image.Width * ScaleFactor);
            height = (int)(Image.Height * ScaleFactor);
            Size size = new Size(width, height);

            this.AutoScrollMinSize = size;

            if (width < this.Width)
                x = (this.Width - width) / 2;
            else
            {
                x = this.AutoScrollPosition.X;
            }
            if (height < this.Height)
                y = (this.Height - height) / 2;
            else
            {
                y = this.AutoScrollPosition.Y;
            }

            if (this.DropShadow)
            {
                LinearGradientBrush brush = new LinearGradientBrush(new Point(x, y + height), new Point(x, y + height + 4), Color.LightGray, Color.Transparent);
                e.Graphics.FillRectangle(brush, new Rectangle(x + 1, y + height - 1, width, 4));
                brush = new LinearGradientBrush(new Point(x + width, y), new Point(x + width + 4, y), Color.LightGray, Color.Transparent);
                e.Graphics.FillRectangle(brush, new Rectangle(x + width, y + 1, 4, height));

            }

            

            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            e.Graphics.DrawImage(Image, x, y, width, height);

            e.Graphics.DrawRectangle(Pens.DarkGray, new Rectangle(x, y, width + 1, height + 1));


            if (this.HorizontalScroll.Visible)
                width = width - this.AutoScrollPosition.X;
            if (this.VerticalScroll.Visible)
                height = height - this.AutoScrollPosition.Y;

            //e.Graphics.FillRectangle(Brushes.Red, new Rectangle(x, y, width, height));
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

        protected override void OnScroll(ScrollEventArgs se)
        {
            base.OnScroll(se);
            Invalidate();
        }

        protected override void OnMouseCaptureChanged(EventArgs e)
        {
            if(this.RectangleToScreen(new Rectangle(x, y, width, height)).Contains(MousePosition))
                base.OnMouseCaptureChanged(e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            if (this.RectangleToScreen(new Rectangle(x, y, width, height)).Contains(MousePosition))
                base.OnMouseEnter(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (this.RectangleToScreen(new Rectangle(x, y, width, height)).Contains(MousePosition))
                base.OnMouseMove(new MouseEventArgs(e.Button, e.Clicks, e.X - x, e.Y - y, e.Delta));
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (this.RectangleToScreen(new Rectangle(x, y, width, height)).Contains(MousePosition))
                base.OnMouseWheel(new MouseEventArgs(e.Button, e.Clicks, e.X - x, e.Y - y, e.Delta));
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (this.RectangleToScreen(new Rectangle(x, y, width, height)).Contains(MousePosition))
                base.OnMouseClick(new MouseEventArgs(e.Button, e.Clicks, e.X - x, e.Y - y, e.Delta));
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            if (this.RectangleToScreen(new Rectangle(x, y, width, height)).Contains(MousePosition))
                base.OnMouseDoubleClick(new MouseEventArgs(e.Button, e.Clicks, e.X - x, e.Y - y, e.Delta));
        }
    
        protected override void OnMouseHover(EventArgs e)
        {
            if (this.RectangleToScreen(new Rectangle(x, y, width, height)).Contains(MousePosition))
                base.OnMouseHover(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (this.RectangleToScreen(new Rectangle(x, y, width, height)).Contains(MousePosition))
                base.OnMouseLeave(e);
        }


        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (this.RectangleToScreen(new Rectangle(x, y, width, height)).Contains(MousePosition))
                base.OnMouseDown(new MouseEventArgs(e.Button, e.Clicks, e.X - x, e.Y - y, e.Delta));
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (this.RectangleToScreen(new Rectangle(x, y, width, height)).Contains(MousePosition))
                base.OnMouseUp(new MouseEventArgs(e.Button, e.Clicks, e.X - x, e.Y - y, e.Delta));
        }


    }
}