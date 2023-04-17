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
            var connectionString = $@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = '{Application.StartupPath}\{dbname}'; Integrated Security = True; Connect Timeout = 30";


        }
    }
}
