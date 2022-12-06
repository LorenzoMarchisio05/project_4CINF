using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Es12_Interfacce.Interface;
using Es12_Interfacce.Validators;

namespace Es12_Interfacce.Entity
{
    public sealed class Iscritto : IIscritto
    {
        private static List<Iscritto> iscritti = new List<Iscritto>();

        public delegate void eventDelegate(string message);

        public static event eventDelegate Scaduta;

        private DateTime dataRilascio;
        private string numeroCI;
        private string comune;
        private string nome;
        private string cognome;

        public Iscritto(string nome, string cognome, string numeroCI, string comune, string dataRilascio)
        {
            Nome = nome;
            Cognome = cognome;
            NumeroCI = numeroCI;
            Comune = comune;
            DataRilascio = dataRilascio;
        }

        public string Nome
        {
            get => nome;
            set
            {
                if (!AnagraphValidator.Validate(value))
                {
                    throw new Exception($@"Invalid name ""{value}""");
                }
                nome = value;
            }
        }

        public string Cognome
        {
            get => cognome;
            set
            {
                if(!AnagraphValidator.Validate(value))
                {
                    throw new Exception($@"Invalid surname ""{value}""");
                }
                cognome = value;
            }
        }
        public string NumeroCI
        {
            get => numeroCI;
            set
            {
                if (!CIValidator.Validate(value))
                {
                    throw new Exception($@"Invalid CI number: ""{value}""");
                }
                numeroCI = value.ToUpper();
            }
        }

        public string Comune
        {
            get => comune;
            set
            {
                string data = value.Trim();
                if(data.Length <=  2)
                {
                    throw new Exception($@"Invalid name ""{value}""");
                }
                comune = data;
            }
        }

        public string DataRilascio
        {
            get => dataRilascio.ToShortDateString();
            set
            {
                if (!DateTime.TryParse(value, out dataRilascio))
                {
                    throw new InvalidCastException($@"""{value}"" is not a valid date format");
                }
            }
        }

         string ICartaIdentita.visualizza() => $"Numero Carta: {NumeroCI}\nComune: {Comune}\nData Rilascio: {DataRilascio}";

         string IPersona.visualizza() => $"Cognome: {Cognome}\nNome: {Nome}";
         

        public bool scaduta() => DateTime.Now.Date > dataRilascio.AddYears(5).Date;
        

        public static void visualizzaDgv(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.DataSource = iscritti;
        }
        
        public bool aggiungiAllaLista()
        {
            bool esito = true;
            try
            {
                
                if(this.scaduta())
                {
                    Scaduta?.Invoke("Carta D'identit� scaduta");
                    esito = false;
                }
                else
                {
                    iscritti.Add(this);
                }
                
            }
            catch(Exception)
            {
                esito = false;
            }
            return esito;
        }
        
    }

    
    
}