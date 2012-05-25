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
using System.Threading;
using System.Drawing.Imaging;

namespace VisualBounds.Imaging.PaintBucket
{
    public partial class FRM_Main : Form
    {
        private static Properties.Settings Settings { get { return Properties.Settings.Default; } }

        public static EImage Source;
        public static Color color = Color.Maroon;
        Bitmap screen;
        bool MouseDownPreview = false;

        public FRM_Main(string[] args)
        {
            InitializeComponent();

            STRIP_Menu.Renderer = new GlassToolstripRenderer();
            STRIP_Status.Renderer = new GlassToolstripRenderer();
            STRIP_Settings.Renderer = new GlassToolstripRenderer();
            STRIP_Tools.Renderer = new GlassToolstripRenderer();

            LoadSettings();

            if (Win32API.Dwm.DwmIsCompositionEnabled())
            {
                Win32API.Dwm.MARGINS margin = new Win32API.Dwm.MARGINS(0, PANEL_Header.Height, 0, (Settings.ViewStatusBar ? 23 : 0));
                Win32API.Dwm.DwmExtendFrameIntoClientArea(this.Handle, margin);
            }
            BTN_Settings_Color.Image = GraphicsHelper.CreateColorImage(color);
        }

        public void LoadSettings()
        {
            BTN_Menu_View_Background.Image = GraphicsHelper.CreateColorImage(Settings.Background);
            BTN_Menu_View_Background_Default.Image = GraphicsHelper.CreateColorImage(Color.FromArgb(201, 211, 226));
            this.BackColor = Settings.Background;
        }

        private void SplitImage(object args)
        {
            FRM_ImageSplitter split = (FRM_ImageSplitter)args;

            int width = split.ImageSize.Width;
            int height = split.ImageSize.Height;

            int current = 0;
            int rows = (split.Source.Width / split.ImageSize.Width);
            int columns = (split.Source.Height / split.ImageSize.Height);
            int total = rows * columns;

            this.Invoke((MethodInvoker)delegate
            {
                PROGRESS_Status_bar.Maximum = total;
            });

            for (int j = 0; j < rows; j++)
            {
                for (int i = 0; i < columns; i++)
                {
                    Image curImage = new Bitmap(split.ImageSize.Width, split.ImageSize.Height);
                    int x = i * split.ImageSize.Height;
                    int y = j * split.ImageSize.Width;
                    Rectangle rect = new Rectangle(new Point(x, y), split.ImageSize);
                    using (Graphics g = Graphics.FromImage(curImage))
                    {
                        g.DrawImage(split.Source, 0, 0, rect, GraphicsUnit.Pixel);
                    }
                    curImage.Save(split.Path + @"\" + current.ToString() + "." + split.FormatString, split.Format);
                    current++;
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.PROGRESS_Status_bar.Value++;
                    });
                }
            }
            this.Invoke((MethodInvoker)delegate
            {
                this.PROGRESS_Status_bar.Value = 0;
                this.LBL_Status_Info.Text = "Ready...";
            });
        }

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

#region Menu Items

        #region File

        private void BTN_Menu_File_Open_Click(object sender, EventArgs e)
        {
            LBL_Status_Info.Text = "Opening Image...";
            if (DIALOG_Open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Source = new EImage(Image.FromFile(DIALOG_Open.FileName));
                PREVIEW.BackgroundImage = Source.ScaledPreview();
                resizeImage();
                BTN_Tools_ColorRemover.Enabled = true;
                BTN_Menu_File_Save.Enabled = true;
                BTN_Settings_Save.Enabled = true;
                BTN_Menu_Image.Enabled = true;
                LBL_Status_Info.Text = "Ready...";
            }
        }

        private void BTN_Menu_File_Save_Click(object sender, EventArgs e)
        {
            if (DIALOG_Save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Source.UnscaledPreview().Save(DIALOG_Save.FileName);
            }
        }

        private void BTN_Menu_File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

#endregion

        #region View

        #region Background

        private void BTN_Menu_View_Background_Click(object sender, EventArgs e)
        {
            LBL_Status_Info.Text = "Selecting Background Color...";
            DIALOG_Color.Color = Settings.Background;
            BTN_Menu_View.HideDropDown();
            if (DIALOG_Color.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Settings.Background = DIALOG_Color.Color;
                Settings.Save();
                BTN_Menu_View_Background.Image = GraphicsHelper.CreateColorImage(DIALOG_Color.Color);
                this.BackColor = DIALOG_Color.Color;
            }
            LBL_Status_Info.Text = "Ready...";
        }

        private void BTN_Menu_View_Background_Default_Click(object sender, EventArgs e)
        {
            Color col = Color.FromArgb(201, 211, 226);
            Settings.Background = col;
            BTN_Menu_View_Background.Image = GraphicsHelper.CreateColorImage(col);
            this.BackColor = col;
            Settings.Save();
        }

        #endregion

#endregion

        #region Image

        #region Transform

        private void BTN_Menu_Image_Transform_Negative_Click(object sender, EventArgs e)
        {
            Source.Invert();
            PREVIEW.BackgroundImage = Source.ScaledPreview();
        }

        private void BTN_Menu_Image_Transform_Grayscale_Click(object sender, EventArgs e)
        {
            Source.GrayScale();
            PREVIEW.BackgroundImage = Source.ScaledPreview();
        }

        private void BTN_Menu_Image_Transform_ColorTransform_Click(object sender, EventArgs e)
        {

        }

        #endregion

#endregion

        #region Utilities

        private void BTN_Menu_Utilities_ImageSplitter_Click(object sender, EventArgs e)
        {

        }

#endregion

        #endregion

#region Resizing

        public void resizeImage()
        {
            if (Source == null || PREVIEW.BackgroundImage == null)
                return;

            float ZoomFactor = int.Parse(BTN_Settings_Zoom.Text.Replace("%", "")) / 100F;
            PREVIEW.Width = (int)(PREVIEW.BackgroundImage.Width * ZoomFactor);
            PREVIEW.Height = (int)(PREVIEW.BackgroundImage.Height * ZoomFactor);

            Source.ZoomFactor = ZoomFactor;
            PREVIEW.BackgroundImage = Source.ScaledPreview();

            int x = (PANEL_Main_Scroll.Width - PREVIEW.Width) / 2;
            int y = (PANEL_Main_Scroll.Height - PREVIEW.Height) / 2;
            if (x < 0)
                x = 0;
            if (y < 0)
                y = 0;

            PREVIEW.Location = new Point(x, y);
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            resizeImage();
        }

        public bool ImageScaleHover = false;

        public void ImageScaleWnd(Message m)
        {
            if (ImageScaleHover)
            {
                int val = int.Parse(BTN_Settings_Zoom.Text.Replace("%", ""));
                if (m.WParam.ToInt32() < 0)
                {
                    if (val < 26)
                        return;
                    BTN_Settings_Zoom.Text = (val - 1).ToString() + "%";
                }
                else
                {
                    if (val > 3199)
                        return;
                    BTN_Settings_Zoom.Text = (val + 1).ToString() + "%";
                }
            }
        }

        private void BTN_Settings_Zoom_TextChanged(object sender, EventArgs e)
        {
            resizeImage();
        }

        #endregion

#region Settings

        #region Zoom

        private void BTN_Settings_Zoom_ButtonClick(object sender, EventArgs e)
        {
            LBL_Status_Info.Text = "Selecting Zoom Percentage....";
            ImageScaleHover = false;
            FRM_Zoom fs = new FRM_Zoom();
            fs.Value = int.Parse(BTN_Settings_Zoom.Text.Replace("%", ""));
            if (fs.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BTN_Settings_Zoom.Text = fs.Value.ToString() + "%";
            }
            LBL_Status_Info.Text = "Ready...";
        }

        private void BTN_Settings_Zoom_MouseEnter(object sender, EventArgs e)
        {
            ImageScaleHover = true;
        }

        private void BTN_Settings_Zoom_MouseLeave(object sender, EventArgs e)
        {
            ImageScaleHover = false;
        }

        private void BTN_Settings_Zoom_Percentage_Click(object sender, EventArgs e)
        {
            BTN_Settings_Zoom.Text = ((ToolStripMenuItem)sender).Text;
        }

        #endregion

        private void BTN_Settings_Color_Click(object sender, EventArgs e)
        {
            LBL_Status_Info.Text = "Selecting Color...";
            DIALOG_Color.Color = color;
            if (DIALOG_Color.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = DIALOG_Color.Color;
                BTN_Settings_Color.Image = GraphicsHelper.CreateColorImage(color);
            }
            LBL_Status_Info.Text = "Ready...";
        }

#endregion

#region Tools

        private void BTN_Tools_ColorRemover_Click(object sender, EventArgs e)
        {
            if (BTN_Tools_ColorRemover.Checked)
                PREVIEW.Cursor = Cursors.Cross;
            else
                PREVIEW.Cursor = Cursors.Default;
        }

#endregion

#region Preview

        private void PREVIEW_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDownPreview = false;
            if (BTN_Tools_ColorRemover.Checked)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Source.MakeTransparent(0, color);
                }
                else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    color = screen.GetPixel(MousePosition.X, MousePosition.Y);
                    BTN_Settings_Color.Image = GraphicsHelper.CreateColorImage(color);
                    Source.MakeTransparent(0, color);
                }
                PREVIEW.BackgroundImage = Source.ScaledPreview();
            }
        }

        private void PREVIEW_MouseHover(object sender, EventArgs e)
        {

        }

        private void PREVIEW_MouseEnter(object sender, EventArgs e)
        {

        }

        private void PREVIEW_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownPreview = true;
            screen = Win32API.GetDesktop();
        }

        private void PREVIEW_MouseCaptureChanged(object sender, EventArgs e)
        {
        }

        private void PREVIEW_MouseMove(object sender, MouseEventArgs e)
        {
            LBL_Status_Position_X.Text = e.X.ToString();
            LBL_Status_Position_Y.Text = e.Y.ToString();

            if (screen != null && MouseDownPreview &&  BTN_Tools_ColorRemover.Checked)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Source.MakeTransparent(0, color);
                }
                else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    color = screen.GetPixel(MousePosition.X, MousePosition.Y);
                    BTN_Settings_Color.Image = GraphicsHelper.CreateColorImage(color);
                    Source.MakeTransparent(0, color);
                }
                PREVIEW.BackgroundImage = Source.ScaledPreview();
            }
        }

        private void PREVIEW_MouseLeave(object sender, EventArgs e)
        {
            LBL_Status_Position_X.Text = "0";
            LBL_Status_Position_Y.Text = "0";
        }

#endregion

#region GUI

        private bool GUI_Switched = false;

        private void FRM_Main_Paint(object sender, PaintEventArgs e)
        {
            Checks.Theme theme = Checks.CheckTheme();

            if (theme == Checks.Theme.Aero)
            {
                Win32API.Dwm.MARGINS margin = new Win32API.Dwm.MARGINS(0, PANEL_Header.Height, 0, (Settings.ViewStatusBar ? 23 : 0));
                Win32API.Dwm.DwmExtendFrameIntoClientArea(this.Handle, margin);
                PANEL_Header.BackColor = Color.Black;
                PANEL_Status.BackColor = Color.Black;
                PANEL_Main.BorderStyle = BorderStyle.None;
            }
            else if (theme == Checks.Theme.Basic)
            {
                if (Checks.isActive(this.Handle))
                {
                    PANEL_Header.BackColor = Color.FromArgb(185, 209, 234);
                    PANEL_Status.BackColor = Color.FromArgb(185, 209, 234);
                }
                else
                {
                    PANEL_Header.BackColor = Color.FromArgb(215, 228, 242);
                    PANEL_Status.BackColor = Color.FromArgb(215, 228, 242);
                }
                PANEL_Main.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                PANEL_Header.BackColor = SystemColors.Control;
                PANEL_Status.BackColor = SystemColors.Control;
                PANEL_Main.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void FRM_Main_Activated(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void FRM_Main_Deactivate(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void STRIP_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Win32API.ReleaseCapture();
                Win32API.SendMessage(Handle, Win32API.WM_NCLBUTTONDOWN, Win32API.HT_CAPTION, 0);
            }
        }

        #endregion


    }
}
