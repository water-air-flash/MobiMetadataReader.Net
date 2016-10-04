using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace MobiMetadataReader.Net
{
    [Serializable]
    public class MMRSettings
    {
        public MetadataSet MetadataSettings = new MetadataSet();
        public string FilePath = @"C:\";

        public class MetadataSet
        {
            public int MaxColWidth = 350;
            public int SplitterDistance = 300;
            public string MetaFolder = @"C:\";
            public bool AutoSizeColumns = false;
            public OrdBy OrderBy = new OrdBy();
            public List<MetaGridColumn> MetaGridColumns = new List<MetaGridColumn>();

            public bool MetaGridColumnIncluded(string metaGridColumnName)
            {
                bool found = false;
                foreach (MetaGridColumn col in MetaGridColumns)
                {
                    if (metaGridColumnName == col.Name)
                    {
                        found = true;
                        break;
                    }
                }
                return found;
            }

            public void SetColumnWidth(string metaGridColumnName, int width)
            {
                foreach (MetaGridColumn col in MetaGridColumns)
                {
                    if (metaGridColumnName == col.Name)
                    {
                        col.Width = width;
                        break;
                    }
                }
            }

            public class OrdBy
            {
                [XmlAttribute("ColumnName")]
                public string Name = "S.Filename";

                [XmlAttribute("Ascending")]
                public bool Ascending = true;
            }

            public class MetaGridColumn
            {
                public MetaGridColumn()
                {

                }

                public MetaGridColumn(string name, int width)
                {
                    this.Name = name;
                    this.Width = width;
                }

                [XmlAttribute("Name")]
                public string Name;

                [XmlAttribute("Width")]
                public int Width;
            }
        }


        public static MMRSettings GetNewSettings()
        {
            MMRSettings newSettings = new MMRSettings();
            newSettings.FilePath = @"C:\";

            newSettings.MetadataSettings.MaxColWidth = 350;
            newSettings.MetadataSettings.MetaFolder = newSettings.FilePath;
            newSettings.MetadataSettings.AutoSizeColumns = false;
            newSettings.MetadataSettings.MetaGridColumns.Add(new MetadataSet.MetaGridColumn("S.Filename", 305));
            newSettings.MetadataSettings.MetaGridColumns.Add(new MetadataSet.MetaGridColumn("E.Author", 150));
            newSettings.MetadataSettings.MetaGridColumns.Add(new MetadataSet.MetaGridColumn("E.UpdatedTitle", 200));
            newSettings.MetadataSettings.OrderBy.Name = "S.Filename";
            newSettings.MetadataSettings.OrderBy.Ascending = true;

            return newSettings;
        }


        public static MMRSettings FromXml(string xml)
        {
            MMRSettings settings = new MMRSettings();
            XmlSerializer serializer = new XmlSerializer(typeof(MMRSettings));
            using (TextReader reader = new StringReader(xml))
            {
                settings = (MMRSettings)serializer.Deserialize(reader);
            }
            return settings;
        }

        #region Public Methods

        public string ToXml()
        {
            return SerializeToString(this);
        }

        #endregion

        #region Private Methods
        private string SerializeToString(object obj)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, obj);
                return writer.ToString();
            }
        }
        #endregion
    }
}
