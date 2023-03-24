using ExcelCSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordCSharp;
using static System.Net.WebRequestMethods;

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
                { "adult", "18 - 40" },
                { "middle age", "40 - 60" }
            });

            _wordHandler.SetRange(ref start, ref end);

            _wordHandler.InsertText("\nGenere: ", start, end);

            _wordHandler.SetRange(ref start, ref end);

            _wordHandler.AddComboBox(start, end, "cmbGenere", new Dictionary<string, string>()
            {
                { "maschio", "maschio" },
                { "femmina", "femmina" }
            });

            _wordHandler.SetRange(ref start, ref end);

            _wordHandler.InsertText("\nECDL: ", start, end);

            _wordHandler.SetRange(ref start, ref end);

            _wordHandler.AddCheckBox(start, end, "chkECDL");

            _wordHandler.SaveDocumentAndClose($@"{System.Windows.Forms.Application.StartupPath}\moduloBase.docx");

            _wordHandler.CloseApplication();
        }

        private void btnCreateReview_Click(object sender, EventArgs e)
        {
            var files = Directory.GetFiles($@"{System.Windows.Forms.Application.StartupPath}\moduli");

            _excelHandler.Visible = true;
            _excelHandler.CreateWorkBook();
            string sheetName = "Riepilogo moduli";
            _excelHandler.AddWorkSheet(sheetName);
            _excelHandler.SelectWorkSheet(sheetName);

            _excelHandler.WriteCell("A1", "Età");
            _excelHandler.WriteCell("B1", "Maschio");
            _excelHandler.WriteCell("C1", "Femmina");
            _excelHandler.WriteCell("D1", "ECDL");


            var data = getData(files);

            var datiGroupedByAge = new Dictionary<string, int[]>();

            foreach (var record in data)
            {
                var age = record.ElementAt(0);
                var genre = record.ElementAt(1);
                var ecdl = bool.Parse(record.ElementAt(2));
                var isInDictionary = datiGroupedByAge.ContainsKey(age);

                var count = isInDictionary ? 
                    datiGroupedByAge[age] : 
                    new int[3];
                
                if(ecdl)
                {
                    count[2]++;
                }

                count[genre.ToLower() == "maschio" ? 0 : 1]++;

                if(!isInDictionary)
                {
                    datiGroupedByAge.Add(age, count);
                }
            }

            int i = 1;
            foreach(var keyPairs in datiGroupedByAge)
            {
                _excelHandler.WriteCell(i, 0, keyPairs.Key);
                _excelHandler.WriteCell(i, 1, keyPairs.Value[0].ToString());
                _excelHandler.WriteCell(i, 2, keyPairs.Value[1].ToString());
                _excelHandler.WriteCell(i, 3, keyPairs.Value[2].ToString());
                i++;
            }

            _excelHandler.CreateGraph(100, 75, 400, 400, Microsoft.Office.Interop.Excel.XlChartType.xlPie, "D2", $"D{datiGroupedByAge.Count + 1}", "Ecdl");

            _excelHandler.CreateGraph(500, 75, 400, 400, Microsoft.Office.Interop.Excel.XlChartType.xlPie, "B2", $"C{datiGroupedByAge.Count + 1}", "Maschi / Femmine");

            _excelHandler.SaveAndClose($@"{System.Windows.Forms.Application.StartupPath}\riepilogo.xlsx");

            _excelHandler.CloseApplication();

        }

        private List<IEnumerable<string>> getData(string[] files)
        {
            var data = new List<IEnumerable<string>>();

            _wordHandler.OpenDocument(files[0]);

            foreach (var file in files)
            {
                _wordHandler.OpenDocument(file);

                var moduleData = _wordHandler.ReadAllModulesData();

                data.Add(moduleData.Select(keyPair => keyPair.Value));

                _wordHandler.CloseDocument();
            }

            _wordHandler.CloseApplication();

            return data;
        }
    }
}
