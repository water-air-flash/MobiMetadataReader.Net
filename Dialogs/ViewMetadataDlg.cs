using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MobiMetadataReader.Net.Dialogs
{
    public partial class ViewMetadataDlg : Form
    {
        public ViewMetadataDlg(FileInfo fi)
        {
            InitializeComponent();
            this.Text = String.Format("View full metadata for file '{0}'", fi.Name);

            if (File.Exists(fi.FullName))
            {
                System.IO.FileStream fs = new System.IO.FileStream(fi.FullName, System.IO.FileMode.Open, System.IO.FileAccess.Read);

                MobiMetadataReader.Net.Metadata.MobiMetadata meta = new MobiMetadataReader.Net.Metadata.MobiMetadata(fs);

                StringBuilder sb = new StringBuilder();

                if (meta.MobiHeader.EXTHHeader != null)
                {
                    sb.AppendLine("** EXTH Header **");
                    sb.AppendLine(meta.MobiHeader.EXTHHeader.ToString(false));
                }

                sb.AppendLine("** PDB Header **");
                sb.AppendLine(meta.PDBHeader.ToString(false));

                sb.AppendLine("** PalmDOC Header **");
                sb.AppendLine(meta.PalmDocHeader.ToString(false));

                sb.AppendLine("** MOBI Header **");
                sb.AppendLine(meta.MobiHeader.ToString(false));

                this.dgPDBHead.DataSource = meta.PDBHeader.FieldListNoBlankRows.ToList();
                this.dgPalmDOC.DataSource = meta.PalmDocHeader.FieldListNoBlankRows.ToList();
                this.dgMobiHead.DataSource = meta.MobiHeader.FieldListNoBlankRows.ToList();
                this.dgEXTHHead.DataSource = meta.MobiHeader.EXTHHeader.FieldListNoBlankRows.ToList();

                this.dgPDBHead.Columns[0].Width = 180;
                this.dgPDBHead.Columns[1].Width = 450;

                this.dgPalmDOC.Columns[0].Width = 180;
                this.dgPalmDOC.Columns[1].Width = 450;

                this.dgMobiHead.Columns[0].Width = 180;
                this.dgMobiHead.Columns[1].Width = 450;

                this.dgEXTHHead.Columns[0].Width = 180;
                this.dgEXTHHead.Columns[1].Width = 450;

                this.textBoxOutput.Text = sb.ToString();

                fs.Close();
            }
            else
            {
                MessageBox.Show("The file does not exist");
            }
        }

        
    }
}
