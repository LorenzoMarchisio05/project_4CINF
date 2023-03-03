using Es20_WordCSharp;
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

        private readonly WordHandler _wordHandler;

        private Dictionary<string, string> singerAgePairs;
        public Form()
        {
            InitializeComponent();

            _wordHandler = new WordHandler();

            singerAgePairs = new Dictionary<string, string>();
        }

        private void btnCreateModuleTemplate_Click(object sender, EventArgs e)
        {
            _wordHandler.CreateDocument();

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
                    color: "DarkRed"
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
                   text: "età: ",
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


            // _wordHandler.SaveDocument(Application.StartupPath + "\\prova.docx");
        }

        private void btnReadModuleData_Click(object sender, EventArgs e)
        {
            var files = new string[] { "s1.docx", "s2.docx", "s3.docx" };

            foreach(var file in files)
            {
                var path = Application.StartupPath + $"\\{file}";
                if(File.Exists(path))
                {
                    _wordHandler.OpenDocument(path);

                    var data = _wordHandler.ReadAllModulesData();

                    saveData(data);

                    _wordHandler.CloseDocument();
                }
            }
        }

        private void saveData(IReadOnlyDictionary<string, string> data)
        {
            foreach (var keyvaluepair in data)
            {
                MessageBox.Show($"{keyvaluepair.Key}: {keyvaluepair.Value}");
            }
        }
    }
}
