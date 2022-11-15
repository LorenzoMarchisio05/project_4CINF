using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;

namespace Es07_Azienda
{
    public class clsOperaio
    {
        private static Regex cachedRegex = new Regex(@"^[\p{L}'-]{2,}$", RegexOptions.IgnoreCase);
        protected static double costoOrario = 30.5d;

        protected string cognome;
        protected string nome;
        protected uint ore;

        public uint Matricola { get; }
        public string Cognome
        {
            get => cognome;
            set
            {
                throwIfInvalidString(ref value, $"{nameof(value)}: invalid surname");
                cognome = value;
            }
        }

        public string Nome
        {
            get => nome;
            set
            {
                throwIfInvalidString(ref value, $"{nameof(value)}: invalid name");
                nome = value;
            }
        }

        public string Ore
        {
            get => ore.ToString();
            set
            {
                uint ore = throwIfInvalidUint(value);
                this.ore = ore;
            }
        }


        public clsOperaio()
        {
            this.Matricola = IdGenerator.generate();
        }
        public clsOperaio(string cognome, string nome, string ore)
        {
            Cognome = cognome;
            Nome = nome;
            Matricola = IdGenerator.generate();
            Ore = ore;
        }

        public virtual string visualizza() => $"{this.Nome} {this.Cognome} {this.Ore}";

        public virtual double calcolaStipendio() => ore * costoOrario;

        public override string ToString() => this.visualizza();

        private bool check(ref string value) => !isNull(value) && (value = value.Trim()).Length >= 2 && cachedRegex.IsMatch(value);

        protected bool isNull(in string value) => (value is null);

        private uint throwIfInvalidUint(string value)
        {
            if (isNull(value) || !uint.TryParse(value, out uint ore))
            {
                throw new ArgumentException($"{nameof(value)}: is not a number");
            }

            return ore;
        }

        private void throwIfInvalidString(ref string value, string message)
        {
            if (!check(ref value))
            {
                throw new ArgumentException(message);
            }
        }
    }
}
