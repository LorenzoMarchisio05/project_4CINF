using Es12_Interfacce.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Es12_Interfacce.Entity;

namespace Es12_Interfacce
{
    public partial class frmMain : Form
    {

        

        public frmMain()
        {
            InitializeComponent();

            Iscritto.Scaduta += Iscritto_GiaPresente;
        }

        private void Iscritto_GiaPresente(string message)
        {
            MessageBox.Show(message);
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            Iscritto iscritto = new Iscritto(
                txtNome.Text,
                txtCognome.Text,
                txtCodiceCarta.Text,
                txtComune.Text,
                dtDataRilascio.Value.ToShortDateString()
            );


            iscritto.aggiungiAllaLista();

            Iscritto.visualizzaDgv(dgvIscritto);
            
        }
    }
}
