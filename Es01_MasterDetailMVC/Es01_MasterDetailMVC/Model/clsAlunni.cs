using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Es01_MasterDetailMVC.Model
{
    public class clsAlunni
    {
        private int idAlunno;
        private string cognome;
        private string nome;
        private string citta;
        private DateTime dataNascita;
        private int altezza;
        private bool inglese;
        private string telefono;
        public int IdAlunno
        {
            get
            {
                return idAlunno;
            }
            set
            {
                try
                {
                    idAlunno = Convert.ToInt32(value);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public string Cognome
        {
            get
            {
                return cognome;
            }
            set
            {
                Regex reg;
                string re;
                re = @"^[A-Za-z\s\'àèéìòù]{2,30}$";
                reg = new Regex(re);
                if (reg.IsMatch(value))
                {
                    cognome = value;
                }
                else
                {
                    throw new Exception("Attenzione, formato stringa 'Cognome' non valido");
                }
            }
        }
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                Regex reg;
                string re;
                re = @"^[A-Za-z\s\'àèéìòù]{2,30}$";
                reg = new Regex(re);
                if (reg.IsMatch(value))
                {
                    nome = value;
                }
                else
                {
                    throw new Exception("Attenzione, formato stringa 'Nome' non valido");
                }
            }
        }

        public string Citta
        {
            get
            {
                return citta;
            }
            set
            {
                Regex reg;
                string re;
                re = @"^[A-Za-z\s\'àèéìòù]{3,30}$";
                reg = new Regex(re);
                if (reg.IsMatch(value))
                {
                    citta = value;
                }
                else
                {
                    throw new Exception("Attenzione, formato stringa 'Città' non valida");
                }
            }
        }
        public DateTime DataNascita
        {
            get
            {
                return dataNascita;
            }
            set
            {
                if (value.Year <= DateTime.Now.Year - 15 && value.Year >= DateTime.Now.Year - 50)
                {
                    dataNascita = value;
                }
                else
                {
                    throw new Exception("Attenzione, Eta' non compresa tra 15 e 50 anni");
                }
            }
        }
        public int Altezza
        {
            get
            {
                return altezza;
            }
            set
            {
                try
                {
                    if (Convert.ToInt32(value) < 300 && Convert.ToInt32(value) > 100)
                    {
                        altezza = Convert.ToInt32(value);
                    }
                    else
                    {
                        throw new Exception("Attenzione, 'Altezza' non compresa tra i 100 e i 300 cm");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        public bool Inglese
        {
            get { return inglese; }
            set { inglese = value; }
        }
        public string Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                string re = @"^[0-9]{10}$";
                Regex reg = new Regex(re);
                if (reg.IsMatch(value))
                {
                    telefono = value;
                }
                else
                {
                    if (value != "")
                    {
                        throw new Exception("Attenzione, formato del 'Telefono' non valido");
                    }
                    else
                    {
                        telefono = value;
                    }
                }
            }
        }
    }
}