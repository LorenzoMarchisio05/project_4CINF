using Es12_Email.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es12_Email.Controllers
{
    public sealed class Lista
    {
        private static List<Email> emails = new List<Email>();

        private readonly DataGridView dgv;
        private readonly Dizionario dizionario;

        public delegate void messageDelegate(string message);
        public event messageDelegate InsertionSuccess;

        public Lista(DataGridView dataGridView, Dizionario dictionary)
        {
            dgv = dataGridView;
            dizionario = dictionary;
        }

        public void insert(Email mail)
        {
            emails.Add(mail);
            dgv.DataSource = null;
            dgv.DataSource = emails;
            dizionario.Aggiungi(mail.NomeDestinatario, mail.Indirizzo);
            InsertionSuccess?.Invoke("mail aggiunta con successo");
        }
    }
}
