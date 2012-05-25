namespace VisualBounds.Imaging.PaintBucket
{
    partial class FRM_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Main));
            this.DIALOG_Color = new System.Windows.Forms.ColorDialog();
            this.DIALOG_Folder = new System.Windows.Forms.FolderBrowserDialog();
            this.DIALOG_Font = new System.Windows.Forms.FontDialog();
            this.DIALOG_Open = new System.Windows.Forms.OpenFileDialog();
            this.DIALOG_Save = new System.Windows.Forms.SaveFileDialog();
            this.PANEL_Header = new System.Windows.Forms.Panel();
            this.PANEL_Header_Hidder_2 = new System.Windows.Forms.Panel();
            this.STRIP_Tools = new System.Windows.Forms.ToolStrip();
            this.BTN_Tools_ColorRemover = new System.Windows.Forms.ToolStripButton();
            this.STRIP_Settings = new System.Windows.Forms.ToolStrip();
            this.BTN_Settings_Open = new System.Windows.Forms.ToolStripButton();
            this.BTN_Settings_Save = new System.Windows.Forms.ToolStripButton();
            this.SEPARATOR_Settings_1 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_Settings_Zoom = new System.Windows.Forms.ToolStripSplitButton();
            this.BTN_Settings_Zoom_25 = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Settings_Zoom_50 = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Settings_Zoom_100 = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Settings_Zoom_150 = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Settings_Zoom_200 = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Settings_Zoom_300 = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Settings_Zoom_500 = new System.Windows.Forms.ToolStripMenuItem();
            this.SEPARATOR_Settings_2 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_Settings_Color = new System.Windows.Forms.ToolStripLabel();
            this.SEPARATOR_Settings_3 = new System.Windows.Forms.ToolStripSeparator();
            this.PANEL_Header_Hidder_1 = new System.Windows.Forms.Panel();
            this.STRIP_Menu = new System.Windows.Forms.ToolStrip();
            this.BTN_Menu_File = new System.Windows.Forms.ToolStripDropDownButton();
            this.BTN_Menu_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Menu_File_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_Menu_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Menu_View = new System.Windows.Forms.ToolStripDropDownButton();
            this.BTN_Menu_View_Background = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Menu_View_Background_Default = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Menu_Image = new System.Windows.Forms.ToolStripDropDownButton();
            this.BTN_Menu_Image_Resize = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Menu_Image_Crop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_Menu_Image_Transform = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Menu_Image_Transform_Negative = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Menu_Image_Transform_Grayscale = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Menu_Image_Transform_ColorTransform = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Menu_Utilities = new System.Windows.Forms.ToolStripDropDownButton();
            this.BTN_Menu_Utilities_ImageSplitter = new System.Windows.Forms.ToolStripMenuItem();
            this.PANEL_Status = new System.Windows.Forms.Panel();
            this.STRIP_Status = new System.Windows.Forms.ToolStrip();
            this.PROGRESS_Status_bar = new System.Windows.Forms.ToolStripProgressBar();
            this.LBL_Status_Info = new System.Windows.Forms.ToolStripLabel();
            this.LBL_Status_Position_Y = new System.Windows.Forms.ToolStripLabel();
            this.LBL_Status_Position_Separator = new System.Windows.Forms.ToolStripLabel();
            this.LBL_Status_Position_X = new System.Windows.Forms.ToolStripLabel();
            this.LBL_Status_Position_Image = new System.Windows.Forms.ToolStripLabel();
            this.PANEL_Main = new System.Windows.Forms.Panel();
            this.PANEL_Main_Scroll = new System.Windows.Forms.ScrollableControl();
            this.PREVIEW = new System.Windows.Forms.PictureBox();
            this.PANEL_Header.SuspendLayout();
            this.STRIP_Tools.SuspendLayout();
            this.STRIP_Settings.SuspendLayout();
            this.STRIP_Menu.SuspendLayout();
            this.PANEL_Status.SuspendLayout();
            this.STRIP_Status.SuspendLayout();
            this.PANEL_Main.SuspendLayout();
            this.PANEL_Main_Scroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PREVIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // DIALOG_Color
            // 
            this.DIALOG_Color.AnyColor = true;
            this.DIALOG_Color.FullOpen = true;
            this.DIALOG_Color.ShowHelp = true;
            // 
            // DIALOG_Folder
            // 
            this.DIALOG_Folder.Description = "Selection location to save splitted images to.";
            // 
            // DIALOG_Open
            // 
            this.DIALOG_Open.Filter = "All Images|*.bmp;*.gif;*.jpeg;*.jpg;*.png;*.tiff|Bitmap|*.bmp|Graphical Interchan" +
    "ge Format|*.gif|JPEG|*.jpeg;*.jpg|Portable Network Graphic|*.png|Tagged Image Fi" +
    "le Format|*.tiff";
            this.DIALOG_Open.Title = "Paint Bucket - Open Image";
            // 
            // DIALOG_Save
            // 
            this.DIALOG_Save.Filter = resources.GetString("DIALOG_Save.Filter");
            this.DIALOG_Save.Title = "Paint Bucket - Save Image";
            // 
            // PANEL_Header
            // 
            this.PANEL_Header.Controls.Add(this.PANEL_Header_Hidder_2);
            this.PANEL_Header.Controls.Add(this.STRIP_Tools);
            this.PANEL_Header.Controls.Add(this.STRIP_Settings);
            this.PANEL_Header.Controls.Add(this.PANEL_Header_Hidder_1);
            this.PANEL_Header.Controls.Add(this.STRIP_Menu);
            this.PANEL_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_Header.Location = new System.Drawing.Point(0, 0);
            this.PANEL_Header.Name = "PANEL_Header";
            this.PANEL_Header.Size = new System.Drawing.Size(890, 72);
            this.PANEL_Header.TabIndex = 4;
            // 
            // PANEL_Header_Hidder_2
            // 
            this.PANEL_Header_Hidder_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PANEL_Header_Hidder_2.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_Header_Hidder_2.Location = new System.Drawing.Point(0, 68);
            this.PANEL_Header_Hidder_2.Name = "PANEL_Header_Hidder_2";
            this.PANEL_Header_Hidder_2.Size = new System.Drawing.Size(891, 10);
            this.PANEL_Header_Hidder_2.TabIndex = 11;
            // 
            // STRIP_Tools
            // 
            this.STRIP_Tools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.STRIP_Tools.AutoSize = false;
            this.STRIP_Tools.BackColor = System.Drawing.Color.Transparent;
            this.STRIP_Tools.Dock = System.Windows.Forms.DockStyle.None;
            this.STRIP_Tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.STRIP_Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_Tools_ColorRemover});
            this.STRIP_Tools.Location = new System.Drawing.Point(0, 45);
            this.STRIP_Tools.Name = "STRIP_Tools";
            this.STRIP_Tools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.STRIP_Tools.Size = new System.Drawing.Size(892, 25);
            this.STRIP_Tools.TabIndex = 13;
            this.STRIP_Tools.Text = "toolStrip1";
            this.STRIP_Tools.MouseDown += new System.Windows.Forms.MouseEventHandler(this.STRIP_MouseDown);
            // 
            // BTN_Tools_ColorRemover
            // 
            this.BTN_Tools_ColorRemover.CheckOnClick = true;
            this.BTN_Tools_ColorRemover.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTN_Tools_ColorRemover.Enabled = false;
            this.BTN_Tools_ColorRemover.Image = global::VisualBounds.Imaging.PaintBucket.Properties.Resources.emblem_pictures;
            this.BTN_Tools_ColorRemover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_Tools_ColorRemover.Name = "BTN_Tools_ColorRemover";
            this.BTN_Tools_ColorRemover.Size = new System.Drawing.Size(23, 24);
            this.BTN_Tools_ColorRemover.Text = "Colour Remover";
            // 
            // STRIP_Settings
            // 
            this.STRIP_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.STRIP_Settings.AutoSize = false;
            this.STRIP_Settings.BackColor = System.Drawing.Color.Transparent;
            this.STRIP_Settings.Dock = System.Windows.Forms.DockStyle.None;
            this.STRIP_Settings.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.STRIP_Settings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_Settings_Open,
            this.BTN_Settings_Save,
            this.SEPARATOR_Settings_1,
            this.BTN_Settings_Zoom,
            this.SEPARATOR_Settings_2,
            this.BTN_Settings_Color,
            this.SEPARATOR_Settings_3});
            this.STRIP_Settings.Location = new System.Drawing.Point(2, 22);
            this.STRIP_Settings.Name = "STRIP_Settings";
            this.STRIP_Settings.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.STRIP_Settings.Size = new System.Drawing.Size(889, 25);
            this.STRIP_Settings.TabIndex = 9;
            this.STRIP_Settings.Text = "toolStrip1";
            this.STRIP_Settings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.STRIP_MouseDown);
            // 
            // BTN_Settings_Open
            // 
            this.BTN_Settings_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTN_Settings_Open.Image = global::VisualBounds.Imaging.PaintBucket.Properties.Resources.folder_explore;
            this.BTN_Settings_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_Settings_Open.Name = "BTN_Settings_Open";
            this.BTN_Settings_Open.Size = new System.Drawing.Size(23, 24);
            this.BTN_Settings_Open.Text = "Open";
            this.BTN_Settings_Open.Click += new System.EventHandler(this.BTN_Menu_File_Open_Click);
            // 
            // BTN_Settings_Save
            // 
            this.BTN_Settings_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTN_Settings_Save.Enabled = false;
            this.BTN_Settings_Save.Image = global::VisualBounds.Imaging.PaintBucket.Properties.Resources.disk;
            this.BTN_Settings_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_Settings_Save.Name = "BTN_Settings_Save";
            this.BTN_Settings_Save.Size = new System.Drawing.Size(23, 24);
            this.BTN_Settings_Save.Text = "Save";
            this.BTN_Settings_Save.Click += new System.EventHandler(this.BTN_Menu_File_Save_Click);
            // 
            // SEPARATOR_Settings_1
            // 
            this.SEPARATOR_Settings_1.Name = "SEPARATOR_Settings_1";
            this.SEPARATOR_Settings_1.Size = new System.Drawing.Size(6, 27);
            // 
            // BTN_Settings_Zoom
            // 
            this.BTN_Settings_Zoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BTN_Settings_Zoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_Settings_Zoom_25,
            this.BTN_Settings_Zoom_50,
            this.BTN_Settings_Zoom_100,
            this.BTN_Settings_Zoom_150,
            this.BTN_Settings_Zoom_200,
            this.BTN_Settings_Zoom_300,
            this.BTN_Settings_Zoom_500});
            this.BTN_Settings_Zoom.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Settings_Zoom.Image")));
            this.BTN_Settings_Zoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_Settings_Zoom.Name = "BTN_Settings_Zoom";
            this.BTN_Settings_Zoom.Size = new System.Drawing.Size(51, 24);
            this.BTN_Settings_Zoom.Text = "100%";
            this.BTN_Settings_Zoom.ToolTipText = "Image Scale";
            this.BTN_Settings_Zoom.ButtonClick += new System.EventHandler(this.BTN_Settings_Zoom_ButtonClick);
            this.BTN_Settings_Zoom.MouseEnter += new System.EventHandler(this.BTN_Settings_Zoom_MouseEnter);
            this.BTN_Settings_Zoom.MouseLeave += new System.EventHandler(this.BTN_Settings_Zoom_MouseLeave);
            this.BTN_Settings_Zoom.TextChanged += new System.EventHandler(this.BTN_Settings_Zoom_TextChanged);
            // 
            // BTN_Settings_Zoom_25
            // 
            this.BTN_Settings_Zoom_25.Name = "BTN_Settings_Zoom_25";
            this.BTN_Settings_Zoom_25.Size = new System.Drawing.Size(102, 22);
            this.BTN_Settings_Zoom_25.Text = "25%";
            this.BTN_Settings_Zoom_25.Click += new System.EventHandler(this.BTN_Settings_Zoom_Percentage_Click);
            // 
            // BTN_Settings_Zoom_50
            // 
            this.BTN_Settings_Zoom_50.Name = "BTN_Settings_Zoom_50";
            this.BTN_Settings_Zoom_50.Size = new System.Drawing.Size(102, 22);
            this.BTN_Settings_Zoom_50.Text = "50%";
            this.BTN_Settings_Zoom_50.Click += new System.EventHandler(this.BTN_Settings_Zoom_Percentage_Click);
            // 
            // BTN_Settings_Zoom_100
            // 
            this.BTN_Settings_Zoom_100.Name = "BTN_Settings_Zoom_100";
            this.BTN_Settings_Zoom_100.Size = new System.Drawing.Size(102, 22);
            this.BTN_Settings_Zoom_100.Text = "100%";
            this.BTN_Settings_Zoom_100.Click += new System.EventHandler(this.BTN_Settings_Zoom_Percentage_Click);
            // 
            // BTN_Settings_Zoom_150
            // 
            this.BTN_Settings_Zoom_150.Name = "BTN_Settings_Zoom_150";
            this.BTN_Settings_Zoom_150.Size = new System.Drawing.Size(102, 22);
            this.BTN_Settings_Zoom_150.Text = "150%";
            this.BTN_Settings_Zoom_150.Click += new System.EventHandler(this.BTN_Settings_Zoom_Percentage_Click);
            // 
            // BTN_Settings_Zoom_200
            // 
            this.BTN_Settings_Zoom_200.Name = "BTN_Settings_Zoom_200";
            this.BTN_Settings_Zoom_200.Size = new System.Drawing.Size(102, 22);
            this.BTN_Settings_Zoom_200.Text = "200%";
            this.BTN_Settings_Zoom_200.Click += new System.EventHandler(this.BTN_Settings_Zoom_Percentage_Click);
            // 
            // BTN_Settings_Zoom_300
            // 
            this.BTN_Settings_Zoom_300.Name = "BTN_Settings_Zoom_300";
            this.BTN_Settings_Zoom_300.Size = new System.Drawing.Size(102, 22);
            this.BTN_Settings_Zoom_300.Text = "300%";
            this.BTN_Settings_Zoom_300.Click += new System.EventHandler(this.BTN_Settings_Zoom_Percentage_Click);
            // 
            // BTN_Settings_Zoom_500
            // 
            this.BTN_Settings_Zoom_500.Name = "BTN_Settings_Zoom_500";
            this.BTN_Settings_Zoom_500.Size = new System.Drawing.Size(102, 22);
            this.BTN_Settings_Zoom_500.Text = "500%";
            this.BTN_Settings_Zoom_500.Click += new System.EventHandler(this.BTN_Settings_Zoom_Percentage_Click);
            // 
            // SEPARATOR_Settings_2
            // 
            this.SEPARATOR_Settings_2.Name = "SEPARATOR_Settings_2";
            this.SEPARATOR_Settings_2.Size = new System.Drawing.Size(6, 27);
            // 
            // BTN_Settings_Color
            // 
            this.BTN_Settings_Color.AutoSize = false;
            this.BTN_Settings_Color.Name = "BTN_Settings_Color";
            this.BTN_Settings_Color.Size = new System.Drawing.Size(22, 22);
            this.BTN_Settings_Color.Click += new System.EventHandler(this.BTN_Settings_Color_Click);
            // 
            // SEPARATOR_Settings_3
            // 
            this.SEPARATOR_Settings_3.Name = "SEPARATOR_Settings_3";
            this.SEPARATOR_Settings_3.Size = new System.Drawing.Size(6, 25);
            this.SEPARATOR_Settings_3.Visible = false;
            // 
            // PANEL_Header_Hidder_1
            // 
            this.PANEL_Header_Hidder_1.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_Header_Hidder_1.Location = new System.Drawing.Point(-17, 22);
            this.PANEL_Header_Hidder_1.Name = "PANEL_Header_Hidder_1";
            this.PANEL_Header_Hidder_1.Size = new System.Drawing.Size(30, 21);
            this.PANEL_Header_Hidder_1.TabIndex = 10;
            // 
            // STRIP_Menu
            // 
            this.STRIP_Menu.BackColor = System.Drawing.Color.Transparent;
            this.STRIP_Menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.STRIP_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_Menu_File,
            this.BTN_Menu_View,
            this.BTN_Menu_Image,
            this.BTN_Menu_Utilities});
            this.STRIP_Menu.Location = new System.Drawing.Point(0, 0);
            this.STRIP_Menu.Name = "STRIP_Menu";
            this.STRIP_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.STRIP_Menu.Size = new System.Drawing.Size(890, 25);
            this.STRIP_Menu.TabIndex = 12;
            this.STRIP_Menu.Text = "toolStrip2";
            this.STRIP_Menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.STRIP_MouseDown);
            // 
            // BTN_Menu_File
            // 
            this.BTN_Menu_File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BTN_Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_Menu_File_Open,
            this.BTN_Menu_File_Save,
            this.toolStripSeparator1,
            this.BTN_Menu_File_Exit});
            this.BTN_Menu_File.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Menu_File.Image")));
            this.BTN_Menu_File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_Menu_File.Name = "BTN_Menu_File";
            this.BTN_Menu_File.Size = new System.Drawing.Size(38, 22);
            this.BTN_Menu_File.Text = "File";
            // 
            // BTN_Menu_File_Open
            // 
            this.BTN_Menu_File_Open.Image = global::VisualBounds.Imaging.PaintBucket.Properties.Resources.folder_explore;
            this.BTN_Menu_File_Open.Name = "BTN_Menu_File_Open";
            this.BTN_Menu_File_Open.Size = new System.Drawing.Size(152, 22);
            this.BTN_Menu_File_Open.Text = "Open";
            this.BTN_Menu_File_Open.Click += new System.EventHandler(this.BTN_Menu_File_Open_Click);
            // 
            // BTN_Menu_File_Save
            // 
            this.BTN_Menu_File_Save.Enabled = false;
            this.BTN_Menu_File_Save.Image = global::VisualBounds.Imaging.PaintBucket.Properties.Resources.disk;
            this.BTN_Menu_File_Save.Name = "BTN_Menu_File_Save";
            this.BTN_Menu_File_Save.Size = new System.Drawing.Size(152, 22);
            this.BTN_Menu_File_Save.Text = "Save";
            this.BTN_Menu_File_Save.Click += new System.EventHandler(this.BTN_Menu_File_Save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // BTN_Menu_File_Exit
            // 
            this.BTN_Menu_File_Exit.Image = global::VisualBounds.Imaging.PaintBucket.Properties.Resources.door_open;
            this.BTN_Menu_File_Exit.Name = "BTN_Menu_File_Exit";
            this.BTN_Menu_File_Exit.Size = new System.Drawing.Size(152, 22);
            this.BTN_Menu_File_Exit.Text = "Exit";
            this.BTN_Menu_File_Exit.Click += new System.EventHandler(this.BTN_Menu_File_Exit_Click);
            // 
            // BTN_Menu_View
            // 
            this.BTN_Menu_View.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BTN_Menu_View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_Menu_View_Background});
            this.BTN_Menu_View.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_Menu_View.Name = "BTN_Menu_View";
            this.BTN_Menu_View.Size = new System.Drawing.Size(45, 22);
            this.BTN_Menu_View.Text = "View";
            // 
            // BTN_Menu_View_Background
            // 
            this.BTN_Menu_View_Background.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_Menu_View_Background_Default});
            this.BTN_Menu_View_Background.Name = "BTN_Menu_View_Background";
            this.BTN_Menu_View_Background.Size = new System.Drawing.Size(152, 22);
            this.BTN_Menu_View_Background.Text = "Background";
            this.BTN_Menu_View_Background.Click += new System.EventHandler(this.BTN_Menu_View_Background_Click);
            // 
            // BTN_Menu_View_Background_Default
            // 
            this.BTN_Menu_View_Background_Default.Name = "BTN_Menu_View_Background_Default";
            this.BTN_Menu_View_Background_Default.Size = new System.Drawing.Size(152, 22);
            this.BTN_Menu_View_Background_Default.Text = "Default";
            this.BTN_Menu_View_Background_Default.Click += new System.EventHandler(this.BTN_Menu_View_Background_Default_Click);
            // 
            // BTN_Menu_Image
            // 
            this.BTN_Menu_Image.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BTN_Menu_Image.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_Menu_Image_Resize,
            this.BTN_Menu_Image_Crop,
            this.toolStripSeparator6,
            this.BTN_Menu_Image_Transform});
            this.BTN_Menu_Image.Enabled = false;
            this.BTN_Menu_Image.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Menu_Image.Image")));
            this.BTN_Menu_Image.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_Menu_Image.Name = "BTN_Menu_Image";
            this.BTN_Menu_Image.Size = new System.Drawing.Size(53, 22);
            this.BTN_Menu_Image.Text = "Image";
            // 
            // BTN_Menu_Image_Resize
            // 
            this.BTN_Menu_Image_Resize.Enabled = false;
            this.BTN_Menu_Image_Resize.Name = "BTN_Menu_Image_Resize";
            this.BTN_Menu_Image_Resize.Size = new System.Drawing.Size(152, 22);
            this.BTN_Menu_Image_Resize.Text = "Resize";
            // 
            // BTN_Menu_Image_Crop
            // 
            this.BTN_Menu_Image_Crop.Enabled = false;
            this.BTN_Menu_Image_Crop.Name = "BTN_Menu_Image_Crop";
            this.BTN_Menu_Image_Crop.Size = new System.Drawing.Size(152, 22);
            this.BTN_Menu_Image_Crop.Text = "Crop";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(149, 6);
            // 
            // BTN_Menu_Image_Transform
            // 
            this.BTN_Menu_Image_Transform.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_Menu_Image_Transform_Negative,
            this.BTN_Menu_Image_Transform_Grayscale,
            this.BTN_Menu_Image_Transform_ColorTransform});
            this.BTN_Menu_Image_Transform.Name = "BTN_Menu_Image_Transform";
            this.BTN_Menu_Image_Transform.Size = new System.Drawing.Size(152, 22);
            this.BTN_Menu_Image_Transform.Text = "Transform";
            // 
            // BTN_Menu_Image_Transform_Negative
            // 
            this.BTN_Menu_Image_Transform_Negative.Name = "BTN_Menu_Image_Transform_Negative";
            this.BTN_Menu_Image_Transform_Negative.Size = new System.Drawing.Size(161, 22);
            this.BTN_Menu_Image_Transform_Negative.Text = "Negative";
            this.BTN_Menu_Image_Transform_Negative.Click += new System.EventHandler(this.BTN_Menu_Image_Transform_Negative_Click);
            // 
            // BTN_Menu_Image_Transform_Grayscale
            // 
            this.BTN_Menu_Image_Transform_Grayscale.Name = "BTN_Menu_Image_Transform_Grayscale";
            this.BTN_Menu_Image_Transform_Grayscale.Size = new System.Drawing.Size(161, 22);
            this.BTN_Menu_Image_Transform_Grayscale.Text = "Grayscale";
            this.BTN_Menu_Image_Transform_Grayscale.Click += new System.EventHandler(this.BTN_Menu_Image_Transform_Grayscale_Click);
            // 
            // BTN_Menu_Image_Transform_ColorTransform
            // 
            this.BTN_Menu_Image_Transform_ColorTransform.Name = "BTN_Menu_Image_Transform_ColorTransform";
            this.BTN_Menu_Image_Transform_ColorTransform.Size = new System.Drawing.Size(161, 22);
            this.BTN_Menu_Image_Transform_ColorTransform.Text = "Color Transform";
            // 
            // BTN_Menu_Utilities
            // 
            this.BTN_Menu_Utilities.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BTN_Menu_Utilities.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_Menu_Utilities_ImageSplitter});
            this.BTN_Menu_Utilities.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_Menu_Utilities.Name = "BTN_Menu_Utilities";
            this.BTN_Menu_Utilities.Size = new System.Drawing.Size(59, 22);
            this.BTN_Menu_Utilities.Text = "Utilities";
            // 
            // BTN_Menu_Utilities_ImageSplitter
            // 
            this.BTN_Menu_Utilities_ImageSplitter.CheckOnClick = true;
            this.BTN_Menu_Utilities_ImageSplitter.Image = global::VisualBounds.Imaging.PaintBucket.Properties.Resources._1337544610_insert_image;
            this.BTN_Menu_Utilities_ImageSplitter.Name = "BTN_Menu_Utilities_ImageSplitter";
            this.BTN_Menu_Utilities_ImageSplitter.Size = new System.Drawing.Size(152, 22);
            this.BTN_Menu_Utilities_ImageSplitter.Text = "Image Splitter";
            // 
            // PANEL_Status
            // 
            this.PANEL_Status.Controls.Add(this.STRIP_Status);
            this.PANEL_Status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PANEL_Status.Location = new System.Drawing.Point(0, 496);
            this.PANEL_Status.Name = "PANEL_Status";
            this.PANEL_Status.Size = new System.Drawing.Size(890, 23);
            this.PANEL_Status.TabIndex = 6;
            // 
            // STRIP_Status
            // 
            this.STRIP_Status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.STRIP_Status.AutoSize = false;
            this.STRIP_Status.BackColor = System.Drawing.Color.Transparent;
            this.STRIP_Status.Dock = System.Windows.Forms.DockStyle.None;
            this.STRIP_Status.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.STRIP_Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PROGRESS_Status_bar,
            this.LBL_Status_Info,
            this.LBL_Status_Position_Y,
            this.LBL_Status_Position_Separator,
            this.LBL_Status_Position_X,
            this.LBL_Status_Position_Image});
            this.STRIP_Status.Location = new System.Drawing.Point(0, 1);
            this.STRIP_Status.Name = "STRIP_Status";
            this.STRIP_Status.Size = new System.Drawing.Size(892, 24);
            this.STRIP_Status.TabIndex = 0;
            this.STRIP_Status.Text = "toolStrip3";
            this.STRIP_Status.MouseDown += new System.Windows.Forms.MouseEventHandler(this.STRIP_MouseDown);
            // 
            // PROGRESS_Status_bar
            // 
            this.PROGRESS_Status_bar.AutoSize = false;
            this.PROGRESS_Status_bar.Name = "PROGRESS_Status_bar";
            this.PROGRESS_Status_bar.Size = new System.Drawing.Size(100, 16);
            // 
            // LBL_Status_Info
            // 
            this.LBL_Status_Info.AutoSize = false;
            this.LBL_Status_Info.Name = "LBL_Status_Info";
            this.LBL_Status_Info.Size = new System.Drawing.Size(250, 21);
            this.LBL_Status_Info.Text = "Ready...";
            this.LBL_Status_Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBL_Status_Position_Y
            // 
            this.LBL_Status_Position_Y.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LBL_Status_Position_Y.Name = "LBL_Status_Position_Y";
            this.LBL_Status_Position_Y.Size = new System.Drawing.Size(13, 21);
            this.LBL_Status_Position_Y.Text = "0";
            this.LBL_Status_Position_Y.ToolTipText = "Y Position";
            // 
            // LBL_Status_Position_Separator
            // 
            this.LBL_Status_Position_Separator.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LBL_Status_Position_Separator.Name = "LBL_Status_Position_Separator";
            this.LBL_Status_Position_Separator.Size = new System.Drawing.Size(10, 21);
            this.LBL_Status_Position_Separator.Text = ",";
            this.LBL_Status_Position_Separator.ToolTipText = "Position relative to the image";
            // 
            // LBL_Status_Position_X
            // 
            this.LBL_Status_Position_X.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LBL_Status_Position_X.Name = "LBL_Status_Position_X";
            this.LBL_Status_Position_X.Size = new System.Drawing.Size(13, 21);
            this.LBL_Status_Position_X.Text = "0";
            this.LBL_Status_Position_X.ToolTipText = "X Position";
            // 
            // LBL_Status_Position_Image
            // 
            this.LBL_Status_Position_Image.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LBL_Status_Position_Image.Image = global::VisualBounds.Imaging.PaintBucket.Properties.Resources.chart_empty;
            this.LBL_Status_Position_Image.Name = "LBL_Status_Position_Image";
            this.LBL_Status_Position_Image.Size = new System.Drawing.Size(16, 23);
            this.LBL_Status_Position_Image.ToolTipText = "Position relative to the image";
            // 
            // PANEL_Main
            // 
            this.PANEL_Main.Controls.Add(this.PANEL_Main_Scroll);
            this.PANEL_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_Main.Location = new System.Drawing.Point(0, 72);
            this.PANEL_Main.Name = "PANEL_Main";
            this.PANEL_Main.Size = new System.Drawing.Size(890, 424);
            this.PANEL_Main.TabIndex = 5;
            // 
            // PANEL_Main_Scroll
            // 
            this.PANEL_Main_Scroll.AutoScroll = true;
            this.PANEL_Main_Scroll.Controls.Add(this.PREVIEW);
            this.PANEL_Main_Scroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_Main_Scroll.Location = new System.Drawing.Point(0, 0);
            this.PANEL_Main_Scroll.Name = "PANEL_Main_Scroll";
            this.PANEL_Main_Scroll.Size = new System.Drawing.Size(890, 424);
            this.PANEL_Main_Scroll.TabIndex = 2;
            this.PANEL_Main_Scroll.Text = "scrollableControl1";
            // 
            // PREVIEW
            // 
            this.PREVIEW.BackColor = System.Drawing.Color.Transparent;
            this.PREVIEW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PREVIEW.Location = new System.Drawing.Point(0, 0);
            this.PREVIEW.Name = "PREVIEW";
            this.PREVIEW.Size = new System.Drawing.Size(0, 0);
            this.PREVIEW.TabIndex = 0;
            this.PREVIEW.TabStop = false;
            this.PREVIEW.MouseCaptureChanged += new System.EventHandler(this.PREVIEW_MouseCaptureChanged);
            this.PREVIEW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PREVIEW_MouseDown);
            this.PREVIEW.MouseEnter += new System.EventHandler(this.PREVIEW_MouseEnter);
            this.PREVIEW.MouseLeave += new System.EventHandler(this.PREVIEW_MouseLeave);
            this.PREVIEW.MouseHover += new System.EventHandler(this.PREVIEW_MouseHover);
            this.PREVIEW.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PREVIEW_MouseMove);
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 519);
            this.Controls.Add(this.PANEL_Main);
            this.Controls.Add(this.PANEL_Header);
            this.Controls.Add(this.PANEL_Status);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Main";
            this.Text = "Paint Bucket";
            this.Activated += new System.EventHandler(this.FRM_Main_Activated);
            this.Deactivate += new System.EventHandler(this.FRM_Main_Deactivate);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FRM_Main_Paint);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.PANEL_Header.ResumeLayout(false);
            this.PANEL_Header.PerformLayout();
            this.STRIP_Tools.ResumeLayout(false);
            this.STRIP_Tools.PerformLayout();
            this.STRIP_Settings.ResumeLayout(false);
            this.STRIP_Settings.PerformLayout();
            this.STRIP_Menu.ResumeLayout(false);
            this.STRIP_Menu.PerformLayout();
            this.PANEL_Status.ResumeLayout(false);
            this.STRIP_Status.ResumeLayout(false);
            this.STRIP_Status.PerformLayout();
            this.PANEL_Main.ResumeLayout(false);
            this.PANEL_Main_Scroll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PREVIEW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog DIALOG_Color;
        private System.Windows.Forms.FolderBrowserDialog DIALOG_Folder;
        private System.Windows.Forms.FontDialog DIALOG_Font;
        private System.Windows.Forms.OpenFileDialog DIALOG_Open;
        private System.Windows.Forms.SaveFileDialog DIALOG_Save;
        private System.Windows.Forms.Panel PANEL_Header;
        private System.Windows.Forms.ToolStrip STRIP_Settings;
        private System.Windows.Forms.ToolStripButton BTN_Settings_Open;
        private System.Windows.Forms.ToolStripButton BTN_Settings_Save;
        private System.Windows.Forms.ToolStripSeparator SEPARATOR_Settings_1;
        private System.Windows.Forms.Panel PANEL_Header_Hidder_1;
        private System.Windows.Forms.Panel PANEL_Header_Hidder_2;
        private System.Windows.Forms.ToolStrip STRIP_Menu;
        private System.Windows.Forms.ToolStripDropDownButton BTN_Menu_File;
        private System.Windows.Forms.ToolStripMenuItem BTN_Menu_File_Open;
        private System.Windows.Forms.ToolStripMenuItem BTN_Menu_File_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem BTN_Menu_File_Exit;
        private System.Windows.Forms.Panel PANEL_Status;
        private System.Windows.Forms.ToolStrip STRIP_Status;
        private System.Windows.Forms.ToolStripProgressBar PROGRESS_Status_bar;
        private System.Windows.Forms.ToolStripLabel LBL_Status_Info;
        private System.Windows.Forms.ToolStripLabel lblPosition;
        private System.Windows.Forms.ToolStripLabel LBL_Status_Position_Y;
        private System.Windows.Forms.ToolStripLabel LBL_Status_Position_Separator;
        private System.Windows.Forms.ToolStripLabel LBL_Status_Position_X;
        private System.Windows.Forms.ToolStripLabel LBL_Status_Position_Image;
        private System.Windows.Forms.ToolStripSplitButton BTN_Settings_Zoom;
        private System.Windows.Forms.ToolStripMenuItem BTN_Settings_Zoom_25;
        private System.Windows.Forms.ToolStripMenuItem BTN_Settings_Zoom_50;
        private System.Windows.Forms.ToolStripMenuItem BTN_Settings_Zoom_100;
        private System.Windows.Forms.ToolStripMenuItem BTN_Settings_Zoom_150;
        private System.Windows.Forms.ToolStripMenuItem BTN_Settings_Zoom_200;
        private System.Windows.Forms.ToolStripMenuItem BTN_Settings_Zoom_300;
        private System.Windows.Forms.ToolStripMenuItem BTN_Settings_Zoom_500;
        private System.Windows.Forms.ToolStripSeparator SEPARATOR_Settings_2;
        private System.Windows.Forms.ToolStripLabel BTN_Settings_Color;
        private System.Windows.Forms.ToolStripSeparator SEPARATOR_Settings_3;
        private System.Windows.Forms.ToolStripDropDownButton BTN_Menu_View;
        private System.Windows.Forms.ToolStripMenuItem BTN_Menu_View_Background;
        private System.Windows.Forms.ToolStripMenuItem BTN_Menu_View_Background_Default;
        private System.Windows.Forms.ToolStripDropDownButton BTN_Menu_Image;
        private System.Windows.Forms.ToolStripMenuItem BTN_Menu_Image_Resize;
        private System.Windows.Forms.ToolStripMenuItem BTN_Menu_Image_Crop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem BTN_Menu_Image_Transform;
        private System.Windows.Forms.ToolStripMenuItem BTN_Menu_Image_Transform_Negative;
        private System.Windows.Forms.ToolStripMenuItem BTN_Menu_Image_Transform_Grayscale;
        private System.Windows.Forms.ToolStripMenuItem BTN_Menu_Image_Transform_ColorTransform;
        private System.Windows.Forms.ToolStripDropDownButton BTN_Menu_Utilities;
        private System.Windows.Forms.ToolStripMenuItem BTN_Menu_Utilities_ImageSplitter;
        private System.Windows.Forms.ToolStrip STRIP_Tools;
        private System.Windows.Forms.Panel PANEL_Main;
        private System.Windows.Forms.ScrollableControl PANEL_Main_Scroll;
        private System.Windows.Forms.PictureBox PREVIEW;
        private System.Windows.Forms.ToolStripButton BTN_Tools_ColorRemover;



    }
}

