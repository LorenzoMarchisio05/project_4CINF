using ADOSQLServer2017_ns;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Es01_MasterDetailMVC.Controller
{
    internal class clsAlunniController
    {

        private readonly ADOSQLServer2017 _adonet;

        public clsAlunniController(string dbpath)
        {
            _adonet = new ADOSQLServer2017(dbpath);
        }

        internal DataTable caricaAlunni()
        {
            var command = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = @"SELECT * FROM ALUNNI;"
            };

            return _adonet.EseguiQuery(command);
        }
    }
}
