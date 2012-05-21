using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VisualBounds.Imaging.PaintBucket
{
    public partial class FRM_ColorTransform : Form
    {
        public float Red
        {
            get;
            set;
        }
        public float Green
        {
            get;
            set;
        }
        public float Blue
        {
            get;
            set;
        }
        public float Alpha
        {
            get;
            set;
        }


        public FRM_ColorTransform()
        {
            InitializeComponent();
            TRACK_Red.Value = (int)Red;
            TRACK_Green.Value = (int)Green;
            TRACK_Blue.Value= (int)Blue;
            TRACK_Alpha.Value = (int)Alpha;

        }

        private void FRM_ColorTransform_Paint(object sender, PaintEventArgs e)
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

        private void FRM_ColorTransform_Activated(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void FRM_ColorTransform_Deactivate(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void TRACK_ValueChanged(object sender, EventArgs e)
        {
            TrackBar tracker = (TrackBar)sender;

            switch (tracker.Name)
            {
                case "TRACK_Red":
                    Red = tracker.Value;
                    break;
                case "TRACK_Green":
                    Green = tracker.Value;
                    break;
                case "TRACK_Blue":
                    Blue = tracker.Value;
                    break;
                case "TRACK_Alpha":
                    Alpha = tracker.Value;
                    break;
            }
        }
    }
}
