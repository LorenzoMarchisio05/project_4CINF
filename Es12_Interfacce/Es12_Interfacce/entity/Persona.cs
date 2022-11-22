using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es12_Interfacce
{
    public class Persona : IPersona
    {
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

        public string visualizza()
        {
            return $"{Cognome} {Nome}";
        }
    }
}
