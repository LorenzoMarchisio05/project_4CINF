using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES04_passaggioDatiFormProperty
{
    public partial class frmDestinazione : Form
    {
        private string testoTextBox;
        private string testoLabel;
        private bool annulla;

        public string TestoTextBox
        {
            get
            {
                testoTextBox = handleTextChange(txtTesto.Text);
                return testoTextBox;
            }
            set
            {
                testoTextBox = value;
                txtTesto.Text = testoTextBox;
            }
        }

        private string handleTextChange(string text)
        {
            text = text.Trim();
            if(text.Length < 3)
            {
                throw new ArgumentException("too short message");
            }

            return text;
        }

        public string TestoLabel
        {
            set
            {
                testoLabel = value;
                lblMsg.Text = testoLabel;
            }
        }
        public bool Annulla
        {
            get => annulla;
            set
            {
                annulla = value;
                if (annulla)
                {
                    TestoTextBox = "";
                }
            }
        }


        public frmDestinazione()
        {
            InitializeComponent();
        }

        private void frmDestinazione_Load(object sender, EventArgs e)
        {
            Annulla = false;
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            Annulla = true;
            this.Close();
        }
    }
}
