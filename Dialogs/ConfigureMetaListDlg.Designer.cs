namespace MobiMetadataReader.Net.Dialogs
{
    partial class ConfigureMetaListDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigureMetaListDlg));
            this.labelMaxWidth = new System.Windows.Forms.Label();
            this.textBoxMaxWidth = new System.Windows.Forms.TextBox();
            this.labelHelp = new System.Windows.Forms.Label();
            this.buttonDown = new System.Windows.Forms.Button();
            this.imageListButtons = new System.Windows.Forms.ImageList(this.components);
            this.buttonUp = new System.Windows.Forms.Button();
            this.labelChosen = new System.Windows.Forms.Label();
            this.listBoxChosenColumns = new System.Windows.Forms.ListBox();
            this.listBoxEXTHHeader = new System.Windows.Forms.ListBox();
            this.listBoxMobiHeader = new System.Windows.Forms.ListBox();
            this.listBoxPalmDOCHeader = new System.Windows.Forms.ListBox();
            this.listBoxPDBHeader = new System.Windows.Forms.ListBox();
            this.labelEXTHHeader = new System.Windows.Forms.Label();
            this.labelMobiHeader = new System.Windows.Forms.Label();
            this.labelPalmDocHeader = new System.Windows.Forms.Label();
            this.labelPDBHeader = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.listBoxSystem = new System.Windows.Forms.ListBox();
            this.labelSystem = new System.Windows.Forms.Label();
            this.checkBoxAutosize = new System.Windows.Forms.CheckBox();
            this.labelMetadataColumns = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMaxWidth
            // 
            this.labelMaxWidth.AutoSize = true;
            this.labelMaxWidth.Location = new System.Drawing.Point(741, 15);
            this.labelMaxWidth.Name = "labelMaxWidth";
            this.labelMaxWidth.Size = new System.Drawing.Size(76, 13);
            this.labelMaxWidth.TabIndex = 41;
            this.labelMaxWidth.Text = "Max Col Width";
            // 
            // textBoxMaxWidth
            // 
            this.textBoxMaxWidth.Location = new System.Drawing.Point(823, 12);
            this.textBoxMaxWidth.Name = "textBoxMaxWidth";
            this.textBoxMaxWidth.Size = new System.Drawing.Size(49, 21);
            this.textBoxMaxWidth.TabIndex = 40;
            this.textBoxMaxWidth.Text = "350";
            this.textBoxMaxWidth.Leave += new System.EventHandler(this.textBoxMaxWidth_Leave);
            // 
            // labelHelp
            // 
            this.labelHelp.AutoSize = true;
            this.labelHelp.Location = new System.Drawing.Point(12, 9);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(405, 13);
            this.labelHelp.TabIndex = 39;
            this.labelHelp.Text = "Double-click the fields on the columns S. to M. below to choose columns for the g" +
                "rid";
            // 
            // buttonDown
            // 
            this.buttonDown.ImageIndex = 4;
            this.buttonDown.ImageList = this.imageListButtons;
            this.buttonDown.Location = new System.Drawing.Point(844, 62);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(28, 28);
            this.buttonDown.TabIndex = 38;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // imageListButtons
            // 
            this.imageListButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButtons.ImageStream")));
            this.imageListButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButtons.Images.SetKeyName(0, "accept.png");
            this.imageListButtons.Images.SetKeyName(1, "block.png");
            this.imageListButtons.Images.SetKeyName(2, "delete.png");
            this.imageListButtons.Images.SetKeyName(3, "up.png");
            this.imageListButtons.Images.SetKeyName(4, "down.png");
            // 
            // buttonUp
            // 
            this.buttonUp.ImageIndex = 3;
            this.buttonUp.ImageList = this.imageListButtons;
            this.buttonUp.Location = new System.Drawing.Point(813, 62);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(28, 28);
            this.buttonUp.TabIndex = 37;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // labelChosen
            // 
            this.labelChosen.AutoSize = true;
            this.labelChosen.Location = new System.Drawing.Point(741, 72);
            this.labelChosen.Name = "labelChosen";
            this.labelChosen.Size = new System.Drawing.Size(43, 13);
            this.labelChosen.TabIndex = 36;
            this.labelChosen.Text = "Chosen";
            // 
            // listBoxChosenColumns
            // 
            this.listBoxChosenColumns.FormattingEnabled = true;
            this.listBoxChosenColumns.Location = new System.Drawing.Point(744, 88);
            this.listBoxChosenColumns.Name = "listBoxChosenColumns";
            this.listBoxChosenColumns.Size = new System.Drawing.Size(128, 264);
            this.listBoxChosenColumns.TabIndex = 35;
            this.listBoxChosenColumns.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxChosenColumns_MouseDoubleClick);
            // 
            // listBoxEXTHHeader
            // 
            this.listBoxEXTHHeader.FormattingEnabled = true;
            this.listBoxEXTHHeader.Location = new System.Drawing.Point(176, 88);
            this.listBoxEXTHHeader.Name = "listBoxEXTHHeader";
            this.listBoxEXTHHeader.Size = new System.Drawing.Size(128, 264);
            this.listBoxEXTHHeader.Sorted = true;
            this.listBoxEXTHHeader.TabIndex = 34;
            this.listBoxEXTHHeader.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxEXTHHeader_MouseDoubleClick);
            // 
            // listBoxMobiHeader
            // 
            this.listBoxMobiHeader.FormattingEnabled = true;
            this.listBoxMobiHeader.Location = new System.Drawing.Point(576, 88);
            this.listBoxMobiHeader.Name = "listBoxMobiHeader";
            this.listBoxMobiHeader.Size = new System.Drawing.Size(128, 264);
            this.listBoxMobiHeader.Sorted = true;
            this.listBoxMobiHeader.TabIndex = 33;
            this.listBoxMobiHeader.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxMobiHeader_MouseDoubleClick);
            // 
            // listBoxPalmDOCHeader
            // 
            this.listBoxPalmDOCHeader.FormattingEnabled = true;
            this.listBoxPalmDOCHeader.Location = new System.Drawing.Point(442, 88);
            this.listBoxPalmDOCHeader.Name = "listBoxPalmDOCHeader";
            this.listBoxPalmDOCHeader.Size = new System.Drawing.Size(128, 264);
            this.listBoxPalmDOCHeader.Sorted = true;
            this.listBoxPalmDOCHeader.TabIndex = 32;
            this.listBoxPalmDOCHeader.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxPalmDOCHeader_MouseDoubleClick);
            // 
            // listBoxPDBHeader
            // 
            this.listBoxPDBHeader.FormattingEnabled = true;
            this.listBoxPDBHeader.Location = new System.Drawing.Point(308, 88);
            this.listBoxPDBHeader.Name = "listBoxPDBHeader";
            this.listBoxPDBHeader.Size = new System.Drawing.Size(128, 264);
            this.listBoxPDBHeader.Sorted = true;
            this.listBoxPDBHeader.TabIndex = 31;
            this.listBoxPDBHeader.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxPDBHeader_MouseDoubleClick);
            // 
            // labelEXTHHeader
            // 
            this.labelEXTHHeader.AutoSize = true;
            this.labelEXTHHeader.Location = new System.Drawing.Point(173, 70);
            this.labelEXTHHeader.Name = "labelEXTHHeader";
            this.labelEXTHHeader.Size = new System.Drawing.Size(91, 13);
            this.labelEXTHHeader.TabIndex = 30;
            this.labelEXTHHeader.Text = "EXTH Header (E.)";
            // 
            // labelMobiHeader
            // 
            this.labelMobiHeader.AutoSize = true;
            this.labelMobiHeader.Location = new System.Drawing.Point(573, 70);
            this.labelMobiHeader.Name = "labelMobiHeader";
            this.labelMobiHeader.Size = new System.Drawing.Size(90, 13);
            this.labelMobiHeader.TabIndex = 29;
            this.labelMobiHeader.Text = "Mobi Header (M.)";
            // 
            // labelPalmDocHeader
            // 
            this.labelPalmDocHeader.AutoSize = true;
            this.labelPalmDocHeader.Location = new System.Drawing.Point(439, 70);
            this.labelPalmDocHeader.Name = "labelPalmDocHeader";
            this.labelPalmDocHeader.Size = new System.Drawing.Size(108, 13);
            this.labelPalmDocHeader.TabIndex = 28;
            this.labelPalmDocHeader.Text = "PalmDOCHeader (D.)";
            // 
            // labelPDBHeader
            // 
            this.labelPDBHeader.AutoSize = true;
            this.labelPDBHeader.Location = new System.Drawing.Point(305, 70);
            this.labelPDBHeader.Name = "labelPDBHeader";
            this.labelPDBHeader.Size = new System.Drawing.Size(85, 13);
            this.labelPDBHeader.TabIndex = 27;
            this.labelPDBHeader.Text = "PDB Header (P.)";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOK.ImageKey = "accept.png";
            this.buttonOK.ImageList = this.imageListButtons;
            this.buttonOK.Location = new System.Drawing.Point(785, 383);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(87, 32);
            this.buttonOK.TabIndex = 42;
            this.buttonOK.Text = "        OK";
            this.buttonOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.ImageKey = "block.png";
            this.buttonCancel.ImageList = this.imageListButtons;
            this.buttonCancel.Location = new System.Drawing.Point(15, 383);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 32);
            this.buttonCancel.TabIndex = 43;
            this.buttonCancel.Text = "        Cancel";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // listBoxSystem
            // 
            this.listBoxSystem.FormattingEnabled = true;
            this.listBoxSystem.Location = new System.Drawing.Point(12, 88);
            this.listBoxSystem.Name = "listBoxSystem";
            this.listBoxSystem.Size = new System.Drawing.Size(128, 264);
            this.listBoxSystem.Sorted = true;
            this.listBoxSystem.TabIndex = 45;
            this.listBoxSystem.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxSystem_MouseDoubleClick);
            // 
            // labelSystem
            // 
            this.labelSystem.AutoSize = true;
            this.labelSystem.Location = new System.Drawing.Point(9, 70);
            this.labelSystem.Name = "labelSystem";
            this.labelSystem.Size = new System.Drawing.Size(63, 13);
            this.labelSystem.TabIndex = 44;
            this.labelSystem.Text = "System (S.)";
            // 
            // checkBoxAutosize
            // 
            this.checkBoxAutosize.AutoSize = true;
            this.checkBoxAutosize.Location = new System.Drawing.Point(625, 14);
            this.checkBoxAutosize.Name = "checkBoxAutosize";
            this.checkBoxAutosize.Size = new System.Drawing.Size(110, 17);
            this.checkBoxAutosize.TabIndex = 46;
            this.checkBoxAutosize.Text = "Autosize Columns";
            this.checkBoxAutosize.UseVisualStyleBackColor = true;
            this.checkBoxAutosize.CheckedChanged += new System.EventHandler(this.checkBoxAutosize_CheckedChanged);
            // 
            // labelMetadataColumns
            // 
            this.labelMetadataColumns.Location = new System.Drawing.Point(173, 50);
            this.labelMetadataColumns.Name = "labelMetadataColumns";
            this.labelMetadataColumns.Size = new System.Drawing.Size(540, 18);
            this.labelMetadataColumns.TabIndex = 47;
            this.labelMetadataColumns.Text = "...................................................... Metadata Columns ........." +
                ".............................................";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Double-click the fields on the Chosen column to remove chosen fields";
            // 
            // ConfigureMetaListDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMetadataColumns);
            this.Controls.Add(this.checkBoxAutosize);
            this.Controls.Add(this.listBoxSystem);
            this.Controls.Add(this.labelSystem);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelMaxWidth);
            this.Controls.Add(this.textBoxMaxWidth);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.labelChosen);
            this.Controls.Add(this.listBoxChosenColumns);
            this.Controls.Add(this.listBoxEXTHHeader);
            this.Controls.Add(this.listBoxMobiHeader);
            this.Controls.Add(this.listBoxPalmDOCHeader);
            this.Controls.Add(this.listBoxPDBHeader);
            this.Controls.Add(this.labelEXTHHeader);
            this.Controls.Add(this.labelMobiHeader);
            this.Controls.Add(this.labelPalmDocHeader);
            this.Controls.Add(this.labelPDBHeader);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigureMetaListDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configure columns and settings";
            this.Load += new System.EventHandler(this.ConfigureMetaListDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMaxWidth;
        private System.Windows.Forms.TextBox textBoxMaxWidth;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Label labelChosen;
        private System.Windows.Forms.ListBox listBoxChosenColumns;
        private System.Windows.Forms.ListBox listBoxEXTHHeader;
        private System.Windows.Forms.ListBox listBoxMobiHeader;
        private System.Windows.Forms.ListBox listBoxPalmDOCHeader;
        private System.Windows.Forms.ListBox listBoxPDBHeader;
        private System.Windows.Forms.Label labelEXTHHeader;
        private System.Windows.Forms.Label labelMobiHeader;
        private System.Windows.Forms.Label labelPalmDocHeader;
        private System.Windows.Forms.Label labelPDBHeader;
        private System.Windows.Forms.ImageList imageListButtons;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ListBox listBoxSystem;
        private System.Windows.Forms.Label labelSystem;
        private System.Windows.Forms.CheckBox checkBoxAutosize;
        private System.Windows.Forms.Label labelMetadataColumns;
        private System.Windows.Forms.Label label1;
    }
}