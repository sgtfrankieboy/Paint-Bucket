using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace VisualBounds.Imaging.PaintBucket
{
    public partial class FrmMain : Form
    {
        public bool changedGlass = false;

        private static Properties.Settings Settings { get { return Properties.Settings.Default; } }

        public static Image source;
        public static Color color = Color.Maroon;

        public FrmMain(string[] args)
        {
            InitializeComponent();

            stripMenu.Renderer = new GlassToolstripRenderer();
            stripStatus.Renderer = new GlassToolstripRenderer();
            stripTools.Renderer = new GlassToolstripRenderer();


            backgroundToolStripMenuItem.Image = CreateColorImage(Settings.Background);
            defaultToolStripMenuItem.Image = CreateColorImage(Color.FromArgb(201, 211, 226));
            this.BackColor = Settings.Background;
            this.panelStatus.Visible = Settings.ViewStatusBar;
            if (!Settings.ViewToolBar)
                headerPanel.Height = 24;
            lblPos.Visible = Settings.ViewStatusBarCursorPosition;
            lblPosX.Visible = Settings.ViewStatusBarCursorPosition;
            lblPosSep.Visible = Settings.ViewStatusBarCursorPosition;
            lblPosY.Visible = Settings.ViewStatusBarCursorPosition;
            barProgress.Visible = Settings.ViewStatusBarStatus;
            lblReady.Visible = Settings.ViewStatusBarStatus;
            btnToolOpen.Visible = Settings.ViewToolBarFileFunctions;
            btnToolSave.Visible = Settings.ViewToolBarFileFunctions;
            toolStripSeparator2.Visible = Settings.ViewToolBarFileFunctions;
            btnImageScale.Visible = Settings.ViewToolBarZoom;
            toolStripSeparator3.Visible = Settings.ViewToolBarZoom;
            btnColor.Visible = Settings.ViewToolBarColor;
            toolStripSeparator4.Visible = Settings.ViewToolBarColor;

            this.statusBarToolStripMenuItem.Checked = Settings.ViewStatusBar;
            this.toolBarToolStripMenuItem.Checked = Settings.ViewToolBar;
            this.statusToolStripMenuItem.Checked = Settings.ViewStatusBarStatus;
            this.positionToolStripMenuItem.Checked = Settings.ViewStatusBarCursorPosition;
            this.fileFuctionsToolStripMenuItem.Checked = Settings.ViewToolBarFileFunctions;
            this.colorToolStripMenuItem.Checked = Settings.ViewToolBarColor;
            this.zoomToolStripMenuItem.Checked = Settings.ViewToolBarZoom;


            if (Win32API.Dwm.DwmIsCompositionEnabled())
            {
                Win32API.Dwm.MARGINS margin = new Win32API.Dwm.MARGINS(0, headerPanel.Height, 0, (Settings.ViewStatusBar ? 23 : 0));
                Win32API.Dwm.DwmExtendFrameIntoClientArea(this.Handle, margin);
            }
            btnColor.Image = CreateColorImage(color);
        }

        #region Misc

        private void FrmMain_Activated(object sender, EventArgs e)
        {
            headerPanel.BackColor = Color.FromArgb(185, 209, 234);
            Invalidate();
        }

        private void FrmMain_Deactivate(object sender, EventArgs e)
        {
            headerPanel.BackColor = Color.FromArgb(215, 228, 242);
            Invalidate();
        }

        public bool stripBars_Drag = false;

        private void stripBars_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Win32API.ReleaseCapture();
                Win32API.SendMessage(Handle, Win32API.WM_NCLBUTTONDOWN, Win32API.HT_CAPTION, 0);
            }
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {
            bool usingTheme = Win32API.GetThemeName() != "";
            bool ret = Win32API.Dwm.DwmIsCompositionEnabled();
            if (ret == true && changedGlass == false)
            {
                if (Win32API.Dwm.DwmIsCompositionEnabled())
                {
                    Win32API.Dwm.MARGINS margin = new Win32API.Dwm.MARGINS(0, headerPanel.Height, 0, (Settings.ViewStatusBar ? 23 : 0));
                    Win32API.Dwm.DwmExtendFrameIntoClientArea(this.Handle, margin);
                }
                changedGlass = true;
            }
            if (ret)
            {
                headerPanel.BackColor = Color.Black;
                panelStatus.BackColor = Color.Black;
                panelMain.BorderStyle = BorderStyle.None;
            }
            else
            {
                if (this.Handle == Win32API.GetForegroundWindow())
                    if (usingTheme)
                    {
                        headerPanel.BackColor = Color.FromArgb(185, 209, 234);
                        panelStatus.BackColor = Color.FromArgb(185, 209, 234);
                    }
                    else
                    {
                        headerPanel.BackColor = SystemColors.Control;
                        panelStatus.BackColor = SystemColors.Control;
                    }
                else
                    if (usingTheme)
                    {
                        headerPanel.BackColor = Color.FromArgb(215, 228, 242);
                        panelStatus.BackColor = Color.FromArgb(215, 228, 242);
                    }
                    else
                    {
                        headerPanel.BackColor = SystemColors.Control;
                        panelStatus.BackColor = SystemColors.Control;
                    }
                panelMain.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        #endregion

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x020A:
                    ImageScaleWnd(m);
                    break;
            }
            
            base.WndProc(ref m);
        }

        public void resizeImage()
        {
            if (source == null || Preview.BackgroundImage == null)
                return;

            Preview.BackgroundImage = CreatePreview();

            float ZoomFactor = int.Parse(btnImageScale.Text.Replace("%", "")) / 100F;
            Preview.Width = (int)(Preview.BackgroundImage.Width * ZoomFactor);
            Preview.Height = (int)(Preview.BackgroundImage.Height * ZoomFactor);

            int x = (scrollControl.Width - Preview.Width) / 2;
            int y = (scrollControl.Height - Preview.Height) / 2;
            if (x < 0)
                x = 0;
            if (y < 0)
                y = 0;

            Preview.Location = new Point(x, y);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            lblReady.Text = "Opening Image...";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                source = Image.FromFile(openFileDialog.FileName);
                Preview.BackgroundImage = CreatePreview();
                resizeImage();
                lblReady.Text = "Ready...";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            resizeImage();
        }


        #region PositionInfo

        private void image_MouseMove(object sender, MouseEventArgs e)
        {
            lblPosX.Text = e.X.ToString();
            lblPosY.Text = e.Y.ToString();
        }

        private void image_MouseLeave(object sender, EventArgs e)
        {
            lblPosX.Text = "0";
            lblPosY.Text = "0";
        }

        #endregion


        #region ImageScale

        public void ImageScaleWnd(Message m)
        {
            if (ImageScaleHover)
            {
                int val = int.Parse(btnImageScale.Text.Replace("%", ""));
                if (m.WParam.ToInt32() < 0)
                {
                    if (val < 26)
                        return;
                    btnImageScale.Text = (val - 1).ToString() + "%";
                }
                else
                {
                    if (val > 3199)
                        return;
                    btnImageScale.Text = (val + 1).ToString() + "%";
                }
            }
        }

        private void btnImageScale_ButtonClick(object sender, EventArgs e)
        {
            lblReady.Text = "Selecting Zoom Percentage....";
            ImageScaleHover = false;
            FrmScale fs = new FrmScale();
            fs.Value = int.Parse(btnImageScale.Text.Replace("%", ""));
            if (fs.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                btnImageScale.Text = fs.Value.ToString() + "%";
            }
            lblReady.Text = "Ready...";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            btnImageScale.Text = ((ToolStripMenuItem)sender).Text;
        }

        public bool ImageScaleHover = false;

        private void btnImageScale_MouseEnter(object sender, EventArgs e)
        {
            ImageScaleHover = true;
        }

        private void btnImageScale_MouseLeave(object sender, EventArgs e)
        {
            ImageScaleHover = false;
        }

        #endregion

        private void btnColor_Click(object sender, EventArgs e)
        {
            lblReady.Text = "Selecting Color...";
            colorDialog.Color = color;
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = colorDialog.Color;
                btnColor.Image = CreateColorImage(color);
            }
            lblReady.Text = "Ready...";
        }
        
        private Image CreateColorImage(Color colour)
        {
            lblReady.Text = "Creating Color Image...";
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
            lblReady.Text = "Ready...";
            return img;
        }

        private Image CreatePreview()
        {
            lblReady.Text = "Creating Preview...";
            float zoomFactor = float.Parse((btnImageScale.Text.Replace("%", ""))) / 100F;
            int newWidth = (int)(source.Width * zoomFactor);
            int newHeight = (int)(source.Height * zoomFactor);

            Image img = new Bitmap(newWidth, newHeight);

            using (Graphics g = Graphics.FromImage(img))
            {
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.CompositingQuality = CompositingQuality.AssumeLinear;
                g.SmoothingMode = SmoothingMode.None;

                g.DrawImage(source, new Rectangle(0, 0, newWidth, newHeight));
            }

            lblReady.Text = "Ready...";
            return img;

        }

        private void btnImageScale_TextChanged(object sender, EventArgs e)
        {
            resizeImage();
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelStatus.Visible = statusBarToolStripMenuItem.Checked;
            Settings.ViewStatusBar = statusBarToolStripMenuItem.Checked;
            Settings.Save();
            if (Win32API.Dwm.DwmIsCompositionEnabled())
            {
                Win32API.Dwm.MARGINS margin = new Win32API.Dwm.MARGINS(0, headerPanel.Height, 0, (Settings.ViewStatusBar ? 23 : 0));
                Win32API.Dwm.DwmExtendFrameIntoClientArea(this.Handle, margin);
            }
        }

        private void positionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.ViewStatusBarCursorPosition = positionToolStripMenuItem.Checked;
            lblPos.Visible = Settings.ViewStatusBarCursorPosition;
            lblPosX.Visible = Settings.ViewStatusBarCursorPosition;
            lblPosSep.Visible = Settings.ViewStatusBarCursorPosition;
            lblPosY.Visible = Settings.ViewStatusBarCursorPosition;
            Settings.Save();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.ViewStatusBarStatus = statusToolStripMenuItem.Checked;
            barProgress.Visible = Settings.ViewStatusBarStatus;
            lblReady.Visible = Settings.ViewStatusBarStatus;
            Settings.Save();
        }


        private void toolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            headerPanel.Height = (Settings.ViewToolBar ? 24 : 47);
            Settings.ViewToolBar = toolBarToolStripMenuItem.Checked;
            Settings.Save();
            if (Win32API.Dwm.DwmIsCompositionEnabled())
            {
                Win32API.Dwm.MARGINS margin = new Win32API.Dwm.MARGINS(0, headerPanel.Height, 0, (Settings.ViewStatusBar ? 23 : 0));
                Win32API.Dwm.DwmExtendFrameIntoClientArea(this.Handle, margin);
            }
        }

        private void fileFuctionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.ViewToolBarFileFunctions = fileFuctionsToolStripMenuItem.Checked;
            btnToolOpen.Visible = Settings.ViewToolBarFileFunctions;
            btnToolSave.Visible = Settings.ViewToolBarFileFunctions;
            toolStripSeparator2.Visible = Settings.ViewToolBarFileFunctions;
            Settings.Save();
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.ViewToolBarZoom = zoomToolStripMenuItem.Checked;
            btnImageScale.Visible = Settings.ViewToolBarZoom;
            toolStripSeparator3.Visible = Settings.ViewToolBarZoom;
            Settings.Save();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.ViewToolBarColor = colorToolStripMenuItem.Checked;
            btnColor.Visible = Settings.ViewToolBarColor;
            toolStripSeparator4.Visible = Settings.ViewToolBarColor;
            Settings.Save();
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblReady.Text = "Selecting Background Color...";
            colorDialog.Color = Settings.Background;
            btnView.HideDropDown();
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Settings.Background = colorDialog.Color;
                Settings.Save();
                backgroundToolStripMenuItem.Image = CreateColorImage(colorDialog.Color);
                this.BackColor = colorDialog.Color;
            }
            lblReady.Text = "Ready...";
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color col = Color.FromArgb(201, 211, 226);
            Settings.Background = col;
            backgroundToolStripMenuItem.Image = CreateColorImage(col);
            this.BackColor = col;
            Settings.Save();
        }

    }
}
