using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MobiMetadataReader.Net.Dialogs
{
    public partial class ConfigureMetaListDlg : Form
    {
        private List<string> systemCols = new List<string>() { "Filename", "Size (KB)", "Created" };
        private MMRSettings currentSettings;

        public ConfigureMetaListDlg(MMRSettings settings)
        {
            InitializeComponent();
            currentSettings = settings;
        }

        private void ConfigureMetaListDlg_Load(object sender, EventArgs e)
        {
            this.textBoxMaxWidth.Text = currentSettings.MetadataSettings.MaxColWidth.ToString();
            this.checkBoxAutosize.Checked = currentSettings.MetadataSettings.AutoSizeColumns;

            MobiMetadataReader.Net.Metadata.PDBHead pdbhead = new MobiMetadataReader.Net.Metadata.PDBHead();
            MobiMetadataReader.Net.Metadata.PalmDOCHead dochead = new MobiMetadataReader.Net.Metadata.PalmDOCHead();
            MobiMetadataReader.Net.Metadata.MobiHead mobhead = new MobiMetadataReader.Net.Metadata.MobiHead();
            MobiMetadataReader.Net.Metadata.EXTHHead exhead = new MobiMetadataReader.Net.Metadata.EXTHHead();

            foreach (string key in systemCols)
            {
                if (!currentSettings.MetadataSettings.MetaGridColumnIncluded(String.Format("S.{0}", key)))
                {
                    this.listBoxSystem.Items.Add(key);
                }
            }

            foreach (string key in pdbhead.EmptyFieldList.Keys)
            {
                if (!currentSettings.MetadataSettings.MetaGridColumnIncluded(String.Format("P.{0}", key)))
                {
                    this.listBoxPDBHeader.Items.Add(key);
                }
            }

            foreach (string key in dochead.EmptyFieldList.Keys)
            {
                if (!currentSettings.MetadataSettings.MetaGridColumnIncluded(String.Format("D.{0}", key)))
                {
                    this.listBoxPalmDOCHeader.Items.Add(key);
                }
            }

            foreach (string key in mobhead.EmptyFieldList.Keys)
            {
                if (!currentSettings.MetadataSettings.MetaGridColumnIncluded(String.Format("M.{0}", key)))
                {
                    this.listBoxMobiHeader.Items.Add(key);
                }
            }

            foreach (string key in exhead.EmptyFieldList.Keys)
            {
                if (!currentSettings.MetadataSettings.MetaGridColumnIncluded(String.Format("E.{0}", key)))
                {
                    this.listBoxEXTHHeader.Items.Add(key);
                }
            }

            foreach (MMRSettings.MetadataSet.MetaGridColumn col in currentSettings.MetadataSettings.MetaGridColumns)
            {
                this.listBoxChosenColumns.Items.Add(col.Name);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.listBoxChosenColumns.Items.Count == 0)
            {
                MessageBox.Show("You must selected at least one column.");
                return;
            }

            List<MMRSettings.MetadataSet.MetaGridColumn> tempcols = new List<MMRSettings.MetadataSet.MetaGridColumn>();
            foreach (MMRSettings.MetadataSet.MetaGridColumn col in currentSettings.MetadataSettings.MetaGridColumns)
            {
                tempcols.Add(new MMRSettings.MetadataSet.MetaGridColumn(col.Name, col.Width));
            }

            currentSettings.MetadataSettings.MetaGridColumns.Clear();
            foreach (string colName in this.listBoxChosenColumns.Items)
            {
                //First check to see if this was here before so we can record its previous width
                int setWidth = 200;
                foreach (MMRSettings.MetadataSet.MetaGridColumn col in tempcols)
                {
                    if (colName == col.Name)
                    {
                        setWidth = col.Width;
                        break;
                    }
                }
                currentSettings.MetadataSettings.MetaGridColumns.Add(new MMRSettings.MetadataSet.MetaGridColumn(colName, setWidth));
            }

            //Need to check that the OrderBy column is still available
            //If not then default to the first column, ascending, by default
            if (!currentSettings.MetadataSettings.MetaGridColumnIncluded(currentSettings.MetadataSettings.OrderBy.Name))
            {
                currentSettings.MetadataSettings.OrderBy.Name = currentSettings.MetadataSettings.MetaGridColumns[0].Name;
                currentSettings.MetadataSettings.OrderBy.Ascending = true;
            }
        }

        private void listBoxPDBHeader_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddChosenColumn(listBoxPDBHeader, "P");
        }

        private void listBoxPalmDOCHeader_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddChosenColumn(listBoxPalmDOCHeader, "D");
        }

        private void listBoxMobiHeader_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddChosenColumn(listBoxMobiHeader, "M");
        }

        private void listBoxEXTHHeader_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddChosenColumn(listBoxEXTHHeader, "E");
        }

        private void listBoxChosenColumns_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.listBoxChosenColumns.SelectedItems.Count > 0)
            {
                int sel = listBoxChosenColumns.SelectedIndices[0];
                string columnName = listBoxChosenColumns.SelectedItems[0].ToString();
                ListBox listBox = null;
                string prefix = columnName.Substring(0, 2);
                switch (prefix)
                {
                    case "P.": listBox = this.listBoxPDBHeader; break;
                    case "D.": listBox = this.listBoxPalmDOCHeader; break;
                    case "M.": listBox = this.listBoxMobiHeader; break;
                    case "E.": listBox = this.listBoxEXTHHeader; break;
                    case "S.": listBox = this.listBoxSystem; break;
                }

                listBox.Items.Add(columnName.Replace(prefix, String.Empty));

                listBoxChosenColumns.Items.RemoveAt(sel);
            }
        }

        private void AddChosenColumn(ListBox listBox, string prefix)
        {
            if (listBox.SelectedItems.Count > 0)
            {
                int sel = listBox.SelectedIndices[0];
                listBoxChosenColumns.Items.Add(String.Format("{0}.{1}", prefix, listBox.SelectedItems[0]));
                listBox.Items.RemoveAt(sel);
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            MoveItem(-1);
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            MoveItem(1);
        }

        private void MoveItem(int direction)
        {
            if (listBoxChosenColumns.SelectedItem == null || listBoxChosenColumns.SelectedIndex < 0)
                return;

            int newIndex = listBoxChosenColumns.SelectedIndex + direction;

            if (newIndex < 0 || newIndex >= listBoxChosenColumns.Items.Count)
                return;

            object selected = listBoxChosenColumns.SelectedItem;

            listBoxChosenColumns.Items.Remove(selected);
            listBoxChosenColumns.Items.Insert(newIndex, selected);
            listBoxChosenColumns.SetSelected(newIndex, true);
        }

        private void textBoxMaxWidth_Leave(object sender, EventArgs e)
        {
            currentSettings.MetadataSettings.MaxColWidth = int.Parse(this.textBoxMaxWidth.Text);
        }

        private void checkBoxAutosize_CheckedChanged(object sender, EventArgs e)
        {
            currentSettings.MetadataSettings.AutoSizeColumns = checkBoxAutosize.Checked;
        }

        private void listBoxSystem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddChosenColumn(listBoxSystem, "S");
        }
    }
}
