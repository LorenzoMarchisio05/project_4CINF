using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.IO;
using System.Windows.Forms; //per le finestre di dialogo

namespace clsFile_ns
{
    public class clsFile
    {
        private string filename;
        private bool modificato;
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
            this.Filename = "_";
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
            return testo;
        }
        private void scriviFile(in string testo)
        {
            if (File.Exists(filename))
            {
                using (StreamWriter sw = new StreamWriter(filename, false))
                {
                    sw.Write(testo);
                    modificato = false;
                }
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
        }

        /// <summary>
        /// trova il percorso
        /// </summary>
        /// <returns></returns>
        public string getFileNameRelativo() => Path.GetFileName(filename);

    }
}
