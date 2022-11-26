using System;
using Es12_Interfacce.Interface;
using Es12_Interfacce.Validators;

namespace Es12_Interfacce.Entity
{
    public sealed class Iscritto : IIscritto
    {
        private DateTime dataRilascio;
        private string numeroCI;
        private string comune;
        private string nome;
        private string cognome;

        
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
                numeroCI = value;
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

        public string visualizza()
        {
            return $"Numero Carta: {NumeroCI}\nComune: {Comune}\nData Rilascio: {DataRilascio}\nCognome: {Cognome}\nNome: {Nome}";
        }
    }
}