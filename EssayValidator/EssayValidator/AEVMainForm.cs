using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Customsearch.v1;
using Google.Apis.Customsearch.v1.Data;
using Google.Apis.Services;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;

namespace EssayValidator
{
    public partial class AEVMainForm : Form
    {
        public AEVMainForm()
        {
            InitializeComponent();
        }

        private string PathToFile = $@"C:\Temp";
        private string FileName = "testi.docx";

        private void button_Validate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_PathToEssayDocument.Text)) PathToFile = textBox_PathToEssayDocument.Text;

            // TODO Path join
            PathToFile = PathToFile + $@"\" + FileName;

            if (!System.IO.File.Exists(PathToFile))
            {
                MessageBox.Show($"Tiedostoa {PathToFile} ei löydy.");
                return;
            }

            var sentences = WordReader.ReadSentences(PathToFile);
            dataGridView_result.Columns.Add("Title", "Title");
            dataGridView_result.Columns.Add("Link", "Link");
            foreach (var sentenced in sentences)
            {
                IList<Result> result = GoogleSearchApi.Search(sentenced, out var total);
                if (result == null) continue;
                Result first = result[0];
                label1.Text = total;
                dataGridView_result.Rows.Add(first.Title, first.Link);
            }
        }

    }
}
