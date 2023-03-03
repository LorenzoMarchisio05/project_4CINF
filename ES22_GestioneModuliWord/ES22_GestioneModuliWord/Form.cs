using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Es20_WordCSharp;
using Microsoft.Office.Interop.Word;
using WordCSharp;

namespace ES22_GestioneModuliWord
{
    public partial class Form : System.Windows.Forms.Form
    {

        private readonly WordHandler _wordHandler;
        public Form()
        {
            InitializeComponent();

            _wordHandler = new WordHandler();
        }

        private void BtnCreaModulo_Click(object sender, EventArgs e)
        {
            _wordHandler.CreateDocument();

            object start = 0,
                   end = 0;

            _wordHandler.InsertText("Nome: ", 0, 0);

            _wordHandler.SetRange(ref start, ref end);

            _wordHandler.AddTextBox(start, end, "txtNome");

            _wordHandler.SetRange(ref start, ref end);



            _wordHandler.InsertText("\nMaggiorenne: ", start, end);

            _wordHandler.SetRange(ref start, ref end);

            _wordHandler.AddChekBox(start, end, "chkMaggiorenne");

            _wordHandler.SetRange(ref start, ref end);


            _wordHandler.InsertText("\nNazionalità: ", start, end);

            _wordHandler.SetRange(ref start, ref end);

            _wordHandler.AddComboBox(start, end, "cmbNazionalita", new Dictionary<string, string>() { { "1", "italiano"}, { "2", "inglese"}, { "3", "apolide"} });

            _wordHandler.SetRange(ref start, ref end);


            _wordHandler.ProtectDocument("password");
        }

        private void btnLeggiDatiModulo_Click(object sender, EventArgs e)
        {
            var data = _wordHandler.ReadAllModulesData();

            foreach(var titleDataPairs in data)
            {
                MessageBox.Show(titleDataPairs.Value);
            }

            MessageBox.Show(_wordHandler.ReadDataByName("chkMaggiorenne"));

        }
    }
}
