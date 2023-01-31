using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;

namespace WordCSharp
{
    public sealed class WordHandler
    {
        /// <summary>
        /// Applicazione word
        /// </summary>
        private Application application;

        /// <summary>
        /// Documento word
        /// </summary>
        private Document document;


        
        public void CreateDocument(bool visible = true)
        {
            // istanzio applicazione word
            application = new Application
            {
                Visible = visible
            };
            document = new Document();
            document = application.Documents.Add();
        }


        public void SetRange(ref object start, ref object end)
        {
            start = document.Sentences[document.Sentences.Count].End - 1;
            end = document.Sentences[document.Sentences.Count].End;
        }

        public void InsertText(object start, object end, string text, string newLine = "")
        {
            var range = document.Range(ref start, ref end);

            range.Text = text + newLine; 
        }

        public void AppendText(string text, string newLine = "")
        {
            object start = 0,
                   end = 0;

            SetRange(ref start, ref start);

            InsertText(start, end, text, newLine);
        }

        
    }
}
