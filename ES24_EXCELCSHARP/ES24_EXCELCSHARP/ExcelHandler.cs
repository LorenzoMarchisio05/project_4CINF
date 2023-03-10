using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public bool Visible
        {
            get => application.Visible;
            set
            {
                if(application is null)
                {
                    OpenExcel();
                }

                application.Visible = value;
            }
        }

        public void OpenExcel()
        {
            application = new Application();
        }

        public void CreateWorkBook()
        {
            workbook = application.Workbooks.Add();
        }

        public void AddWorkSheet(string name)
        {
            var worksheet = (Worksheet)workbook
                .Worksheets
                .Add(
                    After: workbook.Worksheets[workbook.Worksheets.Count]
                );
            worksheet.Name = name;
        }

        public void CloseApplication()
        {
            application?.Quit();
            application = null;
        }

        public void SelectWorkSheet(int index)
        {
            workbook.Sheets[index + 1].Select();
            worksheet = (Worksheet)workbook.Worksheets[index + 1];
        }

        public void SelectWorkSheet(string name)
        {
            workbook.Sheets[name].Select();
            worksheet = (Worksheet)workbook.Worksheets[name];
        }

        public void RenameWorkSheet(int index, string name)
        {
            SelectWorkSheet(index);
            worksheet.Name = name;
        }

        public void WriteCell(int rowIndex, int columnIndex, string value)
        {
            worksheet.Cells[rowIndex + 1, columnIndex + 1] = value;
        }

        public void WriteCell(string cell, string value)
        {
            worksheet.Range[cell.ToUpper()].Value = value;
        }

        public void WriteCells(string startCell, string endCell, string value)
        {
            worksheet.Range[startCell.ToUpper(), endCell.ToUpper()].Value = value;
        }

        public void CellsDecoration(string startCell,
                                   string endCell,
                                   string font,
                                   int dimension,
                                   bool bold,
                                   bool italic,
                                   XlRgbColor foregroundColor,
                                   XlRgbColor backgroundColor)
        {
            var cells = worksheet.Range[startCell.ToUpper(), endCell.ToUpper()];
            
        }
    }
}
