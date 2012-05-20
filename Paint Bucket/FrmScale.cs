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
    public partial class FrmScale : Form
    {
        public int Value { get { return (int)this.txtValue.Value; } set { this.txtValue.Value = value; } }

        public FrmScale()
        {
            InitializeComponent();         
        }

        private void FrmScale_Load(object sender, EventArgs e)
        {
            txtValue.Select(0, 4);
            this.Location = MousePosition;
        }

        private void txtValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                return;
            }
        }

    }
}
