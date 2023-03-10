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
            _excelHandler.CreateWorkBook();
        }
    }
}
