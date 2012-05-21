using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace VisualBounds.Imaging.PaintBucket
{
    public partial class FRM_ImageSplitter : Form
    {
        public Size ImageSize {
            get
            {
                return new Size((int)numWidth.Value, (int)numHeight.Value);
            }
            set
            {
                numWidth.Value = value.Width;
                numHeight.Value = value.Height;
            }      
        }

        public ImageFormat Format
        {
            get
            {
                switch (comboExt.SelectedItem.ToString())
                {
                    case "bmp":
                        return ImageFormat.Bmp;
                    case "emf":
                        return ImageFormat.Emf;
                    case "exif":
                        return ImageFormat.Exif;
                    case "gif":
                        return ImageFormat.Gif;
                    case "icon":
                        return ImageFormat.Icon;
                    case "jpeg":
                        return ImageFormat.Jpeg;
                    case "png":
                        return ImageFormat.Png;
                    case "tiff":
                        return ImageFormat.Tiff;
                    case "wmf":
                        return ImageFormat.Wmf;
                    default:
                        return ImageFormat.Png;
                }
            }
        }

        public string FormatString
        {
            get { return comboExt.SelectedItem.ToString(); }
        }

        public string Path
        {
            get;
            set;
        }

        public Image Source { get; set; }

        public FRM_ImageSplitter()
        {
            InitializeComponent();
            comboExt.SelectedIndex = 6;
        }

        private void panelButtons_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Win32API.ReleaseCapture();
                Win32API.SendMessage(Handle, Win32API.WM_NCLBUTTONDOWN, Win32API.HT_CAPTION, 0);
            }
        }

        private void FRM_ImageSplitter_Paint(object sender, PaintEventArgs e)
        {
            Checks.Theme theme = Checks.CheckTheme();
            if (theme == Checks.Theme.Aero)
            {
                Win32API.Dwm.DwmExtendFrameIntoClientArea(this.Handle, new Win32API.Dwm.MARGINS(0, 0, 0, PANEL_Controls.Height));
                PANEL_Controls.BackColor = Color.Black;
            }
            else if (theme == Checks.Theme.Basic)
                if (Checks.isActive(this.Handle))
                    PANEL_Controls.BackColor = Color.FromArgb(185, 209, 234);
                else
                    PANEL_Controls.BackColor = Color.FromArgb(215, 228, 242);
            else
                PANEL_Controls.BackColor = SystemColors.Control;
        }

        private void FRM_ImageSplitter_Activated(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void FRM_ImageSplitter_Deactivate(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
