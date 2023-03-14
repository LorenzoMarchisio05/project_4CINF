﻿using ExcelCSharp;
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
                       
            _excelHandler.CellsBorder(startCell: "A1",
                                      endCell: "B1",
                                      lineStyle: XlLineStyle.xlDouble,
                                      borderWeight: XlBorderWeight.xlMedium);
            
            writeFunctionData(-10, 10);

            
        }

        private void writeFunctionData(int start, int end)
        {
            for (int i = 1; start <= end; i++)
            {
                _excelHandler.WriteCell(i, 0, start.ToString());
                _excelHandler.WriteFormula(cell: $"B{i+1}",
                                           formula: $"=POTENZA(A{i + 1};2) - 5");
                start++;
            }
        }
    }
}
