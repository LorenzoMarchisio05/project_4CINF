using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ES09_PRODOTTI
{
    public sealed class clsDispensa
    {
        private readonly List<clsProdotto> listaProdotti;

        public clsDispensa()
        {
            listaProdotti = new List<clsProdotto>();
        }

        public bool add(clsProdotto prodotto)
        {
            bool status = true;
            try
            {
                listaProdotti.Add(prodotto);
            }
            catch(Exception)
            {
                status = false;
            }
            return status;
        }

        public bool remove(int index)
        {
            bool status = true;
            try
            {
                listaProdotti.RemoveAt(index);
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }
        
        public bool remove()
        {
            bool status = true;
            try
            {
                listaProdotti.RemoveAt(listaProdotti.Count - 1);
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }

        public void visualizzaDGV(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.DataSource = listaProdotti;
        }
        public int contaProdottiAlimentariScaduti<T>() where T : clsProdotto => listaProdotti.OfType<T>().Count(p => p.scaduto());
    }
}
