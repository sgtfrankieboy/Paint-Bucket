using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Taskbar;

namespace VisualBounds.Imaging.PaintBucket
{
    public partial class FrmMain : Form
    {
        public IGraphics.IImage image;

        public FrmMain()
        {
            InitializeComponent();

            image = new IGraphics.IImage();
            image.SetName("Test");

            this.Text = image.Name;



            UI.Dwm.MARGINS margin = new UI.Dwm.MARGINS(0, 50, 0, 25);
            UI.Dwm.DwmExtendFrameIntoClientArea(this.Handle, margin);
   
            InitalizeDWM();
        }


        public void InitalizeDWM()
        {
            TabbedThumbnail thumbnail = new TabbedThumbnail(this.Handle, Editor);
            TaskbarManager.Instance.TabbedThumbnail.AddThumbnailPreview(thumbnail);
            thumbnail.SetImage(new Bitmap(Editor.Image));
            thumbnail.DisplayFrameAroundBitmap = false;
            thumbnail.Title = "Paint Bucket";
            thumbnail.SetWindowIcon(this.Icon);
        }

        private void Editor_MouseHover(object sender, EventArgs e)
        {
        }

        private void Editor_MouseDown(object sender, MouseEventArgs e)
        {
            image.SetName("Dumdum");
            this.Text = image.Name;
        }

        private void Editor_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Editor_MouseEnter(object sender, EventArgs e)
        {
            this.Text = "Enter";
        }

        private void Editor_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Leave";
        }

        private void BTN_Menu_Edit_Undo_Click(object sender, EventArgs e)
        {
            image.Manager.Undo();
        }

        private void BTN_Menu_Edit_Redo_Click(object sender, EventArgs e)
        {
            image.Manager.Redo();
        }

        private void BTN_Menu_Edit_Cut_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Menu_Edit_Copy_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Edit_Menu_Paste_Click(object sender, EventArgs e)
        {

        }

        private void Editor_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

    }
}
