using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES05_giocoCarte
{
    public partial class Form1 : Form
    {
        private clsMazzoCarte mazzo { get; }
        public Form1()
        {
            InitializeComponent();
            mazzo = new clsMazzoCarte();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            mazzo.visualizzaMazzo(dgv);
        }

        private void btnProponi_Click(object sender, EventArgs e)
        {
            (string seme , string valore) = clsCarta.Proponi();

            txtSeme.Text = seme.ToLower();

            txtValore.Text = valore.ToLower();
            
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            try
            {
                mazzo.inserisciCarta(new clsCarta(
                    txtSeme.Text,
                    txtValore.Text
                ));
                mazzo.visualizzaMazzo(dgv);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnTotali_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> cartePerSeme = mazzo.totali();

            StringBuilder sb = new StringBuilder();

            var keys = cartePerSeme.Keys;

            foreach (string key in keys)
            {
                cartePerSeme.TryGetValue(key, out int count);
                sb.Append(key).Append(": ").Append(count).Append("\n");
            }

            MessageBox.Show(sb.ToString());
        }

        private void btnMescola_Click(object sender, EventArgs e)
        {
            mazzo.mescolaCarte();
            mazzo.visualizzaMazzo(dgv);
        }

        private void btnDammiCarta_Click(object sender, EventArgs e)
        {
            clsCarta carta = mazzo.dammiCarta();

            MessageBox.Show(carta.ToString());
        }
    }
}
