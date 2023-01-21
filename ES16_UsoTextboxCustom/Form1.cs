using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES16_UsoTextboxCustom
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void chkSoloNumeri_CheckedChanged(object sender, EventArgs e)
        {
            ucTextBox1.Numero = chkSoloNumeri.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucTextBox1.Pulisci();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucTextBox1.Minuscolo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ucTextBox1.Maiuscolo();
        }
    }
}
