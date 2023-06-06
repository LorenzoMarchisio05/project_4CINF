using ADOSQLServer2017_ns;
using System;
using Es01_MasterDetailMVC.Model;
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
                CommandText = @"SELECT * FROM ALUNNI ORDER BY COGNOME, NOME;"
            };

            return _adonet.EseguiQuery(command);
        }

        internal clsAlunni cercaAlunno(string id)
        {
            var command = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = @"SELECT * FROM ALUNNI WHERE idAlunno = @idAlunno;"
            };

            if(!int.TryParse(id, out var idAlunno))
            {
                throw new InvalidCastException($"Invalid id {id}");
            }

            command
                .Parameters
                .Add(new SqlParameter("@idAlunno", SqlDbType.Int) { Value = id });

            var dataTable = _adonet.EseguiQuery(command);

            if(dataTable.Rows.Count == 0)
            {
                throw new Exception($"No match on {id}");
            }

            var alunno = dataTable.Rows[0];

            return new clsAlunni
            {
                IdAlunno = idAlunno,
                Nome = alunno[1].ToString(),
                Cognome = alunno[2].ToString(),
                Citta = alunno[3].ToString(),
                DataNascita = Convert.ToDateTime(alunno[4]),
                Altezza = Convert.ToInt32(alunno[5]),
                Inglese = Convert.ToBoolean(alunno[6]),
                Telefono = alunno[7].ToString()
            };
        }

        internal bool eliminaAlunno(string id)
        {
            var command = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = @"DELETE FROM ALUNNI 
                                WHERE idAlunno = @idAlunno;"
            };

            if (!int.TryParse(id, out var idAlunno))
            {
                throw new InvalidCastException($"Invalid id {id}");
            }

            command
                .Parameters
                .Add(new SqlParameter("@idAlunno", SqlDbType.Int) { Value = idAlunno });

            return _adonet.EseguiNonQuery(command) != 0;
        }

        internal int inserisciAlunno(clsAlunni alunno)
        {
            var command = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = @"INSERT INTO ALUNNI
                                (nome, cognome, citta, dataNascita, altezza, inglese, telefono)
                                VALUES
                                (@nome, @cognome, @citta, @dataNascita, @altezza, @inglese, @telefono);
                                SELECT SCOPE_IDENTITY();"
            };

            command
                .Parameters
                .AddRange(new SqlParameter[]
                {
                    new SqlParameter("@nome", SqlDbType.VarChar) { Value = alunno.Nome },
                    new SqlParameter("@cognome", SqlDbType.VarChar) { Value = alunno.Cognome },
                    new SqlParameter("@citta", SqlDbType.VarChar) { Value = alunno.Citta },
                    new SqlParameter("@dataNascita", SqlDbType.Date) { Value = alunno.DataNascita },
                    new SqlParameter("@altezza", SqlDbType.Int) { Value = alunno.Altezza },
                    new SqlParameter("@inglese", SqlDbType.Bit) { Value = alunno.Inglese ? 1 : 0 },
                    new SqlParameter("@telefono", SqlDbType.VarChar) { Value = alunno.Telefono }
                });

            return (int)_adonet.EseguiScalar(command);
        }

        internal bool modificaAlunno(clsAlunni alunno)
        {
            var command = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = @"UPDATE ALUNNI SET 
                                    nome = @nome,
                                    cognome = @cognome,
                                    citta = @citta,
                                    dataNascita = @dataNascita, 
                                    altezza = @altezza, 
                                    inglese = @inglese, 
                                    telefono = @telefono
                                WHERE idAlunno = @id;"
            };

            command
                .Parameters
                .AddRange(new SqlParameter[]
                {
                    new SqlParameter("@id", SqlDbType.Int) { Value = alunno.IdAlunno },
                    new SqlParameter("@nome", SqlDbType.VarChar) { Value = alunno.Nome },
                    new SqlParameter("@cognome", SqlDbType.VarChar) { Value = alunno.Cognome },
                    new SqlParameter("@citta", SqlDbType.VarChar) { Value = alunno.Citta },
                    new SqlParameter("@dataNascita", SqlDbType.Date) { Value = alunno.DataNascita },
                    new SqlParameter("@altezza", SqlDbType.Int) { Value = alunno.Altezza },
                    new SqlParameter("@inglese", SqlDbType.Bit) { Value = alunno.Inglese ? 1 : 0 },
                    new SqlParameter("@telefono", SqlDbType.VarChar) { Value = alunno.Telefono }
                });

            return  _adonet.EseguiNonQuery(command) != 0;
        }
    }
}
