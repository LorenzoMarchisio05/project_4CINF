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
    public sealed class clsAzienda
    {
        private readonly List<clsOperaio> listaOperai;

        public clsAzienda()
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

        public bool rimuovi()
        {
            bool esito;
            try
            {
                listaOperai.RemoveAt(listaOperai.Count - 1);
                esito = true;
            }
            catch (Exception ex)
            {
                esito = false;
            }

            return esito;

        }

        public bool rimuovi(int index)
        {
            bool esito;
            try
            {
                listaOperai.RemoveAt(index);
                esito = true;
            }
            catch (Exception ex)
            {
                esito = false;
            }
            return esito;
        }

        public clsOperaio getDipendente(int index) => listaOperai[index];

        public bool tryGetOreSpecializzazione(string source, out string oreSpec) => (oreSpec = source.Trim()).Length > 0;

        public int contaOperaiSpecializzati() => listaOperai.OfType<clsOperaioSpecializzato>()?.Count() ?? 0;

        public int contaOreSpecializzazione() => (int)listaOperai.OfType<clsOperaioSpecializzato>().Sum((operaio) => long.Parse(operaio.OreSpecializzate));

        public double calcolaStipendioTotale() => listaOperai.Sum(op => op.calcolaStipendio());
    }
}
