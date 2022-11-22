using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es12_Interfacce
{
    public class CartaIdentita : ICartaIdentita
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
                    throw new Exception("Invalid CI number");
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
                    throw new Exception("invalid Name");
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
            return $"Numero Carta: {NumeroCI}\nComune: {Comune}\nData Rilascio: {DataRilascio}";
        }
    }
}
