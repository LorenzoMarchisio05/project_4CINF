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
            var dbname = "DB_4C_2023.mdf";
            var connectionString = $@"Data Source = (LocalDB)\MSSQLLocalDB;
                                      AttachDbFilename = '{Application.StartupPath}\{dbname}'; 
                                      Integrated Security = True; 
                                      Connect Timeout = 30";

            connection = ConnectToDatabase(connectionString);
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
            if(connection is null)
            {
                MessageBox.Show("No DB connection");
                return;
            }

            try
            {
                command = connection.CreateCommand();

                command.CommandType = CommandType.Text;

                command.CommandText = @"SELECT COUNT(*) FROM ALUNNI";

                var studentsCount = (int)command.ExecuteScalar();

                MessageBox.Show($"Sono presenti {studentsCount} studenti");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Errore esecuzione query: {ex.Message}");
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection?.Close();
        }
    }
}
