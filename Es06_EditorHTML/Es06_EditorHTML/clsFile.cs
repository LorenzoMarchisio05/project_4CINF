using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms; //per le finestre di dialogo
using System.CodeDom;
using System.Security.Cryptography;

namespace clsFile_ns
{
    public sealed class clsFile
    {
        private string filename;
        private bool modificato;
        private int hashcode;
        public string Filename 
        { 
            get => filename;
            set
            {
                value = value.Trim();
                filename = value.Length > 0 ? value : "senza nome";
            }
        }
        public bool Modificato
        {
            get => modificato;
            set => modificato = value;
        } 
        public clsFile()
        {
            this.Filename = "senza nome";
            this.Modificato = false;
        }
        private string leggiFile()
        {
            string testo = "";
            if (File.Exists(filename))
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    testo = sr.ReadToEnd();
                    modificato = false;
                }
            }
            hashcode = testo.GetHashCode();
            return testo;
        }

        private void scriviFile(in string testo)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filename, false))
                {
                    sw.Write(testo);
                    modificato = false;
                }
            }
            catch(Exception)
            {
            }
            
        }
        public string apri()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pagina HTML (*.html;*.htm)|*.html;*.htm|" + "Tutti i file (*.*)|*.*]";
            openFileDialog.Title = "EditorHTML - Apri";
            openFileDialog.InitialDirectory = GetDefaultFolderPath();
            if (openFileDialog.ShowDialog() == DialogResult.OK )
            {
                Filename = openFileDialog.FileName;
            }
            return leggiFile();
        }


        private static string GetDefaultFolderPath() => Environment
                        .GetFolderPath(Environment.SpecialFolder.Desktop);

        public void salvaConNome(in string testo)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "EditorHTML - Salva con nome";
            saveFileDialog.Filter = "Pagina HTML|*.html;*.htm|Tutti i file|*.*";
            saveFileDialog.AddExtension = true;
            saveFileDialog.InitialDirectory = GetDefaultFolderPath();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Filename = saveFileDialog.FileName;
                scriviFile(testo);
            }
            hashcode = testo.GetHashCode();
        }

        public void salva(in string testo)
        {
            if(modificato && File.Exists(filename))
            {
                scriviFile(testo);
            }
            else
            {
                salvaConNome(testo);
            }
            hashcode = testo.GetHashCode();
        }

        /// <summary>
        /// trova il percorso
        /// </summary>
        /// <returns></returns>
        public string getFileNameRelativo() => Path.GetFileName(filename);

        public bool isModificato(int hashcode) => this.hashcode != hashcode;

    }
}
