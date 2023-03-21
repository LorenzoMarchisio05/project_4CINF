using ExcelCSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordCSharp;

namespace ES25_ESERCITAZIONE_VERIFICAEXCEL
{
    public partial class Form1 : Form
    {
        private readonly WordHandler _wordHandler;
        private readonly ExcelHandler _excelHandler;
        public Form1()
        {
            InitializeComponent();

            _wordHandler = new WordHandler();
            _excelHandler = new ExcelHandler();
        }

        private void btnCreateModule_Click(object sender, EventArgs e)
        {
            _wordHandler.CreateDocument();
            object start = 0, end = 0;

            _wordHandler.InsertText("Età: ", 0, 0);
            _wordHandler.SetRange(ref start, ref end);
            _wordHandler.AddComboBox(start, end, "cmbEtà", new Dictionary<string, string>()
            {
                { "junior", "0 - 18" },
                { "adult", "18, 40" },
                { "middle age", "40 - 60" }
            });

            _wordHandler.SetRange(ref start, ref end)
        }

        private void btnCreateReview_Click(object sender, EventArgs e)
        {

        }
    }
}
