using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es16_TextBoxPersonalizzata
{
    public partial class UCTextBox : UserControl
    {

        public bool Numero { get; set; }
        public string Testo 
        {
            get => txtTesto.Text; 
            set => txtTesto.Text = value; 
        }

        public UCTextBox()
        {
            InitializeComponent();
        }

        public void Maiuscolo()
        {
            this.Testo = this.Testo.ToUpper();
        }

        public void Minuscolo()
        {
            this.Testo = this.Testo.ToLower();
        }

        public void Pulisci()
        {
            this.Testo = "";
        }

        private void txtTesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Numero && !char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
