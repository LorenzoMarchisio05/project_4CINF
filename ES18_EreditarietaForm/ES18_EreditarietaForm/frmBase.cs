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
    public partial class frmBase : Form
    {
        
        private bool annulla = true;

        public string LabelInputText
        {
            set => lblTesto.Text = value ?? throw new ArgumentNullException("text label can't be null"); 
        }

        public string TextBoxInput 
        { 
            get => txtTesto.Text; 
            set => txtTesto.Text = value ?? throw new ArgumentNullException("textbox text can't be null"); 
        }


        public frmBase()
        {
            InitializeComponent();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            TextBoxInput = "";
            this.Close();
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            annulla = false;
            this.Close();
        }

        private void frmBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(annulla)
            {
                TextBoxInput = "";
            }
        }
    }
}
