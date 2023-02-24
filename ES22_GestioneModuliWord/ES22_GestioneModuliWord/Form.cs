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

            _wordHandler.AppendText("Nome: ");

            _wordHandler.SetRange(ref start, ref end);

            _wordHandler.AddTextBox(start, end, "txtNome");

            _wordHandler.SetRange(ref start, ref end);

            _wordHandler.AppendText("\nMaggiorenne: ");

            _wordHandler.AddChekBox(start, end, "chkMaggiorenne");

            _wordHandler.AppendText("\nMaggiorenne: ");

            _wordHandler.AddComboBox(start, end, "cmbNazionalita", new string[] { "apolide", "italiano", "inglese"} );
        }
    }
}
