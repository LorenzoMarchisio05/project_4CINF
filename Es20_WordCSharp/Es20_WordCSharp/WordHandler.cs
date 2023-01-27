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

        public void InsertText(object start, object end, string text)
        {
            var range = document.Range(ref start, ref end);
            
            range.Text = text;
        }
    }
}
