using ExcelCSharp;
using Microsoft.Office.Interop.Excel;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES24_EXCELCSHARP
{
    public partial class FormExcel : Form
    {

        private readonly ExcelHandler _excelHandler;
        public FormExcel()
        {
            InitializeComponent();
            _excelHandler = new ExcelHandler();
        }

        private void btnCreateExcel_Click(object sender, EventArgs e)
        {
            _excelHandler.OpenExcel();

            _excelHandler.Visible = true;

            _excelHandler.CreateWorkBook();

            _excelHandler.RenameWorkSheet(0, "Foglio Funzione");

            _excelHandler.AddWorkSheet("Foglio Grafico");

            _excelHandler.SelectWorkSheet(0);

            _excelHandler.WriteCell(0, 0, "Asse X");

            _excelHandler.WriteCell("B1", "f(x)");

            _excelHandler.WriteCells("C1", "D2", "prova");

            _excelHandler.CellsDecoration(startCell: "C1", endCell: "D2", font: "Arial", dimension: 20, bold: true, italic: true, foregroundColor: XlRgbColor.rgbAliceBlue, backgroundColor: XlRgbColor.rgbDarkRed);
        }
    }
}
