using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES09_PRODOTTI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkBox1.Checked = true;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMarche.DataSource = new string[]
            {
                "gucci",
                "tim",
                "Enel",
                "Kinder",
                "Ferrari",
                "Prada",
                "Eni"
            };
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(((CheckBox)sender).Checked)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
            }
            else
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
            }
        }
    }
}
