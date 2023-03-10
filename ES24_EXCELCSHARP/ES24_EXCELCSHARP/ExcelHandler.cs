using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using Microsoft.Office.Interop.Excel;

namespace ExcelCSharp
{
    public sealed class ExcelHandler
    {

        /// <summary>
        /// Applicazione word
        /// </summary>
        private Application application;

        /// <summary>
        /// 
        /// </summary>
        private Workbook workbook;

        /// <summary>
        /// Documento word
        /// </summary>
        private Worksheet worksheet;

        public bool Visible { get; set; } = false;

        public void OpenExcel()
        {
            application = new Application
            {
                Visible = Visible
            };
        }

        public void CreateWorkBook()
        {
            workbook = application.Workbooks.Add();
        }

        public void CreateDocument()
        {
            // istanzio applicazione word
            if (application is null)
            {
                OpenExcel();
            }

            worksheet = workbook.Worksheets.Add();
        }

        public void createPDF(string path, bool open = false)
        {
            
        }

        public void printDocument()
        {
        }

        public void SaveDocumentAndClose(string fileName = "")
        {
            SaveDocument(fileName);
            CloseDocument();
        }

        public void SaveDocument(string fileName = null)
        {
            worksheet.SaveAs(fileName ?? "defaultname");
        }

        public void CloseApplication()
        {
            application?.Quit();
            application = null;
        }

        public void CloseDocument()
        {
            // da impostare se voglio chiudere word senza salvare
            workbook.Close();
        }

        public void OpenDocument(string path)
        {
            if (application is null)
            {
                OpenExcel();
            }
        }

    }
}
