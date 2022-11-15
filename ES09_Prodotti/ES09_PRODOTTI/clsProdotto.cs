using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ES09_PRODOTTI
{
    public abstract class clsProdotto
    {
        protected string nomeProdotto;
        protected string marca;
        protected double prezzo;

        public string NomeProdotto
        {
            get => nomeProdotto;
            set
            {
                throwIfNoRegexMatch(ref value, "invalid product name");
                this.nomeProdotto = value;
            }
            
        }

        public string Marca
        {
            get => marca;
            set
            {
                this.marca = value;
            }
        }

        public string Prezzo
        {
            
            get => prezzo.ToString();
            set {
                if (!double.TryParse(value, out double prezzo))
                {
                    throw new InvalidCastException("invalid price value");
                }

                this.prezzo = prezzo;
            }
        }

        public clsProdotto(string nomeprodotto, string marca, string prezzo)
        {
            NomeProdotto = nomeprodotto;
            Marca = marca;
            Prezzo = prezzo;   
        }

        private void throwIfNoRegexMatch(ref string value, string message)
        {
            value = value.Trim();
            if (!Regex.IsMatch(value , "[a-z]{2,}", RegexOptions.IgnoreCase| RegexOptions.Compiled)) throw new InvalidCastException(message);
        }
        public abstract bool scaduto();
        
    }
}
