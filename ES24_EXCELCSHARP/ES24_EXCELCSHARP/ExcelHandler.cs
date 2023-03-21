using System;
using System.Collections.Generic;
using System.Drawing;
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

        public string ReadCell(string cell)
        {
            return Convert.ToString(worksheet.Range[cell].Value);
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

        public Range GetRange(string cellStart, string cellEnd)
        {
            return worksheet.Range[cellStart.ToUpper(), cellEnd.ToUpper()];
        }

        #region Grafico

        public ChartObject CreateGraph(double left,
                                       double top,
                                       double width,
                                       int height,
                                       XlChartType type,
                                       string dataStartCell,
                                       string dataEndCell,
                                       string title = null,
                                       Color? titleForegroundColor = null,
                                       Color? titleBorderColor = null,
                                       Color? legendBorderColor = null,
                                       string seriesName = null)
        {
            var charts = worksheet.ChartObjects() as ChartObjects;
            var chart = charts.Add(left, top, width, height);

            chart.Chart.ChartType = type;

            var range = worksheet.Range[dataStartCell.ToUpper(), dataEndCell.ToUpper()];
            chart.Chart.SetSourceData(range);

            if(!(title is null))
            {
                chart.Chart.HasTitle = true;
                chart.Chart.ChartTitle.Text = title;
            }
            if(!(titleForegroundColor is null))
            {
                chart.Chart.ChartTitle.Font.Color = ColorTranslator.ToOle(titleForegroundColor ?? Color.Black);
            }
            if (!(titleBorderColor is null))
            {
                chart.Chart.ChartTitle.Border.Color = ColorTranslator.ToOle(titleBorderColor ?? Color.Black);
            }

            if(!(legendBorderColor is null))
            {
                chart.Chart.HasLegend = true;
                chart.Chart.Legend.Border.Color = ColorTranslator.ToOle(legendBorderColor ?? Color.Black);
            }
            if(!(seriesName is null))
            {
                var serie = chart.Chart.SeriesCollection(1) as Series;
                serie.HasDataLabels = false;
                serie.Name = seriesName;
            }

            return chart;
        }

        public ChartObject CreateGraph(double left,
                                       double top,
                                       double width,
                                       int height,
                                       XlChartType type,
                                       Range dataRange,
                                       string title = null,
                                       Color? titleForegroundColor = null,
                                       Color? titleBorderColor = null,
                                       Color? legendBorderColor = null,
                                       string seriesName = null)
        {
            /*
            var address = dataRange
                .Cells[dataRange.Row, dataRange.Column]
                .Address;
            var addresses = dataRange
                .Cells[dataRange.Row, dataRange.Column]
                .Address
                .Split(':');

            var startCell = addresses[0];
            var endCell = addresses[1];

            return this.CreateGraph(left,
                               top,
                               width,
                               height,
                               type,
                               startCell,
                               endCell,
                               title,
                               titleForegroundColor,
                               titleBorderColor,
                               legendBorderColor,
                               seriesName);
            */
            var charts = worksheet.ChartObjects() as ChartObjects;
            var chart = charts.Add(left, top, width, height);

            chart.Chart.ChartType = type;
          
            chart.Chart.SetSourceData(dataRange);

            if (!(title is null))
            {
                chart.Chart.HasTitle = true;
                chart.Chart.ChartTitle.Text = title;
            }
            if (!(titleForegroundColor is null))
            {
                chart.Chart.ChartTitle.Font.Color = ColorTranslator.ToOle(titleForegroundColor ?? Color.Black);
            }
            if (!(titleBorderColor is null))
            {
                chart.Chart.ChartTitle.Border.Color = ColorTranslator.ToOle(titleBorderColor ?? Color.Black);
            }

            if (!(legendBorderColor is null))
            {
                chart.Chart.HasLegend = true;
                chart.Chart.Legend.Border.Color = ColorTranslator.ToOle(legendBorderColor ?? Color.Black);
            }
            if (!(seriesName is null))
            {
                var serie = chart.Chart.SeriesCollection(1) as Series;
                serie.HasDataLabels = false;
                serie.Name = seriesName;
            }

            return chart;
        }

        public bool ExportGraph(string path, string extension, ChartObject chart)
        {
            try
            {
                chart.Chart.Export($"{path}.{extension.ToLower()}", extension.ToUpper());
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        #endregion

        public (int, int) GetColumnsRows(int sheetIndex)
        {
            SelectWorkSheet(sheetIndex);
            return (
                    worksheet.UsedRange.Column - 1 + worksheet.UsedRange.Columns.Count,
                    worksheet.UsedRange.Row - 1 + worksheet.UsedRange.Rows.Count
                );
        }

        public (int, int) GetColumnsRows(string sheetName)
        {
            SelectWorkSheet(sheetName);
            return (
                    worksheet.UsedRange.Column - 1 + worksheet.UsedRange.Columns.Count,
                    worksheet.UsedRange.Row - 1 + worksheet.UsedRange.Rows.Count
                );
        }

        public void Save(string path)
        {
            workbook.SaveAs(path);
        }

        public void SaveAndClose(string path)
        {
            Save(path);
            CloseWorkBook();
        }

        public void CloseWorkBook()
        {
            workbook.Close();
        }

        public void CloseApplication()
        {
            application?.Quit();
            application = null;
        }

        public void OpenExcel()
        {
            application = new Application();
        }

        public void OpenWorkBook(string path, bool visible, int sheetIndex = 0)
        {
            Visible = visible;
            if(application is null)
            {
                OpenExcel();
            }
            workbook = application.Workbooks.Open(path);
            SelectWorkSheet(sheetIndex);
        }

        public void OpenWorkBook(string path, bool visible, string sheetName)
        {
            Visible = visible;
            if (application is null)
            {
                OpenExcel();
            }
            workbook = application.Workbooks.Open(path);
            SelectWorkSheet(sheetName);
        }
    }
}
