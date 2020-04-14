using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace EssayValidator
{
    public static class WordReader
    {
        public static string ReadFile(string documentPath)
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


            var result = doc.StoryRanges.Cast<Range>().Aggregate("", (current, tmpRange) => current + (tmpRange.Text + " "));
            doc.Close();
            word.Quit();

            return result;
        }

        public static List<string> ReadSentences(string documentPath)
        {
            char[] arrayOfEndOfSentenceChars = {'.', '?' };
            var docContent = ReadFile(documentPath);
            return docContent.Split(arrayOfEndOfSentenceChars).ToList();
        }
    }
}
