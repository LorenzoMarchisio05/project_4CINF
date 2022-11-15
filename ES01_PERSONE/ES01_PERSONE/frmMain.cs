using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ES01_PERSONE
{
    public partial class frmMain : Form
    {

        private static clsElenco elenco { get;  }  = new clsElenco();
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] nomi = { "Nome", "Cognome", "DataDiNascita" };
            for (int i = 0; i < 3; i++)
            {
                TextBox txtBox = new TextBox();

                txtBox.Name = "txt" + nomi[i];

                txtBox.Location = new Point(100, 50 * (i + 1));

                Controls.Add(txtBox);
            }
        }


        private void btnInserimento_Click(object sender, EventArgs e)
        {
            clsPersona persona = new clsPersona();
            try
            {
                string nome = ((TextBox)Controls["txtNome"]).Text;
                string cognome = ((TextBox)Controls["txtCognome"]).Text;
                DateTime data = Convert.ToDateTime(((TextBox)Controls["txtDataDiNascita"]).Text);

                persona = new clsPersona(cognome , nome , data);

                elenco.aggiungiPersona(persona);
                elenco.visualizzaElenco(dgvElenco);

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRicercaPerCognome_Click(object sender, EventArgs e)
        {
            try
            {
                string cognome;
                do
                {
                    cognome = Interaction.InputBox("inserisci il cognome");
                }
                while (string.IsNullOrWhiteSpace(cognome) || cognome.Trim().Length < 2);
                MessageBox.Show(elenco.ricerca(cognome));

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRicercaPerAnno_Click(object sender, EventArgs e)
        {
            try
            {
                string anno;
                do
                {
                    anno = Interaction.InputBox("inserisci l'anno").Trim();
                }
                while (anno.Length != 4 || anno == "" || string.IsNullOrWhiteSpace(anno));
                int.TryParse(anno, out int annoToInt);
                MessageBox.Show(elenco.ricerca(annoToInt));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvElenco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int riga = e.RowIndex;
           
            MessageBox.Show(elenco.trovaPersonaPerIndice(riga)?.calcolaEta().ToString());
        }
    }
}
