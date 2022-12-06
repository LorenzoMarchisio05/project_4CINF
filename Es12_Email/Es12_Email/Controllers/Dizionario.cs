using Es12_Email.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es12_Email.Controllers
{
    public sealed class Dizionario
    {
        private Dictionary<string, string> nomeEmail;

        public Dizionario()
        {
            this.nomeEmail = new Dictionary<string, string>();
        }

        
        public bool Aggiungi(string nome, string email)
        {
            try
            {
                nomeEmail.Add(nome, email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Esiste(string nome) => nomeEmail.ContainsKey(nome);

        public void CaricaaInCMB(ComboBox cmb)
        {
            cmb.Items.Clear();
            foreach (KeyValuePair<string, string> keyValuePair in nomeEmail)
            {
                cmb.Items.Add($"{keyValuePair.Key} - {keyValuePair.Value}");
            }
        }

        public void SalvaSuFile()
        {
            using (var streamWriter = new StreamWriter("Contatti.txt"))
            {
                foreach (KeyValuePair<string, string> keyValuePair in nomeEmail)
                {
                    streamWriter.WriteLine($"{keyValuePair.Key} - {keyValuePair.Value}");
                }
            }
        }

        public IEnumerable<string> LeggiFile(string path)
        {
            
            if(!File.Exists(path))
            {
                throw new FileNotFoundException("file doesnt exist");
            }

            using (var streamReader = new StreamReader(path))
            {
                return streamReader
                    .ReadToEnd()
                    .Split('\n')
                    .Select(contatto => contatto.Replace("\n" , ""));
            }
        }
    }
}
