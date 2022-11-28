using System;
using Es12_Interfacce.Interface;
using Es12_Interfacce.Validators;

namespace Es12_Interfacce.Entity
{
    public sealed class CartaIdentita : ICartaIdentita
    {
        private DateTime dataRilascio;
        private string numeroCI;
        private string comune;

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

        public string visualizza() => $"Numero Carta: {NumeroCI}\nComune: {Comune}\nData Rilascio: {DataRilascio}";

        public bool scaduta() => DateTime.Now.Date > dataRilascio.AddYears(5).Date;
    }
}
