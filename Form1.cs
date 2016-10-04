using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.IsolatedStorage;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Reflection;
using System.Collections;

namespace MobiMetadataReader.Net
{
    public partial class Form1 : Form
    {
        private bool loaded = false;

        private List<string> colsRightJustified = new List<string>() { "S.Size (KB)" };
        private List<string> colsOrderByDate = new List<string>() { "S.Created" };
        private List<string> colsOrderByNumber = new List<string>() { "S.Size (KB)" };
        private List<string> metadataSupportedExtensions = new List<string>() { ".MOBI", ".PRC" };
        private const string ISOPREFERENCESFILE = "MMRSettings";

        private MMRSettings currentSettings;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentSettings = LoadSettings();
            LoadUp();

            string formTitleFormat = "{0} {1}";
            AIHelper ai = new AIHelper(typeof(MMRSettings));
            this.Text = String.Format(formTitleFormat, ai.Title, ai.AssemblyVersion.ToString());
        }

        private void LoadUp()
        {
            listViewItems.Columns.Clear();
            foreach (MMRSettings.MetadataSet.MetaGridColumn col in currentSettings.MetadataSettings.MetaGridColumns)
            {
                listViewItems.Columns.Add(col.Name, col.Width, HorizontalAlignment.Left);
            }

            if (Directory.Exists(currentSettings.MetadataSettings.MetaFolder))
            {
                this.explorerTree1.SetSelectedPath(currentSettings.MetadataSettings.MetaFolder);
                LoadFolderData(false);
            }

            splitContainer1.SplitterDistance = currentSettings.MetadataSettings.SplitterDistance;
            loaded = true;
            this.labelHomeFolder.Text = currentSettings.FilePath;
        }

        private void LoadFolderData(bool forceRebuild)
        {
            try
            {
                if (forceRebuild)
                {
                    listViewItems.Columns.Clear();

                    foreach (MMRSettings.MetadataSet.MetaGridColumn col in currentSettings.MetadataSettings.MetaGridColumns)
                    {
                        if (colsRightJustified.Contains(col.Name, System.StringComparer.CurrentCultureIgnoreCase))
                        {
                            listViewItems.Columns.Add(col.Name, col.Width, HorizontalAlignment.Right);
                        }
                        else
                        {
                            listViewItems.Columns.Add(col.Name, col.Width, HorizontalAlignment.Left);
                        }

                    }
                }

                DirectoryInfo dir = new DirectoryInfo(this.explorerTree1.SelectedPath);

                this.listViewItems.Items.Clear();

                Metadata.BaseHeader head = null;
                if (dir.Exists)
                {
                    foreach (FileInfo fil in dir.GetFiles())
                    {
                        if (MetadataExtensionSupported(GetFileExtension(fil.Name).ToUpper()))
                        {
                            ListViewItem lvi = new ListViewItem();
                            lvi.Tag = fil;
                            head = null;

                            string colName = String.Empty;
                            string content = String.Empty;

                            try
                            {
                                Metadata.MobiMetadata mobiMeta = new Metadata.MobiMetadata(fil.FullName);

                                foreach (ColumnHeader col in this.listViewItems.Columns)
                                {
                                    colName = col.Text.Substring(2, col.Text.Length - 2);
                                    head = null;
                                    switch (col.Text.Substring(0, 1))
                                    {
                                        case "P": head = mobiMeta.PDBHeader; break;
                                        case "D": head = mobiMeta.PalmDocHeader; break;
                                        case "M": head = mobiMeta.MobiHeader; break;
                                        case "E": head = mobiMeta.MobiHeader.EXTHHeader; break;
                                        case "S":
                                            switch (colName.ToUpper())
                                            {
                                                case "FILENAME":
                                                    content = fil.Name;
                                                    break;
                                                case "SIZE (KB)":
                                                    content = (fil.Length / 1000).ToString();
                                                    break;
                                                case "CREATED":
                                                    content = fil.CreationTime.ToString("dd MMM yyyy hh:mm:ss");
                                                    break;
                                            }
                                            break;
                                    }

                                    if (head != null)
                                    {
                                        content = head.FieldList[col.Text.Substring(2, col.Text.Length - 2)].ToString();
                                    }

                                    if (lvi.Text == String.Empty)
                                    {
                                        lvi.Text = content;
                                    }
                                    else
                                    {
                                        lvi.SubItems.Add(content);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                lvi.SubItems.Add(ex.Message);
                            }

                            this.listViewItems.Items.Add(lvi);
                        }
                    }

                    int maxColWidth = currentSettings.MetadataSettings.MaxColWidth;

                    //Only auto-resize if the column is less than max width

                    if (currentSettings.MetadataSettings.AutoSizeColumns)
                    {
                        for (int i = 0; i < listViewItems.Columns.Count; i++)
                        {
                            listViewItems.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                            if (listViewItems.Columns[i].Width > maxColWidth)
                            {
                                listViewItems.Columns[i].Width = maxColWidth;
                            }
                        }
                    }

                    //Sort the data
                    foreach (ColumnHeader col in listViewItems.Columns)
                    {
                        if (col.Text == currentSettings.MetadataSettings.OrderBy.Name)
                        {
                            eSortType sortType = eSortType.String;
                            if (colsOrderByDate.Contains(col.Text, System.StringComparer.CurrentCultureIgnoreCase))
                            {
                                sortType = eSortType.DateTime;
                            }
                            else if (colsOrderByNumber.Contains(col.Text, System.StringComparer.CurrentCultureIgnoreCase))
                            {
                                sortType = eSortType.Number;
                            }
                            listViewItems.ListViewItemSorter = new ListViewCustomSort(col.Index, currentSettings.MetadataSettings.OrderBy.Ascending, sortType);
                            listViewItems.Sort();
                        }
                    }

                }

                if (this.listViewItems.Items.Count > 0)
                {
                    this.listViewItems.Items[0].Selected = true;
                }
            }

            catch (Exception ex)
            {
                currentSettings.MetadataSettings.MetaFolder = currentSettings.FilePath;
                throw ex;
            }
        }

        public bool MetadataExtensionSupported(string extension)
        {
            return metadataSupportedExtensions.Contains(extension);
        }

        private string MetadataSupportedExtensions
        {
            get
            {
                string ext = string.Join(",", metadataSupportedExtensions.ToArray());
                return ext;
            }
        }

        private string GetFileExtension(string fileName)
        {
            int indexChar = fileName.LastIndexOf(".");
            if (indexChar != -1)
            {
                return fileName.Substring(indexChar, fileName.Length - indexChar).ToUpper();
            }
            else
            {
                return "No extension";
            }
        }

        private void SaveSettings(MMRSettings settings)
        {
            SaveToStore(settings.ToXml(), ISOPREFERENCESFILE);
        }

        private MMRSettings LoadSettings()
        {
            try
            {
                return MMRSettings.FromXml((string)LoadFromStore(ISOPREFERENCESFILE));
            }
            catch (Exception ex)
            {
                MMRSettings newSettings = MMRSettings.GetNewSettings();
                SaveSettings(newSettings);
                return newSettings;
            }
        }

        private void SaveToStore(
            object objToSave, string key)
        {
            IsolatedStorageFile isoFile = IsolatedStorageFile.GetUserStoreForDomain();

            using (IsolatedStorageFileStream isoStream =
                 new IsolatedStorageFileStream(
                 key, FileMode.OpenOrCreate,
                 FileAccess.Write, isoFile))
            {
                BinaryFormatter formatter =
                 new BinaryFormatter();
                formatter.Serialize(isoStream, objToSave);
            }
        }

        private object LoadFromStore(string key)
        {
            IsolatedStorageFile isoFile = IsolatedStorageFile.GetUserStoreForDomain();

            using (IsolatedStorageFileStream isoStream =
                    new IsolatedStorageFileStream(
                    key, FileMode.Open,
                    FileAccess.Read, isoFile))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (object)formatter.Deserialize(isoStream);
            }
        }

        public class ListViewCustomSort : IComparer
        {
            private int SortColumn;
            private bool Ascending = true;
            private eSortType SortType;

            public ListViewCustomSort(int sortColumn, bool ascending, eSortType sortType)
            {
                SortColumn = sortColumn;
                Ascending = ascending;
                SortType = sortType;
            }

            public int Compare(object x, object y)
            {
                int result = 0;
                ListViewItem itemX = x as ListViewItem;
                ListViewItem itemY = y as ListViewItem;
                string textX = String.Empty;
                string textY = String.Empty;

                if (SortColumn == 0)
                {
                    textX = itemX.Text;
                    textY = itemY.Text;
                }
                else
                {
                    textX = itemX.SubItems[SortColumn].Text;
                    textY = itemY.SubItems[SortColumn].Text;
                }

                switch (SortType)
                {
                    case eSortType.DateTime: result = DateTime.Compare(DateTime.Parse(textX), DateTime.Parse(textY)); break;
                    case eSortType.Number: result = Decimal.Compare(Decimal.Parse(textX), Decimal.Parse(textY)); break; break;
                    case eSortType.String:
                    default: result = textX.CompareTo(textY); break;
                }

                if (!Ascending)
                {
                    result = -result;
                }
                return result;
            }
        }

        private void explorerTree1_PathChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                currentSettings.MetadataSettings.MetaFolder = explorerTree1.SelectedPath;
                LoadFolderData(false);
            }
        }

        private void Configure()
        {
            Dialogs.ConfigureMetaListDlg metaDlg = new Dialogs.ConfigureMetaListDlg(currentSettings);
            metaDlg.ShowDialog();
            LoadFolderData(true);
        }

        private void ViewMetadata()
        {
            if (this.listViewItems.SelectedItems.Count > 0)
            {
                FileInfo fi = (FileInfo)this.listViewItems.SelectedItems[0].Tag;
                Dialogs.ViewMetadataDlg viewMeta = new Dialogs.ViewMetadataDlg(fi);
                viewMeta.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a file first");
            }
        }

        private void cmdMetadataGrid_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "tsmView":
                    ViewMetadata();
                    break;
                case "tsmConfigure":
                    Configure();
                    break;
            }
        }

        private void cmdMetadataGrid_Opened(object sender, EventArgs e)
        {
            tsmView.Enabled = (listViewItems.SelectedItems.Count > 0);
        }

        private void explorerTree1_ButtonClicked(object sender, EventArgs e, eExplorerButton buttonClicked)
        {
            switch (buttonClicked)
            {
                case eExplorerButton.Configure:
                    Configure();
                    break;
                case eExplorerButton.ViewMetadata:
                    ViewMetadata();
                    break;
                case eExplorerButton.Home:
                    explorerTree1.SetSelectedPath(currentSettings.FilePath);
                    
                    break;
            }
        }

        private void listViewItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            explorerTree1.GetButton(eExplorerButton.ViewMetadata).Enabled = (this.listViewItems.SelectedItems.Count > 0);
        }

        private void SetColumnWidths()
        {
            if (!currentSettings.MetadataSettings.AutoSizeColumns)
            {
                foreach (ColumnHeader col in listViewItems.Columns)
                {
                    currentSettings.MetadataSettings.SetColumnWidth(col.Text, col.Width);
                }
            }
        }

        private void listViewItems_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            SetColumnWidths();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            currentSettings.MetadataSettings.SplitterDistance = splitContainer1.SplitterDistance;
        }

        private void listViewItems_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (listViewItems.Columns[e.Column].Text == currentSettings.MetadataSettings.OrderBy.Name)
            {
                //Same column so reverse the order
                currentSettings.MetadataSettings.OrderBy.Ascending = !currentSettings.MetadataSettings.OrderBy.Ascending;
            }
            else
            {
                currentSettings.MetadataSettings.OrderBy.Name = listViewItems.Columns[e.Column].Text;
            }

            LoadFolderData(false);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings(currentSettings);
        }


        private void tsSetHome_Click(object sender, EventArgs e)
        {
            currentSettings.FilePath = explorerTree1.SelectedPath;
            this.labelHomeFolder.Text = currentSettings.FilePath;
        }

        private void tsRestore_Click(object sender, EventArgs e)
        {
            currentSettings = MMRSettings.GetNewSettings();
            LoadUp();
        }

        private void tsAbout_Click(object sender, EventArgs e)
        {
            Dialogs.About about = new Dialogs.About();
            about.ShowDialog();
        }

        private void RenameMobi(string fileName)
        {
            System.IO.FileStream fs = new System.IO.FileStream(fileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);

            MobiMetadataReader.Net.Metadata.MobiMetadata meta = new MobiMetadataReader.Net.Metadata.MobiMetadata(fs);

            var title = meta.MobiHeader.EXTHHeader.UpdatedTitle;
            var author=meta.MobiHeader.EXTHHeader.Author;
            if (string.IsNullOrWhiteSpace(title))
            {
                title= meta.MobiHeader.FieldListNoBlankRows.Where(i=>i.Key.ToString()=="FullName").Select(i=>i.Value.ToString()).First();
            }
            if(string.IsNullOrWhiteSpace(author)){

                author = "Anonymous";
            }
            var targetName = GetValidName(author) + " - " +GetValidName(title);
            fs.Close(); 
            
            var destination=System.IO.Path.GetDirectoryName(fileName) + "\\" + targetName + System.IO.Path.GetExtension(fileName);
            if(fileName!=destination){

            if(System.IO.File.Exists(destination)){
                var destinationDirectory=System.IO.Path.GetDirectoryName(fileName)+"\\_OUTPUT";
                if(!System.IO.Directory.Exists(destinationDirectory))
                {
                   
                    System.IO.Directory.CreateDirectory(destinationDirectory);
                }
                destination=destinationDirectory+ "\\" + targetName + System.IO.Path.GetExtension(fileName);
                var i = 0;
                while (System.IO.File.Exists(destination))
                {
                    i++;
                    destination = destinationDirectory + "\\" + targetName+" "+i.ToString() + System.IO.Path.GetExtension(fileName);
                }
            }
            System.IO.File.Move(fileName, destination);
            }
            
        }

        char[] invalidChars = System.IO.Path.GetInvalidFileNameChars();
        private string GetValidName(string name)
        {
            var maker = new StringBuilder();

            foreach (var item in name.ToCharArray())
            {
                if (invalidChars.Contains(item))
                {
                    maker.Append(' ');
                }
                else
                {
                    maker.Append(item);
                }
            }
            return maker.ToString();
        }
        private void 重命名ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var dlg = new OpenFileDialog();
            dlg.Filter = "*.*|*.*";
            dlg.Multiselect = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                foreach (var item in dlg.FileNames)
                {
                    RenameMobi(item);
                }
            }
        }
    }
}
