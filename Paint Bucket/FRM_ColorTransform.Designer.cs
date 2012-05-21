namespace VisualBounds.Imaging.PaintBucket
{
    partial class FRM_ColorTransform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PANEL_Controls = new System.Windows.Forms.Panel();
            this.BTN_Cancel = new VisualBounds.Imaging.PaintBucket.GlassButton();
            this.BTN_Transform = new VisualBounds.Imaging.PaintBucket.GlassButton();
            this.TRACK_Red = new System.Windows.Forms.TrackBar();
            this.TRACK_Green = new System.Windows.Forms.TrackBar();
            this.TRACK_Blue = new System.Windows.Forms.TrackBar();
            this.TRACK_Alpha = new System.Windows.Forms.TrackBar();
            this.LBL_Red = new System.Windows.Forms.Label();
            this.LBL_Green = new System.Windows.Forms.Label();
            this.LBL_Blue = new System.Windows.Forms.Label();
            this.LBL_Alpha = new System.Windows.Forms.Label();
            this.PANEL_Controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TRACK_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRACK_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRACK_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRACK_Alpha)).BeginInit();
            this.SuspendLayout();
            // 
            // PANEL_Controls
            // 
            this.PANEL_Controls.BackColor = System.Drawing.SystemColors.Control;
            this.PANEL_Controls.Controls.Add(this.BTN_Cancel);
            this.PANEL_Controls.Controls.Add(this.BTN_Transform);
            this.PANEL_Controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PANEL_Controls.Location = new System.Drawing.Point(0, 110);
            this.PANEL_Controls.Name = "PANEL_Controls";
            this.PANEL_Controls.Size = new System.Drawing.Size(256, 48);
            this.PANEL_Controls.TabIndex = 1;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(88, 13);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 2;
            this.BTN_Cancel.text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // BTN_Transform
            // 
            this.BTN_Transform.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Transform.Location = new System.Drawing.Point(169, 13);
            this.BTN_Transform.Name = "BTN_Transform";
            this.BTN_Transform.Size = new System.Drawing.Size(75, 23);
            this.BTN_Transform.TabIndex = 1;
            this.BTN_Transform.text = "Transform";
            this.BTN_Transform.UseVisualStyleBackColor = true;
            // 
            // TRACK_Red
            // 
            this.TRACK_Red.Location = new System.Drawing.Point(59, 12);
            this.TRACK_Red.Name = "TRACK_Red";
            this.TRACK_Red.Size = new System.Drawing.Size(185, 45);
            this.TRACK_Red.TabIndex = 2;
            this.TRACK_Red.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TRACK_Red.Value = 1;
            this.TRACK_Red.ValueChanged += new System.EventHandler(this.TRACK_ValueChanged);
            // 
            // TRACK_Green
            // 
            this.TRACK_Green.Location = new System.Drawing.Point(59, 35);
            this.TRACK_Green.Name = "TRACK_Green";
            this.TRACK_Green.Size = new System.Drawing.Size(185, 45);
            this.TRACK_Green.TabIndex = 2;
            this.TRACK_Green.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TRACK_Green.Value = 1;
            this.TRACK_Green.ValueChanged += new System.EventHandler(this.TRACK_ValueChanged);
            // 
            // TRACK_Blue
            // 
            this.TRACK_Blue.Location = new System.Drawing.Point(59, 59);
            this.TRACK_Blue.Name = "TRACK_Blue";
            this.TRACK_Blue.Size = new System.Drawing.Size(185, 45);
            this.TRACK_Blue.TabIndex = 2;
            this.TRACK_Blue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TRACK_Blue.Value = 1;
            this.TRACK_Blue.ValueChanged += new System.EventHandler(this.TRACK_ValueChanged);
            // 
            // TRACK_Alpha
            // 
            this.TRACK_Alpha.Location = new System.Drawing.Point(59, 82);
            this.TRACK_Alpha.Name = "TRACK_Alpha";
            this.TRACK_Alpha.Size = new System.Drawing.Size(185, 45);
            this.TRACK_Alpha.TabIndex = 2;
            this.TRACK_Alpha.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TRACK_Alpha.Value = 1;
            this.TRACK_Alpha.ValueChanged += new System.EventHandler(this.TRACK_ValueChanged);
            // 
            // LBL_Red
            // 
            this.LBL_Red.AutoSize = true;
            this.LBL_Red.Location = new System.Drawing.Point(26, 15);
            this.LBL_Red.Name = "LBL_Red";
            this.LBL_Red.Size = new System.Drawing.Size(27, 13);
            this.LBL_Red.TabIndex = 3;
            this.LBL_Red.Text = "Red";
            // 
            // LBL_Green
            // 
            this.LBL_Green.AutoSize = true;
            this.LBL_Green.Location = new System.Drawing.Point(17, 38);
            this.LBL_Green.Name = "LBL_Green";
            this.LBL_Green.Size = new System.Drawing.Size(36, 13);
            this.LBL_Green.TabIndex = 3;
            this.LBL_Green.Text = "Green";
            // 
            // LBL_Blue
            // 
            this.LBL_Blue.AutoSize = true;
            this.LBL_Blue.Location = new System.Drawing.Point(25, 62);
            this.LBL_Blue.Name = "LBL_Blue";
            this.LBL_Blue.Size = new System.Drawing.Size(28, 13);
            this.LBL_Blue.TabIndex = 3;
            this.LBL_Blue.Text = "Blue";
            // 
            // LBL_Alpha
            // 
            this.LBL_Alpha.AutoSize = true;
            this.LBL_Alpha.Location = new System.Drawing.Point(19, 84);
            this.LBL_Alpha.Name = "LBL_Alpha";
            this.LBL_Alpha.Size = new System.Drawing.Size(34, 13);
            this.LBL_Alpha.TabIndex = 3;
            this.LBL_Alpha.Text = "Alpha";
            // 
            // FRM_ColorTransform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(256, 158);
            this.Controls.Add(this.LBL_Alpha);
            this.Controls.Add(this.LBL_Blue);
            this.Controls.Add(this.LBL_Green);
            this.Controls.Add(this.LBL_Red);
            this.Controls.Add(this.PANEL_Controls);
            this.Controls.Add(this.TRACK_Alpha);
            this.Controls.Add(this.TRACK_Blue);
            this.Controls.Add(this.TRACK_Green);
            this.Controls.Add(this.TRACK_Red);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_ColorTransform";
            this.Text = "Color Transform";
            this.Activated += new System.EventHandler(this.FRM_ColorTransform_Activated);
            this.Deactivate += new System.EventHandler(this.FRM_ColorTransform_Deactivate);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FRM_ColorTransform_Paint);
            this.PANEL_Controls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TRACK_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRACK_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRACK_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRACK_Alpha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_Controls;
        private GlassButton BTN_Transform;
        private GlassButton BTN_Cancel;
        private System.Windows.Forms.TrackBar TRACK_Red;
        private System.Windows.Forms.TrackBar TRACK_Green;
        private System.Windows.Forms.TrackBar TRACK_Blue;
        private System.Windows.Forms.TrackBar TRACK_Alpha;
        private System.Windows.Forms.Label LBL_Red;
        private System.Windows.Forms.Label LBL_Green;
        private System.Windows.Forms.Label LBL_Blue;
        private System.Windows.Forms.Label LBL_Alpha;

    }
}