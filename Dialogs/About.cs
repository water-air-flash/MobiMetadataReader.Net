using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace MobiMetadataReader.Net.Dialogs
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            AIHelper ai = new AIHelper(typeof(MMRSettings));
            this.labelAppTitle.Text = ai.Title;
            this.labelVersion.Text = "Version " + ai.AssemblyVersion.ToString();
            this.labelDescription.Text = ai.Description;
            this.labelCopyright.Text = ai.Copyright;

            using (Stream stream = Assembly.GetExecutingAssembly()
                .GetManifestResourceStream("MobiMetadataReader.Net.History.History.txt"))
            using (StreamReader reader = new StreamReader(stream))
            {
                this.textBoxHistory.Text = reader.ReadToEnd();
            }


        }
    }
}
