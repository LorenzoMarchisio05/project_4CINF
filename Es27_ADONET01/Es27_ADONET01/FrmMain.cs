using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Es27_ADONET01
{
    public partial class FrmMain : Form
    {

        private readonly SqlConnection connection;
        public FrmMain()
        {
            InitializeComponent();

            var dbname = "DB_4C_2023.mdf";
            var connectionString = $@"Data Source = (LocalDB)\MSSQLLocalDB;
                                      AttachDbFilename = '{Application.StartupPath}\{dbname}'; 
                                      Integrated Security = True; 
                                      Connect Timeout = 30";

            connection = ConnectToDatabase(connectionString);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadSubjectsToComboBox(cmbSubjects);

            LoadStudentsToComboBox(cmbStudents);
        }

        private void LoadStudentsToComboBox(ComboBox cmb)
        {
            if (connection is null)
            {
                MessageBox.Show("No DB connection");
                return;
            }

            try
            {
                var command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = @"SELECT idALUNNO, UPPER(nome + ' ' + cognome) as nominativo 
                                    FROM ALUNNI 
                                    ORDER BY cognome, nome;"
                };

                var subjects = ExecuteCommandToDataTable(command);

                cmb.DataSource = subjects;
                cmb.DisplayMember = "nominativo";
                cmb.ValueMember = "idALUNNO";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore esecuzione query: {ex.Message}");
            }
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
                var command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = @"SELECT IDMATERIA, MATERIA 
                                    FROM MATERIE;"
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
                var command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = @"SELECT COUNT(*) 
                                    FROM ALUNNI;"
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
                var command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = @"SELECT * 
                                    FROM ALUNNI;"
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

        private void btnInsertMark_Click(object sender, EventArgs e)
        {
            if (connection is null)
            {
                MessageBox.Show("No DB connection");
                return;
            }

            var voto = nudMark.Value;
            var idAlunno = Convert.ToInt32(cmbStudents.SelectedValue);
            var idMateria = cmbSubjects.SelectedValue.ToString();

            try
            {
                
                var command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = @"INSERT INTO VOTI 
                                    (Voto, idAlunno, idMateria)
                                    VALUES
                                    (@voto, @idAlunno, @idMateria);"
                };

                command.Parameters.AddRange(
                    new SqlParameter[]
                    {
                        new SqlParameter("@voto", SqlDbType.Float) { Value = voto},
                        new SqlParameter("@idAlunno", SqlDbType.Int) { Value = idAlunno },
                        new SqlParameter("@idMateria", SqlDbType.VarChar, 50) { Value = idMateria }
                    });

                command.Prepare();

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore esecuzione query: {ex.Message}");
            }
        }

        private void btnShowMarks_Click(object sender, EventArgs e)
        {
            if (connection is null)
            {
                MessageBox.Show("No DB connection");
                return;
            }

            try
            {
                var command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = @"SELECT * 
                                    FROM VOTI;"
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

        private void btnInserMarkWithPK_Click(object sender, EventArgs e)
        {
            if (connection is null)
            {
                MessageBox.Show("No DB connection");
                return;
            }

            var voto = nudMark.Value;
            var idAlunno = Convert.ToInt32(cmbStudents.SelectedValue);
            var idMateria = cmbSubjects.SelectedValue.ToString();

            try
            {
                var command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = @"INSERT INTO VOTI 
                                    (Voto, idAlunno, idMateria)
                                    VALUES
                                    (@voto, @idAlunno, @idMateria);
                                    SELECT SCOPE_IDENTITY();"
                };

                command
                    .Parameters
                    .AddRange(
                        new SqlParameter[]
                        {
                            new SqlParameter("@voto", SqlDbType.Float) { Value = voto},
                            new SqlParameter("@idAlunno", SqlDbType.Int) { Value = idAlunno },
                            new SqlParameter("@idMateria", SqlDbType.VarChar, 50) { Value = idMateria }
                        });

                command.Prepare();

                var id = command.ExecuteScalar();

                MessageBox.Show($"Id Assegnato: {id}");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore esecuzione query: {ex.Message}");
            }
        }
    }
}
