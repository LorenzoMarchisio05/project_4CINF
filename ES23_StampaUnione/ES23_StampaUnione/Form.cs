using Es20_WordCSharp;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordCSharp;

namespace ES23_StampaUnione
{
    public partial class Form : System.Windows.Forms.Form
    {
        private const bool MOSTRA_WORD = false;

        private readonly string resumepath = $"{System.Windows.Forms.Application.StartupPath}\\Riepilogo.docx";

        private readonly WordHandler _wordHandler;

        public Form()
        {
            InitializeComponent();

            _wordHandler = new WordHandler();

            btnOpenResume.Enabled = false;
        }

        private void btnCreateModuleTemplate_Click(object sender, EventArgs e)
        {
            _wordHandler.CreateDocument(MOSTRA_WORD);

            object start = 0,
                  end = 0;

            var elencoCantanti = new Dictionary<string, string>
            {
                { "1", "Cantante 1" },
                { "2", "Cantante 2" },
                { "3", "Cantante 3" },
                { "4", "Cantante 4" },
                { "5", "Cantante 5" },
            };

            // Titolo

            _wordHandler.InsertText(
                    text: "Sondaggio",
                    start: 0,
                    end: 0,
                    newLine: "\n",
                    font: "Comic Sans MS",
                    size: "22",
                    underline: "None",
                    align: "Center",
                    bold: default,
                    italic: default,
                    color: "Red"
                );

            // Textbox età

            _wordHandler.SetRange(ref start, ref end);

            _wordHandler.InsertText(
                   text: "Inserisci la tua ",
                   start: start,
                   end: end,
                   newLine: "",
                   font: "Comic Sans MS",
                   size: "18",
                   underline: "None",
                   align: "Left",
                   bold: default,
                   italic: default,
                   color: "Blue"
               );

            _wordHandler.SetRange(ref start, ref end);

            _wordHandler.InsertText(
                   text: "età",
                   start: start,
                   end: end,
                   newLine: "",
                   font: "Comic Sans MS",
                   size: "18",
                   underline: "Single",
                   align: "Left",
                   bold: default,
                   italic: default,
                   color: "Blue"
               );

            _wordHandler.SetRange(ref start, ref end);

            _wordHandler.InsertText(
                   text: ": ",
                   start: start,
                   end: end,
                   newLine: "",
                   font: "Comic Sans MS",
                   size: "18",
                   underline: "None",
                   align: "Left",
                   bold: default,
                   italic: default,
                   color: "Blue"
               );

            _wordHandler.SetRange(ref start, ref end);

            _wordHandler.AddTextBox(start, end, "txtEta");

            _wordHandler.AppendText("\n");


            // Combo box cantante

            _wordHandler.SetRange(ref start, ref end);

            _wordHandler.InsertText(
                    text: "Inserisci ",
                    start: start,
                    end: end,
                    newLine: "",
                    font: "Comic Sans MS",
                    size: "18",
                    underline: "None",
                    align: "Left",
                    bold: default,
                    italic: default,
                    color: "Blue"
                );

            _wordHandler.SetRange(ref start, ref end);

            _wordHandler.InsertText(
                    text: "cantante ",
                    start: start,
                    end: end,
                    newLine: "",
                    font: "Comic Sans MS",
                    size: "18",
                    underline: "Single",
                    align: "Left",
                    bold: default,
                    italic: default,
                    color: "Blue"
                );

            _wordHandler.SetRange(ref start, ref end);

            _wordHandler.InsertText(
                    text: "preferito: ",
                    start: start,
                    end: end,
                    newLine: "",
                    font: "Comic Sans MS",
                    size: "18",
                    underline: "None",
                    align: "Left",
                    bold: default,
                    italic: default,
                    color: "Blue"
                );


            _wordHandler.SetRange(ref start, ref end);

            _wordHandler.AddComboBox(start, end, "cmbCantanti", elencoCantanti);

            string path = $"{System.Windows.Forms.Application.StartupPath}\\Originale.docx";

            if(!File.Exists(path))
            {
                _wordHandler.SaveDocument(path);
            }
        }

        private void btnReadModuleData_Click(object sender, EventArgs e)
        {
            var files = new string[] { "s1.docx", "s2.docx", "s3.docx" };

            var singerAgePairs =new Dictionary<string, List<int>>();

            foreach(var file in files)
            {
                var path = $"{System.Windows.Forms.Application.StartupPath}\\{file}";
                if (File.Exists(path))
                {
                    _wordHandler.OpenDocument(path, MOSTRA_WORD);

                    var data = _wordHandler.ReadAllModulesData();

                    saveData(data, singerAgePairs);

                    _wordHandler.CloseDocument();
                }
            }

            writeDataOn(resumepath, singerAgePairs);

            btnOpenResume.Enabled = true;
            btnReadModuleData.Enabled = false;
        }

        private void writeDataOn(string path, Dictionary<string, List<int>> singerAgePairs)
        {
            object start = 0,
                   end = 0;
            
            _wordHandler.CreateDocument(MOSTRA_WORD);

            _wordHandler.InsertText(
                    text: "Riepilogo sondaggio",
                    start: 0,
                    end: 0,
                    newLine: "\n",
                    font: "Comic Sans MS",
                    size: "22",
                    underline: "None",
                    align: "Center",
                    bold: true,
                    italic: default,
                    color: "Red"
                );

            _wordHandler.SetRange(ref start, ref end);

            var table = _wordHandler.InsertTable(start, end, singerAgePairs.Count + 1, 3);

            _wordHandler.WriteTableCell(
                    table: table,
                    r: 1,
                    c: 1,
                    text: "Cantante"
                );

            _wordHandler.WriteTableCell(
                    table: table,
                    r: 1,
                    c: 2,
                    text: "Minore di 20"
                );

            _wordHandler.WriteTableCell(
                    table: table,
                    r: 1,
                    c: 3,
                    text: "Maggiore o uguale a 20"
                );

            int i = 2;
            foreach (var singerAgePair in singerAgePairs)
            {
                int peopleOlderThanTwenty = singerAgePair.Value.Count((age) => age >= 20);
                int peopleYoungerThanTwenty = singerAgePair.Value.Count - peopleOlderThanTwenty;

                _wordHandler.WriteTableCell(
                    table: table,
                    r: i,
                    c: 1,
                    text: singerAgePair.Key
                );

                _wordHandler.WriteTableCell(
                    table: table,
                    r: i,
                    c: 2,
                    text: peopleYoungerThanTwenty.ToString()
                );

                _wordHandler.WriteTableCell(
                    table: table,
                    r: i,
                    c: 3,
                    text: peopleOlderThanTwenty.ToString()
                );

                i++;
            }

            _wordHandler.SaveDocumentAndClose(path);
            _wordHandler.CloseApplication();
        }

        private void saveData(IReadOnlyDictionary<string, string> data, Dictionary<string, List<int>> destination)
        {
            if(!data.TryGetValue("txtEta",out string eta) || !data.TryGetValue("cmbCantanti", out string cantante))
            {
                return;
            }

            if(!int.TryParse(eta, out int age))
            {
                return;
            }

            if(destination.TryGetValue(cantante, out List<int> ages))
            {
                ages.Add(age);
            }
            else
            {
                destination.Add(cantante, new List<int> { age });
            }
        }

        private void btnOpenResume_Click(object sender, EventArgs e)
        {
            _wordHandler.OpenDocument(resumepath);
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            _wordHandler.CloseDocument();
            _wordHandler.CloseApplication();
        }
    }
}
