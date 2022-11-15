using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES09_PRODOTTI
{
    public class clsAlimentare : clsProdotto
    {
        private DateTime scadenzaProdotto;

        public string ScadenzaProdotto
        {
            get => scadenzaProdotto.ToShortDateString();
            set
            {
                if(!DateTime.TryParse(value.Trim(), out DateTime date))
                {
                    throw new Exception("Insert a correct date");
                }

                scadenzaProdotto = date;
            }
        }

        public clsAlimentare(string nomeprodotto, string marca, string prezzo, string scadenzaProdotto) : base(nomeprodotto, marca, prezzo)
        {
            ScadenzaProdotto = scadenzaProdotto;
        }

        public override bool scaduto()
        {
            return DateTime.Now.Date > scadenzaProdotto.Date;
        }
    }
}
