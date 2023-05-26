using Es01_MasterDetailMVC.Controller;
using Es01_MasterDetailMVC.Controller;
using Es01_MasterDetailMVC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Detail_MVC
{
    public partial class frmMasterDetail : Form
    {
        clsAlunniController cAlunni;
        public frmMasterDetail()
        {
            InitializeComponent();
        }

        private void frmMasterDetail_Load(object sender, EventArgs e)
        {
            //imposto limiti altezza e data nascita
            nudAltezza.Minimum = 101;
            nudAltezza.Maximum = 299;
            int anno;
            anno= DateTime.Now.Year - 50;
            dtpDataNascita.MinDate = Convert.ToDateTime("01/01/" + anno.ToString());
            anno = DateTime.Now.Year - 15;
            dtpDataNascita.MaxDate = Convert.ToDateTime("31/12/" + anno.ToString());
            //
            try
            {
                cAlunni = new clsAlunniController(@"App_Data\DB_4C_2023.mdf");
                caricaDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
        private void caricaDgv()
        {
            dgvAlunni.DataSource = cAlunni.caricaAlunni();
        }

        
        private void dgvAlunni_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string idAlunno = dgvAlunni.Rows[e.RowIndex].Cells[0].Value.ToString();
            caricaAlunno(idAlunno);
        }

        private void caricaAlunno(string idAlunno)
        {
            
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancella_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNuovoAlunno_Click(object sender, EventArgs e)
        {
            txtIdAlunno.Clear();
            txtCognome.Clear();
            txtNome.Clear();
            txtCitta.Clear();
            dtpDataNascita.Value = dtpDataNascita.MinDate;
            nudAltezza.Value = nudAltezza.Minimum;
            chkInglese.Checked = false;
            txtTelefono.Clear();
        }
    }
}
