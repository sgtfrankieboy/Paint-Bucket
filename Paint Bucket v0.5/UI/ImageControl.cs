using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VisualBounds.Imaging.PaintBucket.UI
{
    public partial class ImageControl : UserControl
    {
        #region Declaration

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

            int width = (int)(Image.Width * ScaleFactor);
            int height = (int)(Image.Height * ScaleFactor);
            Size size = new Size(width, height);
            int x, y;

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

            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            e.Graphics.DrawImage(Image, x, y, width, height);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

    }
}