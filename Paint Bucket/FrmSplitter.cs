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
    public partial class FrmSplitter : Form
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

        public FrmSplitter()
        {
            InitializeComponent();
            comboExt.SelectedIndex = 6;
        }
    }
}
