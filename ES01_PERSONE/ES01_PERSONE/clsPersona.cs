using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ES01_PERSONE
{
    public sealed class clsPersona
    { 
        private static Regex cachedRegex {get; } = new Regex("[a-zA-Z]*'?");

        private string cognome;
        private string nome;
        private DateTime dataNascita;
        
        public string Cognome 
        { 
            get => cognome; 
            set => cognome = handleString(value); 
        }

        public string Nome 
        { 
            get => nome; 
            set => nome = handleString(value); 
        }

        public DateTime DataNascita
        {
            get => dataNascita;
            set => dataNascita = handleNewDate(value);
        }

        private string handleString(string value)
        {
            if(value is null)
            {
                throw new ArgumentNullException("non può essere null");
            }

            //int i = 0;
            //value = value.ToLower();
            //while (i < value.Length && !char.IsDigit(value[i]) && (char.IsLetter(value[i]) || value[i] == '\'')) i++;
            //if(i  != value.Length)
            //{
            //    throw new ArgumentException("stringa invaida");
            //}

            if(!cachedRegex.IsMatch(value))
            {
                throw new ArgumentException("inserire solo lettere");
            }

            if (string.IsNullOrWhiteSpace(value) || value.Length < 2 )
            {
                throw new ArgumentException("stringa invaida");
            }
            
            return value;
        }

        private DateTime handleNewDate(in DateTime value)
        {
            if (value > DateTime.Now)
            {
                throw new ArgumentException("data di nascita invalida");
            }
            return value;
        }


        public clsPersona(string _cognome, string _nome, DateTime _dataNascita)
        {
            Cognome = _cognome;
            Nome = _nome;
            DataNascita = _dataNascita;
        }

        public clsPersona()
        {
        }

        public string visualizza() => $"{nome} {cognome} {dataNascita}";

        public int calcolaEta()
        {
            DateTime now = DateTime.Now;
            int age = now.Year - dataNascita.Year;
            age = (dataNascita.AddYears(age).Date < now.Date ? age - 1 : age);
            return age < 0 ? 0 : age;
        }

        public bool isMaggiorenne() => this.calcolaEta() >= 18;

    }
}
