namespace RasterGridImageEditorDemo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoAllChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageViewerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageViewer1 = new Vintasoft.Imaging.UI.ImageViewer();
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageLoadingProgressBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageLoadingProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.imagesEncodingProgressBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.imagesEncodingProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.labelImageInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveImageFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.imageViewerToolstrip1 = new DemosCommonCode.Imaging.ImageViewerToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imageRendererInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.usedCacheSizeValueLabel = new System.Windows.Forms.Label();
            this.cacheSizeValueLabel = new System.Windows.Forms.Label();
            this.usedCacheSizeLabel = new System.Windows.Forms.Label();
            this.cacheSizeLabel = new System.Windows.Forms.Label();
            this.rasterGridVisualToolInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.cellIndexValueLabel = new System.Windows.Forms.Label();
            this.cellHeightValueLabel = new System.Windows.Forms.Label();
            this.cellWidthValueLabel = new System.Windows.Forms.Label();
            this.gridEditorAvailableValueLabel = new System.Windows.Forms.Label();
            this.cellCountValueLabel = new System.Windows.Forms.Label();
            this.enableRasterGridVisualToolCheckBox = new System.Windows.Forms.CheckBox();
            this.gridEditorInstructionsTextBox = new System.Windows.Forms.TextBox();
            this.cellIndexLabel = new System.Windows.Forms.Label();
            this.cellCountLabel = new System.Windows.Forms.Label();
            this.cellHeightLabel = new System.Windows.Forms.Label();
            this.cellWidthLabel = new System.Windows.Forms.Label();
            this.gridEditorAvailableLabel = new System.Windows.Forms.Label();
            this.imageInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.decoderValueLabel = new System.Windows.Forms.Label();
            this.resolutionValueLabel = new System.Windows.Forms.Label();
            this.pixelFormatValueLabel = new System.Windows.Forms.Label();
            this.sizeValueLabel = new System.Windows.Forms.Label();
            this.heightValueLabel = new System.Windows.Forms.Label();
            this.widthValueLabel = new System.Windows.Forms.Label();
            this.decoderLabel = new System.Windows.Forms.Label();
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.pixelFormatLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.imageRendererInfoGroupBox.SuspendLayout();
            this.rasterGridVisualToolInfoGroupBox.SuspendLayout();
            this.imageInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(868, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveChangesToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.createToolStripMenuItem.Text = "Create...";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
            // 
            // saveChangesToolStripMenuItem
            // 
            this.saveChangesToolStripMenuItem.Name = "saveChangesToolStripMenuItem";
            this.saveChangesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveChangesToolStripMenuItem.Text = "Save changes";
            this.saveChangesToolStripMenuItem.Click += new System.EventHandler(this.saveChangesToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(152, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoAllChangesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoAllChangesToolStripMenuItem
            // 
            this.undoAllChangesToolStripMenuItem.Name = "undoAllChangesToolStripMenuItem";
            this.undoAllChangesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.undoAllChangesToolStripMenuItem.Text = "Undo All Changes";
            this.undoAllChangesToolStripMenuItem.Click += new System.EventHandler(this.undoAllChangesToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageViewerSettingsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // imageViewerSettingsToolStripMenuItem
            // 
            this.imageViewerSettingsToolStripMenuItem.Name = "imageViewerSettingsToolStripMenuItem";
            this.imageViewerSettingsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.imageViewerSettingsToolStripMenuItem.Text = "Image Viewer Settings...";
            this.imageViewerSettingsToolStripMenuItem.Click += new System.EventHandler(this.imageViewerSettingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // imageViewer1
            // 
            this.imageViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageViewer1.Location = new System.Drawing.Point(0, 0);
            this.imageViewer1.Name = "imageViewer1";
            this.imageViewer1.RendererCacheSize = 256F;
            this.imageViewer1.ShortcutCopy = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.ShortcutCut = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.ShortcutDelete = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.ShortcutInsert = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.ShortcutSelectAll = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.Size = new System.Drawing.Size(639, 584);
            this.imageViewer1.TabIndex = 0;
            this.imageViewer1.Text = "imageViewer1";
            this.imageViewer1.ImageLoadingProgress += new System.EventHandler<Vintasoft.Imaging.ProgressEventArgs>(this.imageViewer1_ImageLoadingProgress);
            this.imageViewer1.FocusedIndexChanged += new System.EventHandler<Vintasoft.Imaging.UI.FocusedIndexChangedEventArgs>(this.imageViewer1_FocusedIndexChanged);
            // 
            // openImageFileDialog
            // 
            this.openImageFileDialog.Filter = "TIFF files|*.tif;*tiff;*.btf|JPEG2000 files|*.jp2;*j2k;*jpc;*.j2c";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressStatus,
            this.imageLoadingProgressBarLabel,
            this.imageLoadingProgressBar,
            this.imagesEncodingProgressBarLabel,
            this.imagesEncodingProgressBar,
            this.labelImageInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 633);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(868, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressStatus
            // 
            this.toolStripProgressStatus.Name = "toolStripProgressStatus";
            this.toolStripProgressStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // imageLoadingProgressBarLabel
            // 
            this.imageLoadingProgressBarLabel.Name = "imageLoadingProgressBarLabel";
            this.imageLoadingProgressBarLabel.Size = new System.Drawing.Size(85, 17);
            this.imageLoadingProgressBarLabel.Text = "Loading page: ";
            this.imageLoadingProgressBarLabel.Visible = false;
            // 
            // imageLoadingProgressBar
            // 
            this.imageLoadingProgressBar.Name = "imageLoadingProgressBar";
            this.imageLoadingProgressBar.Size = new System.Drawing.Size(100, 16);
            this.imageLoadingProgressBar.Visible = false;
            // 
            // imagesEncodingProgressBarLabel
            // 
            this.imagesEncodingProgressBarLabel.Name = "imagesEncodingProgressBarLabel";
            this.imagesEncodingProgressBarLabel.Size = new System.Drawing.Size(101, 17);
            this.imagesEncodingProgressBarLabel.Text = "Encoding images:";
            this.imagesEncodingProgressBarLabel.Visible = false;
            // 
            // imagesEncodingProgressBar
            // 
            this.imagesEncodingProgressBar.Name = "imagesEncodingProgressBar";
            this.imagesEncodingProgressBar.Size = new System.Drawing.Size(100, 16);
            this.imagesEncodingProgressBar.Visible = false;
            // 
            // labelImageInfo
            // 
            this.labelImageInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.labelImageInfo.Name = "labelImageInfo";
            this.labelImageInfo.Size = new System.Drawing.Size(853, 17);
            this.labelImageInfo.Spring = true;
            this.labelImageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // saveImageFileDialog
            // 
            this.saveImageFileDialog.DefaultExt = "tif";
            // 
            // imageViewerToolstrip1
            // 
            this.imageViewerToolstrip1.AssociatedZoomTrackBar = null;
            this.imageViewerToolstrip1.CanPrint = false;
            this.imageViewerToolstrip1.ImageViewer = this.imageViewer1;
            this.imageViewerToolstrip1.ScanButtonEnabled = true;
            this.imageViewerToolstrip1.Location = new System.Drawing.Point(0, 24);
            this.imageViewerToolstrip1.Name = "imageViewerToolstrip1";
            this.imageViewerToolstrip1.PageCount = 0;
            this.imageViewerToolstrip1.PrintButtonEnabled = true;
            this.imageViewerToolstrip1.SaveButtonEnabled = true;
            this.imageViewerToolstrip1.Size = new System.Drawing.Size(868, 25);
            this.imageViewerToolstrip1.TabIndex = 2;
            this.imageViewerToolstrip1.Text = "imageViewerToolstrip1";
            this.imageViewerToolstrip1.UseImageViewerImages = true;
            this.imageViewerToolstrip1.OpenFile += new System.EventHandler(this.openToolStripMenuItem_Click);
            this.imageViewerToolstrip1.SaveFile += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.imageViewer1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.imageRendererInfoGroupBox);
            this.splitContainer1.Panel2.Controls.Add(this.rasterGridVisualToolInfoGroupBox);
            this.splitContainer1.Panel2.Controls.Add(this.imageInfoGroupBox);
            this.splitContainer1.Size = new System.Drawing.Size(868, 584);
            this.splitContainer1.SplitterDistance = 639;
            this.splitContainer1.TabIndex = 5;
            // 
            // imageRendererInfoGroupBox
            // 
            this.imageRendererInfoGroupBox.Controls.Add(this.usedCacheSizeValueLabel);
            this.imageRendererInfoGroupBox.Controls.Add(this.cacheSizeValueLabel);
            this.imageRendererInfoGroupBox.Controls.Add(this.usedCacheSizeLabel);
            this.imageRendererInfoGroupBox.Controls.Add(this.cacheSizeLabel);
            this.imageRendererInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageRendererInfoGroupBox.Enabled = false;
            this.imageRendererInfoGroupBox.Location = new System.Drawing.Point(0, 364);
            this.imageRendererInfoGroupBox.Name = "imageRendererInfoGroupBox";
            this.imageRendererInfoGroupBox.Size = new System.Drawing.Size(225, 73);
            this.imageRendererInfoGroupBox.TabIndex = 2;
            this.imageRendererInfoGroupBox.TabStop = false;
            this.imageRendererInfoGroupBox.Text = "Image Renderer Info";
            // 
            // usedCacheSizeValueLabel
            // 
            this.usedCacheSizeValueLabel.AutoSize = true;
            this.usedCacheSizeValueLabel.Location = new System.Drawing.Point(109, 43);
            this.usedCacheSizeValueLabel.Name = "usedCacheSizeValueLabel";
            this.usedCacheSizeValueLabel.Size = new System.Drawing.Size(0, 13);
            this.usedCacheSizeValueLabel.TabIndex = 5;
            // 
            // cacheSizeValueLabel
            // 
            this.cacheSizeValueLabel.AutoSize = true;
            this.cacheSizeValueLabel.Location = new System.Drawing.Point(109, 22);
            this.cacheSizeValueLabel.Name = "cacheSizeValueLabel";
            this.cacheSizeValueLabel.Size = new System.Drawing.Size(0, 13);
            this.cacheSizeValueLabel.TabIndex = 4;
            // 
            // usedCacheSizeLabel
            // 
            this.usedCacheSizeLabel.AutoSize = true;
            this.usedCacheSizeLabel.Location = new System.Drawing.Point(11, 43);
            this.usedCacheSizeLabel.Name = "usedCacheSizeLabel";
            this.usedCacheSizeLabel.Size = new System.Drawing.Size(92, 13);
            this.usedCacheSizeLabel.TabIndex = 3;
            this.usedCacheSizeLabel.Text = "Used Cache Size:";
            // 
            // cacheSizeLabel
            // 
            this.cacheSizeLabel.AutoSize = true;
            this.cacheSizeLabel.Location = new System.Drawing.Point(39, 22);
            this.cacheSizeLabel.Name = "cacheSizeLabel";
            this.cacheSizeLabel.Size = new System.Drawing.Size(64, 13);
            this.cacheSizeLabel.TabIndex = 2;
            this.cacheSizeLabel.Text = "Cache Size:";
            // 
            // rasterGridVisualToolInfoGroupBox
            // 
            this.rasterGridVisualToolInfoGroupBox.Controls.Add(this.cellIndexValueLabel);
            this.rasterGridVisualToolInfoGroupBox.Controls.Add(this.cellHeightValueLabel);
            this.rasterGridVisualToolInfoGroupBox.Controls.Add(this.cellWidthValueLabel);
            this.rasterGridVisualToolInfoGroupBox.Controls.Add(this.gridEditorAvailableValueLabel);
            this.rasterGridVisualToolInfoGroupBox.Controls.Add(this.cellCountValueLabel);
            this.rasterGridVisualToolInfoGroupBox.Controls.Add(this.enableRasterGridVisualToolCheckBox);
            this.rasterGridVisualToolInfoGroupBox.Controls.Add(this.gridEditorInstructionsTextBox);
            this.rasterGridVisualToolInfoGroupBox.Controls.Add(this.cellIndexLabel);
            this.rasterGridVisualToolInfoGroupBox.Controls.Add(this.cellCountLabel);
            this.rasterGridVisualToolInfoGroupBox.Controls.Add(this.cellHeightLabel);
            this.rasterGridVisualToolInfoGroupBox.Controls.Add(this.cellWidthLabel);
            this.rasterGridVisualToolInfoGroupBox.Controls.Add(this.gridEditorAvailableLabel);
            this.rasterGridVisualToolInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.rasterGridVisualToolInfoGroupBox.Enabled = false;
            this.rasterGridVisualToolInfoGroupBox.Location = new System.Drawing.Point(0, 156);
            this.rasterGridVisualToolInfoGroupBox.Name = "rasterGridVisualToolInfoGroupBox";
            this.rasterGridVisualToolInfoGroupBox.Size = new System.Drawing.Size(225, 208);
            this.rasterGridVisualToolInfoGroupBox.TabIndex = 1;
            this.rasterGridVisualToolInfoGroupBox.TabStop = false;
            this.rasterGridVisualToolInfoGroupBox.Text = "Raster Grid Visual Tool Info";
            // 
            // cellIndexValueLabel
            // 
            this.cellIndexValueLabel.AutoSize = true;
            this.cellIndexValueLabel.Location = new System.Drawing.Point(90, 137);
            this.cellIndexValueLabel.Name = "cellIndexValueLabel";
            this.cellIndexValueLabel.Size = new System.Drawing.Size(0, 13);
            this.cellIndexValueLabel.TabIndex = 11;
            // 
            // cellHeightValueLabel
            // 
            this.cellHeightValueLabel.AutoSize = true;
            this.cellHeightValueLabel.Location = new System.Drawing.Point(90, 115);
            this.cellHeightValueLabel.Name = "cellHeightValueLabel";
            this.cellHeightValueLabel.Size = new System.Drawing.Size(0, 13);
            this.cellHeightValueLabel.TabIndex = 10;
            // 
            // cellWidthValueLabel
            // 
            this.cellWidthValueLabel.AutoSize = true;
            this.cellWidthValueLabel.Location = new System.Drawing.Point(90, 93);
            this.cellWidthValueLabel.Name = "cellWidthValueLabel";
            this.cellWidthValueLabel.Size = new System.Drawing.Size(0, 13);
            this.cellWidthValueLabel.TabIndex = 9;
            // 
            // gridEditorAvailableValueLabel
            // 
            this.gridEditorAvailableValueLabel.AutoSize = true;
            this.gridEditorAvailableValueLabel.Location = new System.Drawing.Point(120, 49);
            this.gridEditorAvailableValueLabel.Name = "gridEditorAvailableValueLabel";
            this.gridEditorAvailableValueLabel.Size = new System.Drawing.Size(0, 13);
            this.gridEditorAvailableValueLabel.TabIndex = 8;
            // 
            // cellCountValueLabel
            // 
            this.cellCountValueLabel.AutoSize = true;
            this.cellCountValueLabel.Location = new System.Drawing.Point(90, 71);
            this.cellCountValueLabel.Name = "cellCountValueLabel";
            this.cellCountValueLabel.Size = new System.Drawing.Size(0, 13);
            this.cellCountValueLabel.TabIndex = 7;
            // 
            // enableRasterGridVisualToolCheckBox
            // 
            this.enableRasterGridVisualToolCheckBox.AutoSize = true;
            this.enableRasterGridVisualToolCheckBox.Checked = true;
            this.enableRasterGridVisualToolCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableRasterGridVisualToolCheckBox.Location = new System.Drawing.Point(12, 21);
            this.enableRasterGridVisualToolCheckBox.Name = "enableRasterGridVisualToolCheckBox";
            this.enableRasterGridVisualToolCheckBox.Size = new System.Drawing.Size(114, 17);
            this.enableRasterGridVisualToolCheckBox.TabIndex = 6;
            this.enableRasterGridVisualToolCheckBox.Text = "Enable Visual Tool";
            this.enableRasterGridVisualToolCheckBox.UseVisualStyleBackColor = true;
            this.enableRasterGridVisualToolCheckBox.CheckedChanged += new System.EventHandler(this.enableRasterGridVisualToolCheckBox_CheckedChanged);
            // 
            // gridEditorInstructionsTextBox
            // 
            this.gridEditorInstructionsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridEditorInstructionsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridEditorInstructionsTextBox.Location = new System.Drawing.Point(12, 163);
            this.gridEditorInstructionsTextBox.Multiline = true;
            this.gridEditorInstructionsTextBox.Name = "gridEditorInstructionsTextBox";
            this.gridEditorInstructionsTextBox.ReadOnly = true;
            this.gridEditorInstructionsTextBox.Size = new System.Drawing.Size(201, 32);
            this.gridEditorInstructionsTextBox.TabIndex = 5;
            this.gridEditorInstructionsTextBox.Text = "Press right mouse button on cell for changing cell image";
            this.gridEditorInstructionsTextBox.Visible = false;
            // 
            // cellIndexLabel
            // 
            this.cellIndexLabel.AutoSize = true;
            this.cellIndexLabel.Location = new System.Drawing.Point(26, 137);
            this.cellIndexLabel.Name = "cellIndexLabel";
            this.cellIndexLabel.Size = new System.Drawing.Size(56, 13);
            this.cellIndexLabel.TabIndex = 4;
            this.cellIndexLabel.Text = "Cell Index:";
            // 
            // cellCountLabel
            // 
            this.cellCountLabel.AutoSize = true;
            this.cellCountLabel.Location = new System.Drawing.Point(26, 71);
            this.cellCountLabel.Name = "cellCountLabel";
            this.cellCountLabel.Size = new System.Drawing.Size(58, 13);
            this.cellCountLabel.TabIndex = 3;
            this.cellCountLabel.Text = "Cell Count:";
            // 
            // cellHeightLabel
            // 
            this.cellHeightLabel.AutoSize = true;
            this.cellHeightLabel.Location = new System.Drawing.Point(22, 115);
            this.cellHeightLabel.Name = "cellHeightLabel";
            this.cellHeightLabel.Size = new System.Drawing.Size(61, 13);
            this.cellHeightLabel.TabIndex = 2;
            this.cellHeightLabel.Text = "Cell Height:";
            // 
            // cellWidthLabel
            // 
            this.cellWidthLabel.AutoSize = true;
            this.cellWidthLabel.Location = new System.Drawing.Point(25, 93);
            this.cellWidthLabel.Name = "cellWidthLabel";
            this.cellWidthLabel.Size = new System.Drawing.Size(58, 13);
            this.cellWidthLabel.TabIndex = 1;
            this.cellWidthLabel.Text = "Cell Width:";
            // 
            // gridEditorAvailableLabel
            // 
            this.gridEditorAvailableLabel.AutoSize = true;
            this.gridEditorAvailableLabel.Location = new System.Drawing.Point(9, 49);
            this.gridEditorAvailableLabel.Name = "gridEditorAvailableLabel";
            this.gridEditorAvailableLabel.Size = new System.Drawing.Size(105, 13);
            this.gridEditorAvailableLabel.TabIndex = 0;
            this.gridEditorAvailableLabel.Text = "Grid Editor Available:";
            // 
            // imageInfoGroupBox
            // 
            this.imageInfoGroupBox.Controls.Add(this.decoderValueLabel);
            this.imageInfoGroupBox.Controls.Add(this.resolutionValueLabel);
            this.imageInfoGroupBox.Controls.Add(this.pixelFormatValueLabel);
            this.imageInfoGroupBox.Controls.Add(this.sizeValueLabel);
            this.imageInfoGroupBox.Controls.Add(this.heightValueLabel);
            this.imageInfoGroupBox.Controls.Add(this.widthValueLabel);
            this.imageInfoGroupBox.Controls.Add(this.decoderLabel);
            this.imageInfoGroupBox.Controls.Add(this.resolutionLabel);
            this.imageInfoGroupBox.Controls.Add(this.pixelFormatLabel);
            this.imageInfoGroupBox.Controls.Add(this.sizeLabel);
            this.imageInfoGroupBox.Controls.Add(this.heightLabel);
            this.imageInfoGroupBox.Controls.Add(this.widthLabel);
            this.imageInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageInfoGroupBox.Enabled = false;
            this.imageInfoGroupBox.Location = new System.Drawing.Point(0, 0);
            this.imageInfoGroupBox.Name = "imageInfoGroupBox";
            this.imageInfoGroupBox.Size = new System.Drawing.Size(225, 156);
            this.imageInfoGroupBox.TabIndex = 0;
            this.imageInfoGroupBox.TabStop = false;
            this.imageInfoGroupBox.Text = "Image Info";
            // 
            // decoderValueLabel
            // 
            this.decoderValueLabel.AutoSize = true;
            this.decoderValueLabel.Location = new System.Drawing.Point(90, 131);
            this.decoderValueLabel.Name = "decoderValueLabel";
            this.decoderValueLabel.Size = new System.Drawing.Size(0, 13);
            this.decoderValueLabel.TabIndex = 11;
            // 
            // resolutionValueLabel
            // 
            this.resolutionValueLabel.AutoSize = true;
            this.resolutionValueLabel.Location = new System.Drawing.Point(90, 109);
            this.resolutionValueLabel.Name = "resolutionValueLabel";
            this.resolutionValueLabel.Size = new System.Drawing.Size(0, 13);
            this.resolutionValueLabel.TabIndex = 10;
            // 
            // pixelFormatValueLabel
            // 
            this.pixelFormatValueLabel.AutoSize = true;
            this.pixelFormatValueLabel.Location = new System.Drawing.Point(90, 87);
            this.pixelFormatValueLabel.Name = "pixelFormatValueLabel";
            this.pixelFormatValueLabel.Size = new System.Drawing.Size(0, 13);
            this.pixelFormatValueLabel.TabIndex = 9;
            // 
            // sizeValueLabel
            // 
            this.sizeValueLabel.AutoSize = true;
            this.sizeValueLabel.Location = new System.Drawing.Point(90, 65);
            this.sizeValueLabel.Name = "sizeValueLabel";
            this.sizeValueLabel.Size = new System.Drawing.Size(0, 13);
            this.sizeValueLabel.TabIndex = 8;
            // 
            // heightValueLabel
            // 
            this.heightValueLabel.AutoSize = true;
            this.heightValueLabel.Location = new System.Drawing.Point(90, 43);
            this.heightValueLabel.Name = "heightValueLabel";
            this.heightValueLabel.Size = new System.Drawing.Size(0, 13);
            this.heightValueLabel.TabIndex = 7;
            // 
            // widthValueLabel
            // 
            this.widthValueLabel.AutoSize = true;
            this.widthValueLabel.Location = new System.Drawing.Point(90, 21);
            this.widthValueLabel.Name = "widthValueLabel";
            this.widthValueLabel.Size = new System.Drawing.Size(0, 13);
            this.widthValueLabel.TabIndex = 6;
            // 
            // decoderLabel
            // 
            this.decoderLabel.AutoSize = true;
            this.decoderLabel.Location = new System.Drawing.Point(33, 131);
            this.decoderLabel.Name = "decoderLabel";
            this.decoderLabel.Size = new System.Drawing.Size(51, 13);
            this.decoderLabel.TabIndex = 5;
            this.decoderLabel.Text = "Decoder:";
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.Location = new System.Drawing.Point(24, 109);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(60, 13);
            this.resolutionLabel.TabIndex = 4;
            this.resolutionLabel.Text = "Resolution:";
            // 
            // pixelFormatLabel
            // 
            this.pixelFormatLabel.AutoSize = true;
            this.pixelFormatLabel.Location = new System.Drawing.Point(17, 87);
            this.pixelFormatLabel.Name = "pixelFormatLabel";
            this.pixelFormatLabel.Size = new System.Drawing.Size(67, 13);
            this.pixelFormatLabel.TabIndex = 3;
            this.pixelFormatLabel.Text = "Pixel Format:";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(54, 65);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(30, 13);
            this.sizeLabel.TabIndex = 2;
            this.sizeLabel.Text = "Size:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(43, 43);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(41, 13);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "Height:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(46, 21);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(38, 13);
            this.widthLabel.TabIndex = 0;
            this.widthLabel.Text = "Width:";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 655);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.imageViewerToolstrip1);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VintaSoft Raster Grid Image Editor Demo";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.imageRendererInfoGroupBox.ResumeLayout(false);
            this.imageRendererInfoGroupBox.PerformLayout();
            this.rasterGridVisualToolInfoGroupBox.ResumeLayout(false);
            this.rasterGridVisualToolInfoGroupBox.PerformLayout();
            this.imageInfoGroupBox.ResumeLayout(false);
            this.imageInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private DemosCommonCode.Imaging.ImageViewerToolStrip imageViewerToolstrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageViewerSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openImageFileDialog;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripProgressStatus;
        private System.Windows.Forms.ToolStripStatusLabel imageLoadingProgressBarLabel;
        private System.Windows.Forms.ToolStripProgressBar imageLoadingProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel imagesEncodingProgressBarLabel;
        private System.Windows.Forms.ToolStripProgressBar imagesEncodingProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel labelImageInfo;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private Vintasoft.Imaging.UI.ImageViewer imageViewer1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveChangesToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveImageFileDialog;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoAllChangesToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox imageInfoGroupBox;
        private System.Windows.Forms.GroupBox rasterGridVisualToolInfoGroupBox;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label resolutionLabel;
        private System.Windows.Forms.Label pixelFormatLabel;
        private System.Windows.Forms.Label decoderLabel;
        private System.Windows.Forms.Label cellHeightLabel;
        private System.Windows.Forms.Label cellWidthLabel;
        private System.Windows.Forms.Label gridEditorAvailableLabel;
        private System.Windows.Forms.Label cellCountLabel;
        private System.Windows.Forms.TextBox gridEditorInstructionsTextBox;
        private System.Windows.Forms.Label cellIndexLabel;
        private System.Windows.Forms.CheckBox enableRasterGridVisualToolCheckBox;
        private System.Windows.Forms.Label cellIndexValueLabel;
        private System.Windows.Forms.Label cellHeightValueLabel;
        private System.Windows.Forms.Label cellWidthValueLabel;
        private System.Windows.Forms.Label gridEditorAvailableValueLabel;
        private System.Windows.Forms.Label cellCountValueLabel;
        private System.Windows.Forms.GroupBox imageRendererInfoGroupBox;
        private System.Windows.Forms.Label usedCacheSizeValueLabel;
        private System.Windows.Forms.Label cacheSizeValueLabel;
        private System.Windows.Forms.Label usedCacheSizeLabel;
        private System.Windows.Forms.Label cacheSizeLabel;
        private System.Windows.Forms.Label decoderValueLabel;
        private System.Windows.Forms.Label resolutionValueLabel;
        private System.Windows.Forms.Label pixelFormatValueLabel;
        private System.Windows.Forms.Label sizeValueLabel;
        private System.Windows.Forms.Label heightValueLabel;
        private System.Windows.Forms.Label widthValueLabel;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}
