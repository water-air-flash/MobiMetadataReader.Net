namespace MobiMetadataReader.Net
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listViewItems = new System.Windows.Forms.ListView();
            this.cmdMetadataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfigure = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.explorerTree1 = new MobiMetadataReader.Net.Components.WindowsExplorer.ExplorerTree();
            this.labelHomeFolder = new System.Windows.Forms.Label();
            this.labelHomeLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsSetHome = new System.Windows.Forms.ToolStripButton();
            this.tsRestore = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAbout = new System.Windows.Forms.ToolStripButton();
            this.fileMenuButton = new System.Windows.Forms.ToolStripSplitButton();
            this.重命名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdMetadataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewItems
            // 
            this.listViewItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewItems.ContextMenuStrip = this.cmdMetadataGrid;
            this.listViewItems.FullRowSelect = true;
            this.listViewItems.HideSelection = false;
            this.listViewItems.Location = new System.Drawing.Point(3, 34);
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(647, 654);
            this.listViewItems.TabIndex = 1;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.View = System.Windows.Forms.View.Details;
            this.listViewItems.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewItems_ColumnClick);
            this.listViewItems.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.listViewItems_ColumnWidthChanged);
            this.listViewItems.SelectedIndexChanged += new System.EventHandler(this.listViewItems_SelectedIndexChanged);
            // 
            // cmdMetadataGrid
            // 
            this.cmdMetadataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmView,
            this.tsmConfigure});
            this.cmdMetadataGrid.Name = "cmdMetadataGrid";
            this.cmdMetadataGrid.Size = new System.Drawing.Size(295, 64);
            this.cmdMetadataGrid.Opened += new System.EventHandler(this.cmdMetadataGrid_Opened);
            this.cmdMetadataGrid.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmdMetadataGrid_ItemClicked);
            // 
            // tsmView
            // 
            this.tsmView.Image = ((System.Drawing.Image)(resources.GetObject("tsmView.Image")));
            this.tsmView.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmView.Name = "tsmView";
            this.tsmView.Size = new System.Drawing.Size(294, 30);
            this.tsmView.Text = "View complete metadata for this file";
            // 
            // tsmConfigure
            // 
            this.tsmConfigure.Image = ((System.Drawing.Image)(resources.GetObject("tsmConfigure.Image")));
            this.tsmConfigure.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmConfigure.Name = "tsmConfigure";
            this.tsmConfigure.Size = new System.Drawing.Size(294, 30);
            this.tsmConfigure.Text = "Configure columns and settings";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(1, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.explorerTree1);
            this.splitContainer1.Panel1.Controls.Add(this.labelHomeFolder);
            this.splitContainer1.Panel1.Controls.Add(this.labelHomeLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listViewItems);
            this.splitContainer1.Size = new System.Drawing.Size(985, 691);
            this.splitContainer1.SplitterDistance = 328;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // explorerTree1
            // 
            this.explorerTree1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.explorerTree1.BackColor = System.Drawing.Color.White;
            this.explorerTree1.Location = new System.Drawing.Point(3, 94);
            this.explorerTree1.Name = "explorerTree1";
            this.explorerTree1.SelectedPath = "C:\\Program Files (x86)\\Microsoft Visual Studio 11.0\\Common7\\IDE";
            this.explorerTree1.ShowAddressbar = true;
            this.explorerTree1.ShowMyDocuments = true;
            this.explorerTree1.ShowMyFavorites = true;
            this.explorerTree1.ShowMyNetwork = true;
            this.explorerTree1.ShowToolbar = true;
            this.explorerTree1.Size = new System.Drawing.Size(322, 594);
            this.explorerTree1.TabIndex = 0;
            this.explorerTree1.PathChanged += new MobiMetadataReader.Net.Components.WindowsExplorer.ExplorerTree.PathChangedEventHandler(this.explorerTree1_PathChanged);
            this.explorerTree1.ButtonClicked += new MobiMetadataReader.Net.Components.WindowsExplorer.ExplorerTree.ButtonClickedHandler(this.explorerTree1_ButtonClicked);
            // 
            // labelHomeFolder
            // 
            this.labelHomeFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHomeFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelHomeFolder.Location = new System.Drawing.Point(3, 51);
            this.labelHomeFolder.Name = "labelHomeFolder";
            this.labelHomeFolder.Size = new System.Drawing.Size(322, 46);
            this.labelHomeFolder.TabIndex = 5;
            this.labelHomeFolder.Text = "labelHomeFolder";
            // 
            // labelHomeLabel
            // 
            this.labelHomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHomeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelHomeLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomeLabel.Location = new System.Drawing.Point(3, 31);
            this.labelHomeLabel.Name = "labelHomeLabel";
            this.labelHomeLabel.Size = new System.Drawing.Size(322, 20);
            this.labelHomeLabel.TabIndex = 4;
            this.labelHomeLabel.Text = "Home folder:";
            this.labelHomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSetHome,
            this.tsRestore,
            this.toolStripSeparator1,
            this.tsAbout,
            this.fileMenuButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 31);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsSetHome
            // 
            this.tsSetHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSetHome.Image = ((System.Drawing.Image)(resources.GetObject("tsSetHome.Image")));
            this.tsSetHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsSetHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSetHome.Name = "tsSetHome";
            this.tsSetHome.Size = new System.Drawing.Size(28, 28);
            this.tsSetHome.Text = "Set current folder as home folder";
            this.tsSetHome.Click += new System.EventHandler(this.tsSetHome_Click);
            // 
            // tsRestore
            // 
            this.tsRestore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRestore.Image = ((System.Drawing.Image)(resources.GetObject("tsRestore.Image")));
            this.tsRestore.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsRestore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRestore.Name = "tsRestore";
            this.tsRestore.Size = new System.Drawing.Size(28, 28);
            this.tsRestore.Text = "Restore default settings";
            this.tsRestore.Click += new System.EventHandler(this.tsRestore_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsAbout
            // 
            this.tsAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsAbout.Image")));
            this.tsAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAbout.Name = "tsAbout";
            this.tsAbout.Size = new System.Drawing.Size(28, 28);
            this.tsAbout.Text = "About Mobi Metadata Reader .Net";
            this.tsAbout.Click += new System.EventHandler(this.tsAbout_Click);
            // 
            // fileMenuButton
            // 
            this.fileMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重命名ToolStripMenuItem});
            this.fileMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("fileMenuButton.Image")));
            this.fileMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileMenuButton.Name = "fileMenuButton";
            this.fileMenuButton.Size = new System.Drawing.Size(48, 28);
            this.fileMenuButton.Text = "文件";
            // 
            // 重命名ToolStripMenuItem
            // 
            this.重命名ToolStripMenuItem.Name = "重命名ToolStripMenuItem";
            this.重命名ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.重命名ToolStripMenuItem.Text = "重命名";
            this.重命名ToolStripMenuItem.Click += new System.EventHandler(this.重命名ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 692);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobi Metadata Reader .Net";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmdMetadataGrid.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.WindowsExplorer.ExplorerTree explorerTree1;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ContextMenuStrip cmdMetadataGrid;
        private System.Windows.Forms.ToolStripMenuItem tsmView;
        private System.Windows.Forms.ToolStripMenuItem tsmConfigure;
        private System.Windows.Forms.Label labelHomeFolder;
        private System.Windows.Forms.Label labelHomeLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsSetHome;
        private System.Windows.Forms.ToolStripButton tsRestore;
        private System.Windows.Forms.ToolStripButton tsAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton fileMenuButton;
        private System.Windows.Forms.ToolStripMenuItem 重命名ToolStripMenuItem;
    }
}

