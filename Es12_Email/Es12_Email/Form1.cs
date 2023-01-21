using Es12_Email.Controllers;
using Es12_Email.Entity;
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

namespace Es12_Email
{
    public partial class FrmMain : Form
    {

        private static Dizionario dizionario = new Dizionario();
        private static Lista lista;
        public FrmMain()
        {
            InitializeComponent();

            lista = new Lista(dgv, dizionario);

            lista.InsertionSuccess += new Lista.messageDelegate(lista_InsertionSuccess);

            try
            {
                cmbContatti.Items.AddRange(dizionario.LeggiFile("Contatti.txt").ToArray());

            }
            catch (Exception)
            {
            }
        }

        private void lista_InsertionSuccess(string message)
        {
            MessageBox.Show(message);
        }

        private void btnAggiungiEmail_Click(object sender, EventArgs e)
        {
            try
            {
                Email email = new Email(
                        txtEmail.Text,
                        txtTitoloDocumento.Text,
                        txtPathDocumento.Text,
                        txtNome.Text,
                        txtOggetto.Text
                    );
                lista.insert(email);
                pulisciCampi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void pulisciCampi()
        {
            
            foreach(TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Text = "";
            }

            chkAllegato.Checked = false;
            cmbContatti.SelectedItem = null;
        }

        private void chkAllegato_CheckedChanged(object sender, EventArgs e)
        {
            if(chkAllegato.Checked)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = false;
                openFileDialog.Title = "Seleziona file";
                openFileDialog.Filter = "(*.txt) | *.txt";
                
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtTitoloDocumento.Text = openFileDialog.FileName.Substring(openFileDialog.FileName.LastIndexOf("\\")+1);
                    txtPathDocumento.Text = openFileDialog.FileName;
                }
                
            }
        }


        private void cmbContatti_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] data = cmbContatti.Text.Split('-');
            if (data.Length == 0)
            {
                return;
            }
            txtNome.Text = data[0];
            txtEmail.Text = data[1];
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            dizionario.SalvaSuFile();
        }

        
    }
}
