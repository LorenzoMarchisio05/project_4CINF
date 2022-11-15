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
    public partial class frmDestCostruttore : Form
    {
        TextBox txt;
        public frmDestCostruttore()
        {
            InitializeComponent();
        }
        public frmDestCostruttore(string message, TextBox risposta)
        {
            InitializeComponent();

            lblMsg.Text = message;

            txt = risposta;
        }

        private void frmDestCostruttore_FormClosing(object sender, FormClosingEventArgs e)
        {
            txt.Text = txtRisposta.Text;
        }
    }
}
