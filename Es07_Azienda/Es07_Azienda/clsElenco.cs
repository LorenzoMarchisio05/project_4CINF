using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es07_Azienda
{
    public sealed class clsElenco
    {
        private readonly List<clsOperaio> listaOperai;

        public clsElenco()
        {
            listaOperai = new List<clsOperaio>();
        }

        public void visualizzaDgv(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.DataSource = listaOperai;
        }

        public bool inserisci(clsOperaio operaio)
        {
            bool esito;
            try
            {
                listaOperai.Add(operaio);
                esito = true;
            }
            catch(Exception ex)
            {
                esito = false;
            }
            return esito;
        }
    }
}
