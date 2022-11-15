using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES09_PRODOTTI
{
    public class clsNonAlimentare : clsProdotto
    {
        private DateTime dataAcquisto;
        private uint giorniGaranzia;

        public string GiorniGaranzia
        {
            get => giorniGaranzia.ToString();
            set
            {
                if(!uint.TryParse(value.Trim(), out uint days))
                {
                    throw new Exception("Insert a correct number of days");
                }

                giorniGaranzia = days;
            }
        }
        
        public string DataAcquisto
        {
            get => dataAcquisto.ToShortDateString();
            set
            {
                if(!DateTime.TryParse(value.Trim(), out DateTime date))
                {
                    throw new Exception("Insert a correct date");
                }

                dataAcquisto = date;
            }
        }
        
        public clsNonAlimentare(string nomeprodotto, string marca, string prezzo, string dataAcquisto, string giorniGaranzia) : base(nomeprodotto, marca, prezzo)
        {
            DataAcquisto = dataAcquisto;
            GiorniGaranzia = giorniGaranzia;
        }

        public override bool scaduto()
        {
            return dataAcquisto.AddDays(giorniGaranzia).Date >= DateTime.Now.Date;
        }
    }
}