using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AdoNetSqlHandler
{
    public sealed class AdoNetSqlHandler
    {
        private SqlConnection connection;
       
        public AdoNetSqlHandler(string dbName)
        {
            this.connection = initConnection(dbName);
        }


        private SqlConnection initConnection(string dbName)
        {
            var connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\{dbName};Integrated Security=True;Connect Timeout=30";
            var connection = new SqlConnection
            {
                ConnectionString = connectionString,
            };
            
            connection.Open();

            return connection;
        }
        

        public DataTable ExecuteQuery(SqlCommand command)
        {
            command.Connection = this.connection;

            var dataTable = new DataTable();

            var adapter = new SqlDataAdapter(command);
            
            adapter.Fill(dataTable);
           
            return dataTable;
        }
        

        public DataTable ExecuteQuery(SqlCommand command, DataGridView dgv)
        {
            command.Connection = this.connection;

            var dataTable = new DataTable();

            var adapter = new SqlDataAdapter(command);
            
            adp.Fill(dataTable);
            dgv.DataSource = dataTable;
           
            return dataTable;
        }
       

        public int ExecuteNonQuery(SqlCommand command)
        {
            command.Connection = this.connection;
           
            return command.ExecuteNonQuery();
        }
        
        public object ExecuteScalar(SqlCommand command)
        {
            command.Connection = this.connection;
            
            return cmd.ExecuteScalar();
        }
    }
}