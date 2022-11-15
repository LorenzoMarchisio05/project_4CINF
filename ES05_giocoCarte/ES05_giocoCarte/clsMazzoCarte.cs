using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES05_giocoCarte
{
    public sealed class clsMazzoCarte
    {
        private uint id { get; }
        private List<clsCarta> listaCarte { get; }

        private static readonly Random rnd = new Random();

        public clsMazzoCarte()
        {
            listaCarte = new List<clsCarta>();
            id = Generator.generate();
        }

        /// <summary>
        /// questo metodo inserisce una carta nella lista
        /// </summary>
        /// <param name="carta">istanza di clsCarta, avente seme e valore</param>
        public void inserisciCarta(clsCarta carta)
        {
            /*
            int i = 0;
            while(i < listaCarte.Count && listaCarte[i] != carta) i++;
            if(i == listaCarte.Count)
            */
            if (!listaCarte.Contains(carta))
            {
                listaCarte.Add(carta);
            }
        }

        /// <summary>
        /// ritorna la prima carta del mazzo
        /// </summary>
        /// <returns>ritorna un istanza di clsCarta avente seme e valore</returns>
        public clsCarta dammiCarta()
        {
            return listaCarte[0];
        }
        
        /// <summary>
        /// dato un seme come stringa questa funzione si occupa
        /// di trovare la prima carta nella lista avente tale seme
        /// </summary>
        /// <param name="seme">stringa rappresentante il seme della carta</param>
        /// <returns>ritorna una istanza della classe clsCarte avente seme e valore</returns>
        /// <exception cref="ArgumentException">Se il seme non è uno dei semi accettati viene tirata questa ecceione</exception>
        /// <exception cref="Exception">Se la funzione non trova carte con tale seme tira una normale Exception</exception>
        public clsCarta dammiCarta(string seme)
        {
            string semeToUpper = seme.ToUpper();
            int i = 0;
            
            if (!Enum.TryParse(semeToUpper, out seme _))
            {
                throw new ArgumentException("passa un seme valido");
            }

            while (++i < listaCarte.Count && listaCarte[i].Seme != semeToUpper);

            if (i == listaCarte.Count)
            {
                throw new Exception("nessuna carta trovata");
            }

            return listaCarte[i];
        }

        /// <summary>
        /// questo metodo mostra le carte nella data grid view
        /// </summary>
        /// <param name="dgv">DataGridView passata come parametro</param>
        public void visualizzaMazzo(in DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.DataSource = listaCarte;
        }

        /// <summary>
        /// questo metodo mescola il mazzo randomizzando
        /// la posizione delle carte nella lista
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void mescolaCarte()
        {
            clsCarta[] carteRandomizzate = new clsCarta[listaCarte.Count];
            int i = 0;
            foreach(clsCarta carta in listaCarte)
            {
                do
                {
                    i = rnd.Next(0, listaCarte.Count);
                } while (!(carteRandomizzate[i] is null));
                carteRandomizzate[i] = carta;
            }
            listaCarte.Clear();
            listaCarte.AddRange(carteRandomizzate);
        }

        /// <summary>
        /// questa funzione scorrendo il mazzo conta le carte per ogni seme
        /// </summary>
        /// <returns>Ritorna un Dictionary contentente coppie seme int</returns>
        public Dictionary<string, int> totali()
        {
            Dictionary<string, int> cartePerSeme = new Dictionary<string, int>();
            
            foreach (clsCarta carta in listaCarte)
            {
                if (cartePerSeme.TryGetValue(carta.Seme, out int val))
                {
                    val++;
                }
                if (!cartePerSeme.ContainsKey(carta.Seme))
                {
                    cartePerSeme.Add(carta.Seme, val + 1);
                }
                else
                {
                    cartePerSeme[carta.Seme]++;
                }
                
            }


            return cartePerSeme;
        }
    }
}
