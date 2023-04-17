using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Dynamic;

namespace Es27_ADONET01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private static SqlConnection connection;
        private static SqlCommand command;
        private static SqlDataAdapter adapter;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var dbname = "DB_4C_2023.mdf";
            var connectionString = $@"Data Source = (LocalDB)\MSSQLLocalDB;
                                      AttachDbFilename = '{Application.StartupPath}\{dbname}'; 
                                      Integrated Security = True; 
                                      Connect Timeout = 30";

            connection = ConnectToDatabase(connectionString);

            LoadSubjectsToComboBox(cmbSubjects);
        }

        private void LoadSubjectsToComboBox(ComboBox cmb)
        {
            if (connection is null)
            {
                MessageBox.Show("No DB connection");
                return;
            }

            try
            {
                command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = @"SELECT IDMATERIA, MATERIA FROM MATERIE"
                };

                var subjects = ExecuteCommandToDataTable(command);

                cmb.DataSource = subjects;
                cmb.DisplayMember = "MATERIA";
                cmb.ValueMember = "IDMATERIA";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore esecuzione query: {ex.Message}");
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        { 
            connection?.Close();
        }

        private SqlConnection ConnectToDatabase(string connectionString)
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                
                MessageBox.Show("Connessione effettuata con successo");

                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore connessione DB: {ex.Message}");
            }

            return null;
        }

        private void btnCountStudents_Click(object sender, EventArgs e)
        {
            if (connection is null)
            {
                MessageBox.Show("No DB connection");
                return;
            }

            try
            {
                command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = @"SELECT COUNT(*) FROM ALUNNI"
                };

                var studentsCount = (int)command.ExecuteScalar();

                MessageBox.Show($"Sono presenti {studentsCount} studenti");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Errore esecuzione query: {ex.Message}");
            }
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            if (connection is null)
            {
                MessageBox.Show("No DB connection");
                return;
            }

            try
            {
                command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = @"SELECT * FROM ALUNNI"
                };

                var students = ExecuteCommandToDataTable(command);

                dgv.DataSource = null;
                dgv.DataSource = students;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore esecuzione query: {ex.Message}");
            }

        }


        private DataTable ExecuteCommandToDataTable(SqlCommand command)
        {
            var data = new DataTable();

            var adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            return data;
        }

        private void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = cmbSubjects.SelectedValue;

            if (connection is null)
            {
                MessageBox.Show("No DB connection");
                return;
            }

            try
            {
                command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = $@"SELECT * FROM VOTI WHERE IdAlunno = {id}"
                };

                var marks = ExecuteCommandToDataTable(command);

                dgv.DataSource = null;
                dgv.DataSource = marks;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore esecuzione query: {ex.Message}");
            }
        }
    }
}
