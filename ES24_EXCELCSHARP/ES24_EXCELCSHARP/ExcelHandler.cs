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
                                    XlRgbColor backgroundColor,
                                    bool autoFit = true)
        {
            var cells = worksheet.Range[startCell.ToUpper(), endCell.ToUpper()];

            cells.Font.Name = font;
            cells.Font.Size = dimension;
            cells.Font.Bold = bold;
            cells.Font.Italic = italic;
            cells.Font.Color = foregroundColor;
            cells.Interior.Color = backgroundColor;

            if (autoFit)
            {
                cells.EntireColumn.AutoFit();
            }
        }

        public void CellsBorder(string startCell,
                                string endCell,
                                XlLineStyle lineStyle,
                                XlBorderWeight borderWeight)
        {
            var cells = worksheet.Range[startCell.ToUpper(), endCell.ToUpper()];

            cells.BorderAround2(lineStyle, borderWeight);
        }

        public void WriteFormula(int rowIndex, int columnIndex, string formula)
        {
            (worksheet.Cells[rowIndex + 1, columnIndex + 1] as Range).FormulaLocal = formula;
        }

        public void WriteFormula(string cell, string formula)
        {
            worksheet.Range[cell.ToUpper()].FormulaLocal = formula;
        }
    }
}
