using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es06_EditorHTML
{
    public partial class TableForm : Form
    {
        private int righe;
        private int colonne;

        public int Righe 
        { 
            get => righe; 
            set => righe = value; 
        }

        public int Colonne
        {
            get => colonne;
        }

        private void setColonne(string col)
        {
            if (!int.TryParse(col, out int colonne) || colonne <= 0) throw new Exception("invalid column count");

            this.colonne = colonne;
        }

        private void setRighe(string r)
        {
            if (!int.TryParse(r, out int righe) || righe <= 0) throw new Exception("invalid row count");

            this.righe = righe;
        }

        public TableForm()
        {
            InitializeComponent();
        }

        private void btnCreaTabella_Click(object sender, EventArgs e)
        {
            try
            {
                setColonne(txtNumeroColonne.Text);
                setRighe(txtNumeroRighe.Text);

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
