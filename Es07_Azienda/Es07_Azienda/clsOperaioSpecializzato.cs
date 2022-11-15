using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es07_Azienda
{
    public sealed class clsOperaioSpecializzato : clsOperaio
    {
        private static double costoOrarioSpecializzato = 50d;
        private double oreSpecializzate;

        public string OreSpecializzate
        {
            get => oreSpecializzate.ToString();
            set
            {
                if (isNull(value) || !double.TryParse(value, out double ore))
                {
                    throw new ArgumentException(nameof(value) + " is not a number");
                }
                oreSpecializzate = ore;
            }
        }

        public clsOperaioSpecializzato(string cognome, string nome, string ore, string oreSpecializzate) : base(cognome, nome, ore)
        {
            OreSpecializzate = oreSpecializzate;
        }

        public override double calcolaStipendio() => base.calcolaStipendio() + costoOrarioSpecializzato * oreSpecializzate;
        public override string visualizza() => base.visualizza() + $" {oreSpecializzate}";
    }
}
