using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es07_Azienda
{
    public partial class Form1 : Form
    {

        private readonly clsAzienda azienda;
        public Form1()
        {
            InitializeComponent();
            azienda = new clsAzienda();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            try
            {
                clsOperaio operaio;
                if (azienda.tryGetOreSpecializzazione(txtOreSpecializzazione.Text, out string oreSpec))
                {
                    operaio = new clsOperaioSpecializzato(txtCognome.Text, txtNome.Text, txtOre.Text, oreSpec);
                }
                else
                {
                    operaio = new clsOperaio(txtCognome.Text, txtNome.Text, txtOre.Text); 
                }

                if (azienda.inserisci(operaio))
                {
                    azienda.visualizzaDgv(dgv);
                }
                else
                {
                    MessageBox.Show("Errore nell'Inserimento dell'operaio");
                }
            }
            catch (Exception ex)
            {
                IdGenerator.error();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count == 0) return;

            if(azienda.rimuovi())
            {
                MessageBox.Show("inserimento annullato con successo");
                azienda.visualizzaDgv(dgv);
            }
            else
            {
                MessageBox.Show("errore nell'annullamento dell'inserimento");
            }
            

        }

        private void btnStipendioTotale_Click(object sender, EventArgs e)
        {
            MessageBox.Show("stipendio totale: " + azienda.calcolaStipendioTotale().ToString());
        }

        private void btnCntOperaiSpecializzati_Click(object sender, EventArgs e)
        {
            MessageBox.Show("numero operai specializzati: " + azienda.contaOperaiSpecializzati().ToString());
        }

        private void btnNumeroOreSpecializzazione_Click(object sender, EventArgs e)
        {
            MessageBox.Show("numero ore specializzazione: " + azienda.contaOreSpecializzazione());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rimuoviDipendente(e.RowIndex);
        }

        private void rimuoviDipendente(int riga)
        {
            try
            {
                if (
                MessageBox.Show(
                    $"Vuoi davvero eliminare il dipendente\n{azienda.getDipendente(riga).visualizza()}",
                    "Rimuovi dipendente",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (azienda.rimuovi(riga))
                    {
                        azienda.visualizzaDgv(dgv);
                    }
                }
            } catch(Exception ex)
            {

            }
            
        }
    }
}
