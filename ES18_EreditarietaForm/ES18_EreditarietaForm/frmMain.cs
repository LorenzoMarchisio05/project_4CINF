using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES18_EreditarietaForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLancia_Click(object sender, EventArgs e)
        {
            var form = new frmEditato { LabelInputText = "Inserisci Username" };

            form.ShowDialog();
            MessageBox.Show(form.TextBoxInput);
        }
    }
}
