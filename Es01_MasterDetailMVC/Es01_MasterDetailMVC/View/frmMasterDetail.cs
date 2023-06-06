using Es01_MasterDetailMVC.Controller;
using Es01_MasterDetailMVC.Controller;
using Es01_MasterDetailMVC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
            txtIdAlunno.ReadOnly = false;
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
            try
            {
                dgvAlunni.DataSource = null;
                dgvAlunni.DataSource = cAlunni.caricaAlunni();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        
        private void dgvAlunni_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string idAlunno = dgvAlunni.Rows[e.RowIndex].Cells[0].Value.ToString();
            caricaAlunno(idAlunno);
        }

        private void caricaAlunno(string idAlunno)
        {
            try
            {
                var alunno = cAlunni.cercaAlunno(idAlunno);

                txtIdAlunno.Text = alunno.IdAlunno.ToString();
                txtNome.Text = alunno.Nome;
                txtCognome.Text = alunno.Cognome;
                txtCitta.Text = alunno.Citta;
                dtpDataNascita.Value = alunno.DataNascita;
                nudAltezza.Value = alunno.Altezza;
                chkInglese.Checked = alunno.Inglese;
                txtTelefono.Text = alunno.Telefono;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            var alunno = new clsAlunni
            {
                IdAlunno = int.Parse(txtIdAlunno.Text.Trim()),
                Nome = txtNome.Text.Trim(),
                Cognome = txtCognome.Text.Trim(),
                Citta = txtCitta.Text.Trim(),
                DataNascita = dtpDataNascita.Value,
                Altezza = (int)nudAltezza.Value,
                Inglese = chkInglese.Checked,
                Telefono = txtTelefono.Text
            };

            if(txtIdAlunno.Text.Trim() == "")
            {
                var id = cAlunni.inserisciAlunno(alunno);

                dgvAlunni.Rows.Add(alunno);

                MessageBox.Show($"Addedd alunno {id}");
            }
            else
            {
                var esito = cAlunni.modificaAlunno(alunno);

                if(esito)
                {
                    caricaDgv();

                    MessageBox.Show($"Edited alunno {alunno.IdAlunno}");
                }
            }

        }

        private void btnCancella_Click(object sender, EventArgs e)
        {
            var esito = cAlunni.eliminaAlunno(txtIdAlunno.Text);

            if (esito)
            {
                caricaDgv();

                MessageBox.Show($"deleted alunno {txtIdAlunno.Text.Trim()}");
            }
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
