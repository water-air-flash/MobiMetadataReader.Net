namespace MobiMetadataReader.Net.Dialogs
{
    partial class ViewMetadataDlg
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
            this.imageListButtons = new System.Windows.Forms.ImageList(this.components);
            this.buttonOK = new System.Windows.Forms.Button();
            this.tabControlInd = new System.Windows.Forms.TabControl();
            this.tabPagePDBHead = new System.Windows.Forms.TabPage();
            this.dgPDBHead = new System.Windows.Forms.DataGridView();
            this.tabPagePalmDoc = new System.Windows.Forms.TabPage();
            this.dgPalmDOC = new System.Windows.Forms.DataGridView();
            this.tabPageMobiHead = new System.Windows.Forms.TabPage();
            this.dgMobiHead = new System.Windows.Forms.DataGridView();
            this.tabPageEXTHHead = new System.Windows.Forms.TabPage();
            this.dgEXTHHead = new System.Windows.Forms.DataGridView();
            this.tabPageText = new System.Windows.Forms.TabPage();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.tabControlInd.SuspendLayout();
            this.tabPagePDBHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPDBHead)).BeginInit();
            this.tabPagePalmDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPalmDOC)).BeginInit();
            this.tabPageMobiHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMobiHead)).BeginInit();
            this.tabPageEXTHHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEXTHHead)).BeginInit();
            this.tabPageText.SuspendLayout();
            this.SuspendLayout();
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
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOK.ImageKey = "accept.png";
            this.buttonOK.ImageList = this.imageListButtons;
            this.buttonOK.Location = new System.Drawing.Point(816, 330);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(87, 32);
            this.buttonOK.TabIndex = 42;
            this.buttonOK.Text = "        OK";
            this.buttonOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // tabControlInd
            // 
            this.tabControlInd.Controls.Add(this.tabPageEXTHHead);
            this.tabControlInd.Controls.Add(this.tabPagePDBHead);
            this.tabControlInd.Controls.Add(this.tabPagePalmDoc);
            this.tabControlInd.Controls.Add(this.tabPageMobiHead);
            this.tabControlInd.Controls.Add(this.tabPageText);
            this.tabControlInd.Location = new System.Drawing.Point(12, 12);
            this.tabControlInd.Name = "tabControlInd";
            this.tabControlInd.SelectedIndex = 0;
            this.tabControlInd.Size = new System.Drawing.Size(891, 312);
            this.tabControlInd.TabIndex = 43;
            // 
            // tabPagePDBHead
            // 
            this.tabPagePDBHead.Controls.Add(this.dgPDBHead);
            this.tabPagePDBHead.Location = new System.Drawing.Point(4, 22);
            this.tabPagePDBHead.Name = "tabPagePDBHead";
            this.tabPagePDBHead.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePDBHead.Size = new System.Drawing.Size(883, 286);
            this.tabPagePDBHead.TabIndex = 0;
            this.tabPagePDBHead.Text = "PDB Header";
            this.tabPagePDBHead.UseVisualStyleBackColor = true;
            // 
            // dgPDBHead
            // 
            this.dgPDBHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPDBHead.Location = new System.Drawing.Point(6, 6);
            this.dgPDBHead.Name = "dgPDBHead";
            this.dgPDBHead.Size = new System.Drawing.Size(871, 274);
            this.dgPDBHead.TabIndex = 11;
            // 
            // tabPagePalmDoc
            // 
            this.tabPagePalmDoc.Controls.Add(this.dgPalmDOC);
            this.tabPagePalmDoc.Location = new System.Drawing.Point(4, 22);
            this.tabPagePalmDoc.Name = "tabPagePalmDoc";
            this.tabPagePalmDoc.Size = new System.Drawing.Size(883, 286);
            this.tabPagePalmDoc.TabIndex = 4;
            this.tabPagePalmDoc.Text = "PalmDOC Header";
            this.tabPagePalmDoc.UseVisualStyleBackColor = true;
            // 
            // dgPalmDOC
            // 
            this.dgPalmDOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPalmDOC.Location = new System.Drawing.Point(6, 6);
            this.dgPalmDOC.Name = "dgPalmDOC";
            this.dgPalmDOC.Size = new System.Drawing.Size(874, 277);
            this.dgPalmDOC.TabIndex = 12;
            // 
            // tabPageMobiHead
            // 
            this.tabPageMobiHead.Controls.Add(this.dgMobiHead);
            this.tabPageMobiHead.Location = new System.Drawing.Point(4, 22);
            this.tabPageMobiHead.Name = "tabPageMobiHead";
            this.tabPageMobiHead.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMobiHead.Size = new System.Drawing.Size(883, 286);
            this.tabPageMobiHead.TabIndex = 1;
            this.tabPageMobiHead.Text = "Mobi Header";
            this.tabPageMobiHead.UseVisualStyleBackColor = true;
            // 
            // dgMobiHead
            // 
            this.dgMobiHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMobiHead.Location = new System.Drawing.Point(6, 6);
            this.dgMobiHead.Name = "dgMobiHead";
            this.dgMobiHead.Size = new System.Drawing.Size(871, 274);
            this.dgMobiHead.TabIndex = 10;
            // 
            // tabPageEXTHHead
            // 
            this.tabPageEXTHHead.Controls.Add(this.dgEXTHHead);
            this.tabPageEXTHHead.Location = new System.Drawing.Point(4, 22);
            this.tabPageEXTHHead.Name = "tabPageEXTHHead";
            this.tabPageEXTHHead.Size = new System.Drawing.Size(883, 286);
            this.tabPageEXTHHead.TabIndex = 2;
            this.tabPageEXTHHead.Text = "EXTH Header";
            this.tabPageEXTHHead.UseVisualStyleBackColor = true;
            // 
            // dgEXTHHead
            // 
            this.dgEXTHHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEXTHHead.Location = new System.Drawing.Point(6, 6);
            this.dgEXTHHead.Name = "dgEXTHHead";
            this.dgEXTHHead.Size = new System.Drawing.Size(874, 277);
            this.dgEXTHHead.TabIndex = 11;
            // 
            // tabPageText
            // 
            this.tabPageText.Controls.Add(this.textBoxOutput);
            this.tabPageText.Location = new System.Drawing.Point(4, 22);
            this.tabPageText.Name = "tabPageText";
            this.tabPageText.Size = new System.Drawing.Size(883, 286);
            this.tabPageText.TabIndex = 3;
            this.tabPageText.Text = "Plain Text";
            this.tabPageText.UseVisualStyleBackColor = true;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BackColor = System.Drawing.Color.White;
            this.textBoxOutput.Location = new System.Drawing.Point(3, 3);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(877, 280);
            this.textBoxOutput.TabIndex = 3;
            // 
            // ConfigureMetaListDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 371);
            this.Controls.Add(this.tabControlInd);
            this.Controls.Add(this.buttonOK);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigureMetaListDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "setincode";
            this.tabControlInd.ResumeLayout(false);
            this.tabPagePDBHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPDBHead)).EndInit();
            this.tabPagePalmDoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPalmDOC)).EndInit();
            this.tabPageMobiHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMobiHead)).EndInit();
            this.tabPageEXTHHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEXTHHead)).EndInit();
            this.tabPageText.ResumeLayout(false);
            this.tabPageText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageListButtons;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TabControl tabControlInd;
        private System.Windows.Forms.TabPage tabPagePDBHead;
        private System.Windows.Forms.DataGridView dgPDBHead;
        private System.Windows.Forms.TabPage tabPagePalmDoc;
        private System.Windows.Forms.DataGridView dgPalmDOC;
        private System.Windows.Forms.TabPage tabPageMobiHead;
        private System.Windows.Forms.DataGridView dgMobiHead;
        private System.Windows.Forms.TabPage tabPageEXTHHead;
        private System.Windows.Forms.DataGridView dgEXTHHead;
        private System.Windows.Forms.TabPage tabPageText;
        private System.Windows.Forms.TextBox textBoxOutput;
    }
}