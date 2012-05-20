namespace VisualBounds.Imaging.PaintBucket
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Icons = new System.Windows.Forms.ImageList(this.components);
            this.ribbonIcons = new System.Windows.Forms.ImageList(this.components);
            this.headerPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.stripTools = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnColor = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.stripMenu = new System.Windows.Forms.ToolStrip();
            this.btnView = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileFuctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.scrollControl = new System.Windows.Forms.ScrollableControl();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.stripStatus = new System.Windows.Forms.ToolStrip();
            this.barProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.lblReady = new System.Windows.Forms.ToolStripLabel();
            this.lblPosY = new System.Windows.Forms.ToolStripLabel();
            this.lblPosSep = new System.Windows.Forms.ToolStripLabel();
            this.lblPosX = new System.Windows.Forms.ToolStripLabel();
            this.Preview = new System.Windows.Forms.PictureBox();
            this.btnToolOpen = new System.Windows.Forms.ToolStripButton();
            this.btnToolSave = new System.Windows.Forms.ToolStripButton();
            this.btnImageScale = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImageSplitter = new System.Windows.Forms.ToolStripButton();
            this.btnColourRemover = new System.Windows.Forms.ToolStripButton();
            this.btnFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPos = new System.Windows.Forms.ToolStripLabel();
            this.headerPanel.SuspendLayout();
            this.stripTools.SuspendLayout();
            this.stripMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.scrollControl.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.stripStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Preview)).BeginInit();
            this.SuspendLayout();
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            this.colorDialog.ShowHelp = true;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Selection location to save splitted images to.";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All Images|*.bmp;*.gif;*.jpeg;*.jpg;*.png;*.tiff|Bitmap|*.bmp|Graphical Interchan" +
    "ge Format|*.gif|JPEG|*.jpeg;*.jpg|Portable Network Graphic|*.png|Tagged Image Fi" +
    "le Format|*.tiff";
            this.openFileDialog.Title = "Paint Bucket - Open Image";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = resources.GetString("saveFileDialog.Filter");
            this.saveFileDialog.Title = "Paint Bucket - Save Image";
            // 
            // Icons
            // 
            this.Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Icons.ImageStream")));
            this.Icons.TransparentColor = System.Drawing.Color.Transparent;
            this.Icons.Images.SetKeyName(0, "1337428682_emblem-photos.ico");
            this.Icons.Images.SetKeyName(1, "1337444930_insert-image.ico");
            this.Icons.Images.SetKeyName(2, "1337446435_gtk-leave-fullscreen.ico");
            // 
            // ribbonIcons
            // 
            this.ribbonIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ribbonIcons.ImageStream")));
            this.ribbonIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ribbonIcons.Images.SetKeyName(0, "fileopen_32x32x32.png");
            this.ribbonIcons.Images.SetKeyName(1, "filesave_32x32x32.png");
            this.ribbonIcons.Images.SetKeyName(2, "filesave_red_32x32x32.png");
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.panel4);
            this.headerPanel.Controls.Add(this.stripTools);
            this.headerPanel.Controls.Add(this.panel3);
            this.headerPanel.Controls.Add(this.stripMenu);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(890, 47);
            this.headerPanel.TabIndex = 4;
            this.headerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.headerPanel_Paint);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(0, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(891, 10);
            this.panel4.TabIndex = 11;
            // 
            // stripTools
            // 
            this.stripTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stripTools.AutoSize = false;
            this.stripTools.BackColor = System.Drawing.Color.Transparent;
            this.stripTools.Dock = System.Windows.Forms.DockStyle.None;
            this.stripTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.stripTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnToolOpen,
            this.btnToolSave,
            this.toolStripSeparator2,
            this.btnImageScale,
            this.toolStripSeparator3,
            this.btnColor,
            this.toolStripSeparator4,
            this.btnImageSplitter,
            this.btnColourRemover});
            this.stripTools.Location = new System.Drawing.Point(2, 22);
            this.stripTools.Name = "stripTools";
            this.stripTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.stripTools.Size = new System.Drawing.Size(889, 25);
            this.stripTools.TabIndex = 9;
            this.stripTools.Text = "toolStrip1";
            this.stripTools.MouseDown += new System.Windows.Forms.MouseEventHandler(this.stripBars_MouseDown);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnColor
            // 
            this.btnColor.AutoSize = false;
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(22, 22);
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(-17, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 21);
            this.panel3.TabIndex = 10;
            // 
            // stripMenu
            // 
            this.stripMenu.BackColor = System.Drawing.Color.Transparent;
            this.stripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.stripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFile,
            this.btnView});
            this.stripMenu.Location = new System.Drawing.Point(0, 0);
            this.stripMenu.Name = "stripMenu";
            this.stripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.stripMenu.Size = new System.Drawing.Size(890, 25);
            this.stripMenu.TabIndex = 12;
            this.stripMenu.Text = "toolStrip2";
            this.stripMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.stripBars_MouseDown);
            // 
            // btnView
            // 
            this.btnView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarToolStripMenuItem,
            this.toolBarToolStripMenuItem,
            this.toolStripSeparator5,
            this.backgroundToolStripMenuItem});
            this.btnView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(45, 22);
            this.btnView.Text = "View";
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.positionToolStripMenuItem,
            this.statusToolStripMenuItem});
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.statusBarToolStripMenuItem.Text = "Status Bar";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.statusBarToolStripMenuItem_Click);
            // 
            // positionToolStripMenuItem
            // 
            this.positionToolStripMenuItem.Checked = true;
            this.positionToolStripMenuItem.CheckOnClick = true;
            this.positionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.positionToolStripMenuItem.Name = "positionToolStripMenuItem";
            this.positionToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.positionToolStripMenuItem.Text = "Cursor Position";
            this.positionToolStripMenuItem.Click += new System.EventHandler(this.positionToolStripMenuItem_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Checked = true;
            this.statusToolStripMenuItem.CheckOnClick = true;
            this.statusToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFuctionsToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.toolBarToolStripMenuItem.Text = "Tool Bar";
            this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.toolBarToolStripMenuItem_Click);
            // 
            // fileFuctionsToolStripMenuItem
            // 
            this.fileFuctionsToolStripMenuItem.Checked = true;
            this.fileFuctionsToolStripMenuItem.CheckOnClick = true;
            this.fileFuctionsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fileFuctionsToolStripMenuItem.Name = "fileFuctionsToolStripMenuItem";
            this.fileFuctionsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.fileFuctionsToolStripMenuItem.Text = "File Fuctions";
            this.fileFuctionsToolStripMenuItem.Click += new System.EventHandler(this.fileFuctionsToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Checked = true;
            this.zoomToolStripMenuItem.CheckOnClick = true;
            this.zoomToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Checked = true;
            this.colorToolStripMenuItem.CheckOnClick = true;
            this.colorToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(135, 6);
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem});
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.backgroundToolStripMenuItem.Text = "Background";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.scrollControl);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 47);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(890, 449);
            this.panelMain.TabIndex = 5;
            // 
            // scrollControl
            // 
            this.scrollControl.AutoScroll = true;
            this.scrollControl.Controls.Add(this.Preview);
            this.scrollControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollControl.Location = new System.Drawing.Point(0, 0);
            this.scrollControl.Name = "scrollControl";
            this.scrollControl.Size = new System.Drawing.Size(890, 449);
            this.scrollControl.TabIndex = 1;
            this.scrollControl.Text = "scrollableControl1";
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.stripStatus);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 496);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(890, 23);
            this.panelStatus.TabIndex = 6;
            // 
            // stripStatus
            // 
            this.stripStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stripStatus.AutoSize = false;
            this.stripStatus.BackColor = System.Drawing.Color.Transparent;
            this.stripStatus.Dock = System.Windows.Forms.DockStyle.None;
            this.stripStatus.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.stripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barProgress,
            this.lblReady,
            this.lblPosY,
            this.lblPosSep,
            this.lblPosX,
            this.lblPos});
            this.stripStatus.Location = new System.Drawing.Point(0, 1);
            this.stripStatus.Name = "stripStatus";
            this.stripStatus.Size = new System.Drawing.Size(892, 24);
            this.stripStatus.TabIndex = 0;
            this.stripStatus.Text = "toolStrip3";
            this.stripStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.stripBars_MouseDown);
            // 
            // barProgress
            // 
            this.barProgress.AutoSize = false;
            this.barProgress.Name = "barProgress";
            this.barProgress.Size = new System.Drawing.Size(100, 15);
            // 
            // lblReady
            // 
            this.lblReady.AutoSize = false;
            this.lblReady.Name = "lblReady";
            this.lblReady.Size = new System.Drawing.Size(250, 21);
            this.lblReady.Text = "Ready...";
            this.lblReady.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPosY
            // 
            this.lblPosY.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblPosY.Name = "lblPosY";
            this.lblPosY.Size = new System.Drawing.Size(13, 21);
            this.lblPosY.Text = "0";
            this.lblPosY.ToolTipText = "Y Position";
            // 
            // lblPosSep
            // 
            this.lblPosSep.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblPosSep.Name = "lblPosSep";
            this.lblPosSep.Size = new System.Drawing.Size(10, 21);
            this.lblPosSep.Text = ",";
            this.lblPosSep.ToolTipText = "Position relative to the image";
            // 
            // lblPosX
            // 
            this.lblPosX.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblPosX.Name = "lblPosX";
            this.lblPosX.Size = new System.Drawing.Size(13, 21);
            this.lblPosX.Text = "0";
            this.lblPosX.ToolTipText = "X Position";
            // 
            // Preview
            // 
            this.Preview.BackColor = System.Drawing.Color.Transparent;
            this.Preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Preview.Location = new System.Drawing.Point(0, 0);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(0, 0);
            this.Preview.TabIndex = 0;
            this.Preview.TabStop = false;
            this.Preview.MouseCaptureChanged += new System.EventHandler(this.Preview_MouseCaptureChanged);
            this.Preview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Preview_MouseDown);
            this.Preview.MouseEnter += new System.EventHandler(this.Preview_MouseEnter);
            this.Preview.MouseLeave += new System.EventHandler(this.Preview_MouseLeave);
            this.Preview.MouseHover += new System.EventHandler(this.Preview_MouseHover);
            this.Preview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Preview_MouseMove);
            this.Preview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Preview_MouseUp);
            // 
            // btnToolOpen
            // 
            this.btnToolOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToolOpen.Image = global::VisualBounds.Imaging.PaintBucket.Properties.Resources.folder_explore;
            this.btnToolOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolOpen.Name = "btnToolOpen";
            this.btnToolOpen.Size = new System.Drawing.Size(23, 22);
            this.btnToolOpen.Text = "Open";
            this.btnToolOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnToolSave
            // 
            this.btnToolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToolSave.Enabled = false;
            this.btnToolSave.Image = global::VisualBounds.Imaging.PaintBucket.Properties.Resources.disk;
            this.btnToolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolSave.Name = "btnToolSave";
            this.btnToolSave.Size = new System.Drawing.Size(23, 22);
            this.btnToolSave.Text = "Save";
            this.btnToolSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnImageScale
            // 
            this.btnImageScale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnImageScale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.btnImageScale.Image = ((System.Drawing.Image)(resources.GetObject("btnImageScale.Image")));
            this.btnImageScale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImageScale.Name = "btnImageScale";
            this.btnImageScale.Size = new System.Drawing.Size(51, 22);
            this.btnImageScale.Text = "100%";
            this.btnImageScale.ToolTipText = "Image Scale";
            this.btnImageScale.ButtonClick += new System.EventHandler(this.btnImageScale_ButtonClick);
            this.btnImageScale.MouseEnter += new System.EventHandler(this.btnImageScale_MouseEnter);
            this.btnImageScale.MouseLeave += new System.EventHandler(this.btnImageScale_MouseLeave);
            this.btnImageScale.TextChanged += new System.EventHandler(this.btnImageScale_TextChanged);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem2.Text = "25%";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem3.Text = "50%";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem4.Text = "100%";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem5.Text = "150%";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem6.Text = "200%";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem7.Text = "300%";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem8.Text = "500%";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // btnImageSplitter
            // 
            this.btnImageSplitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImageSplitter.Enabled = false;
            this.btnImageSplitter.Image = global::VisualBounds.Imaging.PaintBucket.Properties.Resources._1337544610_insert_image;
            this.btnImageSplitter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImageSplitter.Name = "btnImageSplitter";
            this.btnImageSplitter.Size = new System.Drawing.Size(23, 22);
            this.btnImageSplitter.Text = "Image Splitter";
            this.btnImageSplitter.Click += new System.EventHandler(this.btnImageSplitter_Click);
            // 
            // btnColourRemover
            // 
            this.btnColourRemover.CheckOnClick = true;
            this.btnColourRemover.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnColourRemover.Enabled = false;
            this.btnColourRemover.Image = global::VisualBounds.Imaging.PaintBucket.Properties.Resources.emblem_pictures;
            this.btnColourRemover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnColourRemover.Name = "btnColourRemover";
            this.btnColourRemover.Size = new System.Drawing.Size(23, 22);
            this.btnColourRemover.Text = "Colour Remover";
            this.btnColourRemover.Click += new System.EventHandler(this.btnColourRemover_Click);
            // 
            // btnFile
            // 
            this.btnFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnSave,
            this.toolStripSeparator1,
            this.btnExit});
            this.btnFile.Image = ((System.Drawing.Image)(resources.GetObject("btnFile.Image")));
            this.btnFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(38, 22);
            this.btnFile.Text = "File";
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::VisualBounds.Imaging.PaintBucket.Properties.Resources.folder_explore;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(103, 22);
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::VisualBounds.Imaging.PaintBucket.Properties.Resources.disk;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 22);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::VisualBounds.Imaging.PaintBucket.Properties.Resources.door_open;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPos
            // 
            this.lblPos.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblPos.Image = global::VisualBounds.Imaging.PaintBucket.Properties.Resources.chart_empty;
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(16, 21);
            this.lblPos.ToolTipText = "Position relative to the image";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 519);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.panelStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Paint Bucket";
            this.Activated += new System.EventHandler(this.FrmMain_Activated);
            this.Deactivate += new System.EventHandler(this.FrmMain_Deactivate);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.stripTools.ResumeLayout(false);
            this.stripTools.PerformLayout();
            this.stripMenu.ResumeLayout(false);
            this.stripMenu.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.scrollControl.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.stripStatus.ResumeLayout(false);
            this.stripStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ImageList Icons;
        private System.Windows.Forms.ImageList ribbonIcons;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.ToolStrip stripTools;
        private System.Windows.Forms.ToolStripButton btnToolOpen;
        private System.Windows.Forms.ToolStripButton btnToolSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ScrollableControl scrollControl;
        private System.Windows.Forms.PictureBox Preview;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStrip stripMenu;
        private System.Windows.Forms.ToolStripDropDownButton btnFile;
        private System.Windows.Forms.ToolStripMenuItem btnOpen;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.ToolStrip stripStatus;
        private System.Windows.Forms.ToolStripProgressBar barProgress;
        private System.Windows.Forms.ToolStripLabel lblReady;
        private System.Windows.Forms.ToolStripLabel lblPosition;
        private System.Windows.Forms.ToolStripLabel lblPosY;
        private System.Windows.Forms.ToolStripLabel lblPosSep;
        private System.Windows.Forms.ToolStripLabel lblPosX;
        private System.Windows.Forms.ToolStripLabel lblPos;
        private System.Windows.Forms.ToolStripSplitButton btnImageScale;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel btnColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton btnView;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileFuctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnImageSplitter;
        private System.Windows.Forms.ToolStripButton btnColourRemover;



    }
}

