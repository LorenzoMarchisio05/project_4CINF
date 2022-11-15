using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ES01_PERSONE
{
    public sealed class clsElenco
    {
        private List<clsPersona> listaPersone { get; }

        public clsElenco()
        {
            listaPersone = new List<clsPersona>();
        }

        public void aggiungiPersona(clsPersona persona)
        {
            listaPersone.Add(persona);
        }

        public void visualizzaElenco(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.DataSource = listaPersone;
        }

        
        public string ricerca(string cognome)
        {
            StringBuilder sb = new StringBuilder();
            string risultati;
    
            if (cognome is null)
            {
                return "non può essere null";
            }
    
            foreach(clsPersona persona in listaPersone)
            {
                if(persona.Cognome.ToLower() == cognome.ToLower())
                {
                    sb.Append(persona.visualizza()).Append("\n");
                }
            }
    
            risultati = sb.ToString();
    
            if(risultati == "")
            {
                risultati = "nessun riscontro con il cognome";
            }
    
            return risultati;
        }
    
        public string ricerca(int anno)
        {
            StringBuilder sb = new StringBuilder();
            string risultati;
    
            if (anno < 0)
            {
                return "non può essere minore di 0";
            }
    
            foreach(clsPersona persona in listaPersone)
            {
                if (persona.DataNascita.Year == anno)
                {
                    sb.Append(persona.visualizza()).Append("\n");
                }
            }
    
            risultati = sb.ToString();
    
            if(risultati == "")
            {
                risultati = "nessun riscontro con il cognome";
            }
            
            return risultati;
        }
        
        /*
        public string ricerca(string cognome)
        {
            if (cognome is null)
            {
                return "cognome non può essere null";
            }

            return getStringFromComparer(cognome, (p, c) => c.ToLower() == p.Cognome.ToLower());
        }


        public string ricerca(int anno)
        {
            if (anno < 0)
            {
                return "anno non può essere minore di 0";
            }

            return getStringFromComparer(anno, (p, a) => a == p.DataNascita.Year);
        }
        */
        
        public void ricerca(DataGridView dgv, string cognome)
        {
            if (!(cognome is null) || !(dgv is null))
            {
                dgv.DataSource = null;
                dgv.DataSource = getList(cognome);
            }
        }

        public clsPersona trovaPersonaPerIndice(int riga)
        {
            int i = 0;
            while (i < listaPersone.Count && i < riga) i++;
            return i != listaPersone.Count ? listaPersone[i] : null;
        }

        public void ricerca(DataGridView dgv,int anno)
        {
            if (anno >= 0 && !(dgv is null))
            {
                dgv.DataSource = null;
                dgv.DataSource = getList(anno);
            }
        }

        /*
        private string getStringFromComparer<T>(T comparable, Func<clsPersona, T, bool> comparer)
        {
            StringBuilder sb = new StringBuilder();

            string risultati;

            foreach (clsPersona persona in listaPersone)
            {
                if (comparer(persona, comparable))
                {
                    sb.Append(persona.visualizza()).Append("\n");
                }
            }


            risultati = sb.ToString();

            if (string.IsNullOrWhiteSpace(risultati))
            {
                risultati = "nessun riscontro";
            }

            return risultati;
        }
        */
        
        private IReadOnlyList<clsPersona> getList(int year)
        {
            List<clsPersona> matchedUser = new List<clsPersona>();

            foreach (clsPersona persona in listaPersone)
            {
                if (persona.DataNascita.Year == year)
                {
                    matchedUser.Add(persona);
                }
            }
            
            return matchedUser;
        }
        
        private IReadOnlyList<clsPersona> getList(string cognome)
        {
            List<clsPersona> matchedUser = new List<clsPersona>();

            foreach (clsPersona persona in listaPersone)
            {
                if (persona.Cognome.ToLower() == cognome.ToLower())
                {
                    matchedUser.Add(persona);
                }
            }
            
            return matchedUser;
        }
        
        private IReadOnlyList<clsPersona> getListFromComparer<T>(T comparable, Func<clsPersona, T, bool> comparer)
        {
            List<clsPersona> matchedUser = new List<clsPersona>();

            foreach (clsPersona persona in listaPersone)
            {
                if (comparer(persona, comparable))
                {
                    matchedUser.Add(persona);
                }
            }
            
            return matchedUser;
        }
        
        
    }
}