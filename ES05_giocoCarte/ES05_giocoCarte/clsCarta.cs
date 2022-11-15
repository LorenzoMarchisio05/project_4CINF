using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES05_giocoCarte
{
    public sealed class clsCarta
    {
        private static readonly Random cachedRandom = new Random();

        private seme seme;
        private valore valore;

        public clsCarta(seme seme, valore valore)
        {
            this.Seme = seme.ToString();
            this.Valore = valore.ToString();
        }

        public clsCarta(string seme, string valore)
        {
            this.Seme = seme;
            this.Valore = valore;
        }

        public clsCarta()
        {
        }

        public string Seme
        {
            get => seme.ToString();
            set
            {
                if (!Enum.TryParse(value.ToUpper(), out seme val))
                {
                    throw new InvalidCastException("passa un seme consentito");
                }
                seme = val;
            }
        }

        public string Valore
        {
            get => valore.ToString();
            set
            {
                if (!Enum.TryParse(value.ToUpper(), out valore val))
                {
                    throw new InvalidCastException("passa un valore consentito");
                }
                valore = val;
            }
        }

        /// <summary>
        /// questa funzione genera un seme e un valore casuale tra quelli accettati
        /// </summary>
        /// <returns>Ritorna una tuple di due string ( seme , valore )</returns>
        public static (string, string) Proponi() => (getRandomSeed().ToString(), getRandomValue().ToString());

        /// <summary>
        /// genera un valore casuale tra quelli proposti dall'enum valore
        /// </summary>
        /// <returns></returns>
        private static valore getRandomValue() => (valore)cachedRandom.Next(1, 11);

        /// <summary>
        /// genera un seme casuale tra quelli proposti dall'enum seme
        /// </summary>
        /// <returns></returns>
        private static seme getRandomSeed() => (seme)cachedRandom.Next(0, 4);

        public override string ToString()
        {
            return $"{this.Seme} {this.Valore}";
        }

        public override bool Equals(object obj)
        {
            clsCarta carta = (clsCarta)obj;
            return this.Valore == carta.Valore && this.Seme == carta.Seme;
        }

        public bool Equals(clsCarta carta)
        {
            return this.Valore == carta.Valore && this.Seme == carta.Seme;
        }

        public static bool operator == (clsCarta a, clsCarta b)
        {
            return a.Equals(b);
        }

        public static bool operator != (clsCarta a, clsCarta b)
        {
            return !a.Equals(b);
        }
    }
}
