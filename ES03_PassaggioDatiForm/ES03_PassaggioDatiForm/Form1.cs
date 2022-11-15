using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES03_PassaggioDatiForm
{
    public partial class frmPartenza : Form
    {
        public frmPartenza()
        {
            InitializeComponent();
        }

        private void btnDestCostruttore_Click(object sender, EventArgs e)
        {
            frmDestCostruttore f = new frmDestCostruttore(txtMessaggio.Text, txtRisposta);

            f.ShowDialog();
        }

    }
}
