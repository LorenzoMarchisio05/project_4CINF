using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ES18_EreditarietaForm
{
    public partial class frmEditato : ES18_EreditarietaForm.frmBase
    {
        public frmEditato()
        {
            InitializeComponent();
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.TextBoxInput);
        }
    }
}
