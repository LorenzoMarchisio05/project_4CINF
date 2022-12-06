using Es12_Email.Interface;
using Es12_Email.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es12_Email.Entity
{
    public sealed class Email : IEmail
    {
        private string titolo;
        private string path;

        private string nomeDestinatario;
        private string testoMessaggio;

        private string oggettto;
        private string indirizzo;

        public string Indirizzo
        {
            get => indirizzo;
            set
            {
                if (!EmailValidator.Validate(value))
                {
                    throw new Exception($@"Invalid email address: ""{value}""");
                }
                indirizzo = value;
            }
        }
        public string Oggettto
        {
            get => oggettto;
            set
            {
                if (!ObjectValidator.Validate(value))
                {
                    throw new Exception($@"Invalid object: ""{value}""");
                }
                oggettto = value;
            }
        }

        public string Titolo
        {
            get => titolo;
            set
            {
                if (!NameValidator.Validate(value))
                {
                    throw new Exception($@"Invalid title: ""{value}""");
                }
                titolo = value;
            }
        }

        public string Path
        {
            get => path;
            set
            {
                if (!PathValidator.Validate(value))
                {
                    throw new Exception($@"Invalid path: ""{value}""");
                }
                path = value;
            }
        }
        public string NomeDestinatario
        {
            get => nomeDestinatario;
            set
            {
                if (!NameValidator.Validate(value))
                {
                    throw new Exception($@"Invalid name: ""{value}""");
                }
                nomeDestinatario = value;
            }
        }
        public string TestoMessaggio
        {
            get => testoMessaggio;
            set
            {
                if (!TextValidator.Validate(value))
                {
                    throw new Exception($@"Invalid name: ""{value}""");
                }
                testoMessaggio = value;
            }
        }

        public string Visualizza() =>
            $"Titolo: {Titolo}\nNome Destinatario: {NomeDestinatario}\nTesto Messaggio: {TestoMessaggio}\nPath: {Path}";
    }
}
