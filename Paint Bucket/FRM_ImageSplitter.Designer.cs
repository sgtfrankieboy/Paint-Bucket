namespace VisualBounds.Imaging.PaintBucket
{
    partial class FRM_ImageSplitter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ImageSplitter));
            this.PANEL_Controls = new System.Windows.Forms.Panel();
            this.btnCancel = new VisualBounds.Imaging.PaintBucket.GlassButton();
            this.btnSplit = new VisualBounds.Imaging.PaintBucket.GlassButton();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboExt = new System.Windows.Forms.ComboBox();
            this.PANEL_Controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // PANEL_Controls
            // 
            this.PANEL_Controls.BackColor = System.Drawing.SystemColors.Control;
            this.PANEL_Controls.Controls.Add(this.btnCancel);
            this.PANEL_Controls.Controls.Add(this.btnSplit);
            this.PANEL_Controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PANEL_Controls.Location = new System.Drawing.Point(0, 64);
            this.PANEL_Controls.Name = "PANEL_Controls";
            this.PANEL_Controls.Size = new System.Drawing.Size(170, 37);
            this.PANEL_Controls.TabIndex = 0;
            this.PANEL_Controls.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelButtons_MouseDown);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnCancel.Location = new System.Drawing.Point(7, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.text = "Cancel";
            this.btnCancel.UseCompatibleTextRendering = true;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSplit
            // 
            this.btnSplit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnSplit.Location = new System.Drawing.Point(88, 7);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(75, 23);
            this.btnSplit.TabIndex = 0;
            this.btnSplit.text = "Split";
            this.btnSplit.UseCompatibleTextRendering = true;
            this.btnSplit.UseVisualStyleBackColor = true;
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(59, 12);
            this.numWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(54, 20);
            this.numWidth.TabIndex = 1;
            this.numWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(59, 38);
            this.numHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(54, 20);
            this.numHeight.TabIndex = 1;
            this.numHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height:";
            // 
            // comboExt
            // 
            this.comboExt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboExt.FormattingEnabled = true;
            this.comboExt.Items.AddRange(new object[] {
            "bmp",
            "emf",
            "exif",
            "gif",
            "icon",
            "jpeg",
            "png",
            "tiff",
            "wmf"});
            this.comboExt.Location = new System.Drawing.Point(119, 12);
            this.comboExt.Name = "comboExt";
            this.comboExt.Size = new System.Drawing.Size(44, 21);
            this.comboExt.TabIndex = 3;
            // 
            // FRM_ImageSplitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(170, 101);
            this.Controls.Add(this.comboExt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.PANEL_Controls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_ImageSplitter";
            this.Text = "Image Splitter";
            this.Activated += new System.EventHandler(this.FRM_ImageSplitter_Activated);
            this.Deactivate += new System.EventHandler(this.FRM_ImageSplitter_Deactivate);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FRM_ImageSplitter_Paint);
            this.PANEL_Controls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_Controls;
        private GlassButton btnCancel;
        private GlassButton btnSplit;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboExt;
    }
}