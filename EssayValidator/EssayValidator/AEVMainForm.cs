using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            PathToFile += $@"\" + FileName;

            if (!System.IO.File.Exists(PathToFile))
            {
                MessageBox.Show("Tiedostoa ei löydy.");
                return;
            }

            var text = ReadFile(PathToFile);
            List<string> sentences = text.Split('.').ToList<string>();
            foreach (var sentenced in sentences)
            {
                MessageBox.Show(sentenced);
            }
        }

        private string ReadFile(string documentPath)
        {
            Application word = new Application();
            Document doc = new Document();

            object fileName = documentPath;
            // Define an object to pass to the API for missing parameters
            object missing = System.Type.Missing;
            doc = word.Documents.Open(ref fileName,
                ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing);

            String read = string.Empty;
            List<string> data = new List<string>();
            foreach (Range tmpRange in doc.StoryRanges)
            {
                //read += tmpRange.Text + "<br>";
                data.Add(tmpRange.Text);
            }
            ((_Document)doc).Close();
            ((_Application)word).Quit();

            return string.Join(" ", data);
        }
    }
}
