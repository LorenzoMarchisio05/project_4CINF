using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es02_MultiForm
{
    public partial class frmPartenza : Form
    {
        public frmPartenza()
        {
            InitializeComponent();
        }

        private void btnApriFormFiglia_Click(object sender, EventArgs e)
        {
            frmFiglia f = new frmFiglia(); //istanzio la form
            MessageBox.Show("Sono prima della IF");
            //vedo se aprire la form in modale (bloccante)
            if(chkModale.Checked)
            {
                //bloccante NON posso accedere al form partenza
                //fino a quando non chiudo form Figlia
                //l'esecuzione del codice si ferma fino alla
                //chiusura di form Figlia
                f.Text = "Form Modale";
                f.ShowDialog();
            }
            else
            {
                //non bloccante posso accedere a form Partenza
                //e aprire un'altra form Figlia
                //l'esecuzione del codice continua
                f.Text = "Form NON Modale";
                f.Show();
            }
            MessageBox.Show("Sono dopo la IF");
        }

        private void frmPartenza_Load(object sender, EventArgs e)
        {
            chkMDI.Checked = false;
            btnApriFormMDI.Enabled = false;
        }

        private void chkMDI_CheckedChanged(object sender, EventArgs e)
        {
            btnApriFormMDI.Enabled = chkMDI.Checked;
            this.IsMdiContainer = chkMDI.Checked;
        }

        private void btnApriFormMDI_Click(object sender, EventArgs e)
        {
            frmFiglia f = new frmFiglia();
            f.MdiParent = this;
            f.Show();
        }
    }
}
