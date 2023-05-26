using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AdoNet.Controller
{
    internal sealed class AdoNetDBController
    {
        private string connectionString;
        //
        //public ADOSQLServer2015()
        //{ }
        /// <summary>
        /// Classe di accesso a DB SQLServer
        /// </summary>
        /// <param name="dbName">Nome del DB</param>
        public AdoNetDBController(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Esegue una query che ritorna un dataTable
        /// </summary>
        /// <param name="cmd">Comando Query</param>
        /// <returns>dataTable</returns>
        public DataTable EseguiQuery(SqlCommand cmd)
        {
            using (var cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlDataAdapter adp;
                cmd.Connection = cn;
                DataTable dt = new DataTable();
                adp = new SqlDataAdapter(cmd);
                try
                {
                    adp.Fill(dt);
                }
                catch (Exception)
                {
                    throw;
                }
                return dt;
            }
        }
        //overload
        /// <summary>
        /// Esegue una query che ritorna un dataTable e popola una dataGridView
        /// </summary>
        /// <param name="cmd">Comando Query</param>
        /// <param name="dgv">dataGridView</param>
        /// <returns>dataTable</returns>
        public DataTable EseguiQuery(SqlCommand cmd, DataGridView dgv)
        {
            using (var cn = new SqlConnection(connectionString))
            {
                cmd.Connection = cn;
                DataTable dt = new DataTable();
                var adp = new SqlDataAdapter(cmd);
                try
                {
                    adp.Fill(dt);
                    dgv.DataSource = dt;
                }
                catch (Exception)
                {
                    throw;
                }
                return dt;
            }
        }
        /// <summary>
        /// Esegue Query che non ritornano dataTable
        /// </summary>
        /// <param name="cmd">Comando Query</param>
        /// <returns>Numero di record modificati</returns>
        public int EseguiNonQuery(SqlCommand cmd)
        {
            using (var cn = new SqlConnection(connectionString))
            {
                cmd.Connection = cn;
                try
                {
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        /// <summary>
        /// Esegue Query che ritornano un singolo valore
        /// </summary>
        /// <param name="cmd">Comando Query</param>
        /// <returns>Valore</returns>
        public object EseguiScalar(SqlCommand cmd)
        {
            using (var cn = new SqlConnection(connectionString))
            {
                object ris = -1;
                cmd.Connection = cn;
                try
                {
                    ris = cmd.ExecuteScalar();
                }
                catch (Exception)
                {
                    throw;
                }
                return ris;
            }
        }
    }
}
