using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Taskbar;

namespace VisualBounds.Imaging.PaintBucket
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            TabbedThumbnail thumbnail = new TabbedThumbnail(this.Handle, imageControl1);
            TaskbarManager.Instance.TabbedThumbnail.AddThumbnailPreview(thumbnail);
            thumbnail.SetImage(new Bitmap(imageControl1.Image));
            thumbnail.DisplayFrameAroundBitmap = false;
            thumbnail.Title = "Paint Bucket";
            thumbnail.SetWindowIcon(this.Icon);
        }
    }
}
