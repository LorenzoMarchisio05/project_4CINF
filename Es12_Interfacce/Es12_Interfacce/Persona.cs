using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es12_Interfacce
{
    public class Persona : IPersona
    {
        public string Nome { get; set; }

        public string Cognome { get; set; }

        public string visualizza()
        {
            return $"{Cognome} {Nome}";
        }
    }
}
