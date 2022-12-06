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

        public string Titolo
        {
            get => titolo;
            set
            {
                if (value?.Trim().Length == 0)
                {
                    return;
                }

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
                if(value?.Trim().Length == 0)
                {
                    return;
                }

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
                if (value.Length == 0)
                {
                    return;
                }

                if (!TextValidator.Validate(value))
                {
                    throw new Exception($@"Invalid name: ""{value}""");
                }
                testoMessaggio = value;
            }
        }

        public Email(string indirizzo, string titolo, string path, string nomeDestinatario, string testoMessaggio)
        {
            Indirizzo = indirizzo ?? throw new ArgumentNullException(nameof(indirizzo));
            Titolo = titolo ?? throw new ArgumentNullException(nameof(titolo));
            Path = path ?? throw new ArgumentNullException(nameof(path));
            NomeDestinatario = nomeDestinatario ?? throw new ArgumentNullException(nameof(nomeDestinatario));
            TestoMessaggio = testoMessaggio ?? throw new ArgumentNullException(nameof(testoMessaggio));
        }

        public string Visualizza() =>
            $"Titolo: {Titolo}\nNome Destinatario: {NomeDestinatario}\nTesto Messaggio: {TestoMessaggio}\nPath: {Path}";
    }
}
