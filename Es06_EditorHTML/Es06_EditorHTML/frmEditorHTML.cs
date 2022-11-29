using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsFile_ns;

namespace Es06_EditorHTML
{
    public partial class frmEditorHTML : Form
    {
        private readonly clsFile filemanager;

        private readonly clsStampa printManager;

        public frmEditorHTML()
        {
            InitializeComponent();
            filemanager = new clsFile();

            printManager = new clsStampa();
        }


       // logica

        private bool verificaModifiche()
        {
            bool annulla = false;

            if (filemanager.Modificato)
            {
                // chiedo se si vuole salvare il documento aperto
                DialogResult dialogRes = MessageBox.Show(
                    $"Salva {filemanager.getFileNameRelativo()}",
                    "Salvataggio",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                switch (dialogRes)
                {
                    case DialogResult.Yes:
                        filemanager.salva(txtCodiceSorgente.Text);
                        break;
                    case DialogResult.Cancel:
                        annulla = true;
                        break;
                }
            }

            return annulla;
        }


        private void setWindowTitle()
        {
            this.Text = filemanager.getFileNameRelativo() + " - Editor HTML";
        }

        private void apriFile()
        {
            if (!verificaModifiche())
            {
                filemanager.Modificato = false;
                txtCodiceSorgente.Text = filemanager.apri();
                setWindowTitle();
            }
        }

        private void nuovoFile()
        {
            if (!verificaModifiche())
            {
                txtCodiceSorgente.Text = "";
                scriviTag(generaDocumentoHtml(out int len) , len);
                filemanager.Modificato = false;
            }
        }

        private void inizializzaWebPreview(int index)
        {
            if (index == 1)
            {
                webBrowser.DocumentText = txtCodiceSorgente.Text;
            }
        }

        private void salvaFile()
        {
            filemanager.salva(txtCodiceSorgente.Text);
        }

        private void salvaFileConNome()
        {
            filemanager.salvaConNome(txtCodiceSorgente.Text);
            setWindowTitle();
        }

        private void handleTextChanged()
        {
            if (filemanager.isModificato(txtCodiceSorgente.Text.GetHashCode()))
                filemanager.Modificato = true;
        }

        private void informazioni()
        {
            AboutBox1 f = new AboutBox1();
            f.ShowDialog();         
        }

        private void annullaAzione()
        {
            txtCodiceSorgente.Undo();
        }

        private void ripristinaAzione()
        {
            SendKeys.Send("^+z");
        }

        private void copiaTesto()
        {
            txtCodiceSorgente.Copy();
        }

        private void tagliaTesto()
        {
            txtCodiceSorgente.Cut();
        }

        private void incollaTesto()
        {
            txtCodiceSorgente.Paste();
        }


        private string generaDocumentoHtml(out int len)
        {
            // DO NOT  FORMAT 
            string html = @"<!DOCTYPE html>
    <html lang=""en"">
    <head>
        <meta charset=""UTF-8"">
        <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
        <title>Document</title>
    </head>
    <body>
        
    </body>
</html>";
            len = html.IndexOf("<body>") + 1;
            return html;
        }


        private void scriviTag(string tag,  int len)
        {
            int pos = txtCodiceSorgente.SelectionStart;

            txtCodiceSorgente.Paste(tag);

            txtCodiceSorgente.SelectionStart = pos + len;

        }

        private void hanldeToolStripTag(string tag)
        {
            tag = tag.ToLower();
            if(tag.Contains("input"))
            {
                tag = tag.Insert(tag.LastIndexOf(">") - 1, " id='' type='text' ");
            }
            if(tag.Contains("<a/>"))
            {
                tag = tag.Insert(tag.LastIndexOf("/>"), " href=''");
            }
            if(tag.Contains("<img/>"))
            {
                tag = tag.Insert(tag.LastIndexOf("/>"), " src='' alt=''");
            }
            if (!tag.Contains("/"))
            {
                tag += tag.Insert(tag.IndexOf('<') + 1, "/");
            }
            scriviTag(tag, tag.IndexOf(">") + 1);
        }

        

        // Eventi

        private void frmEditorHTML_Load(object sender, EventArgs e)
        {
            txtCodiceSorgente.Focus();
            scriviTag(generaDocumentoHtml(out int len), len);
            setWindowTitle();
            filemanager.Modificato = false;

            this.stampaToolStripButton.Click += new EventHandler(handleStampa);
            this.stampaToolStripMenuItem.Click += new EventHandler(handleStampa);
        }

        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuovoFile();
        }


        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            apriFile();
        }

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvaFile();
        }

        private void salvaconnomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvaFileConNome();
        }

        private void txtCodiceSorgente_TextChanged(object sender, EventArgs e)
        {
            handleTextChanged();
        }

        private void multiPageTabController_Selected(object sender, TabControlEventArgs e)
        {
            inizializzaWebPreview(e.TabPageIndex);
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditorHTML_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (verificaModifiche())
            {
                e.Cancel = true;
            }
        }

        private void nuovoToolStripButton_Click(object sender, EventArgs e)
        {
            nuovoFile();
        }

        private void apriToolStripButton_Click(object sender, EventArgs e)
        {
            apriFile();
        }

        private void salvaToolStripButton_Click(object sender, EventArgs e)
        {
            salvaFile();
        }

        private void informazionisuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            informazioni();
        }

        private void ToolStripButton_Click(object sender, EventArgs e)
        {
            informazioni();
        }

        private void annullaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            annullaAzione();
        }

        private void ripristinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ripristinaAzione();
        }

        private void annullaToolStripButton_Click(object sender, EventArgs e)
        {
            annullaAzione();
        }

        private void ripristinaToolStripButton_Click(object sender, EventArgs e)
        {
            ripristinaAzione();
        }

        private void tagliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tagliaTesto();
        }

        private void copiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copiaTesto();
        }

        private void incollaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            incollaTesto();
        }

        private void tagliaToolStripButton_Click(object sender, EventArgs e)
        {
            tagliaTesto();
        }

        private void copiaToolStripButton_Click(object sender, EventArgs e)
        {
            copiaTesto();
        }

        private void incollaToolStripButton_Click(object sender, EventArgs e)
        {
            incollaTesto();
        }


        private void hanldleInsertTagToolStripButton_Click(object sender, EventArgs e)
        {
            hanldeToolStripTag(((ToolStripButton)sender).Text);
        }

        private void hanldleInsertTagToolStripMenuItemButton_Click(object sender, EventArgs e)
        {
            hanldeToolStripTag(((ToolStripMenuItem)sender).Text);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableForm();

            tableForm.ShowDialog();

            StringBuilder sb = new StringBuilder();

            sb.Append("<table>");

            for(int i = 0; i < tableForm.Righe; i++)
            {
                sb.Append("<tr>");

                for(int j = 0; j < tableForm.Colonne; j++)
                {
                    sb.Append("<td></td>");
                }

                sb.Append("</tr>");
            }

            sb.Append("<table>");

            string table = sb.ToString();

            scriviTag(table, table.LastIndexOf("</table>") + 1);

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {
            scriviTag("<form></form>", 6);
        }
        
        private void handleStampa(object sender, EventArgs e)
        {
            PrintDocument document = new PrintDocument();

            PrintDialog printerDialog = new PrintDialog();

            document.PrintPage += new PrintPageEventHandler((obj_sender, @event) =>
            {
                @event.Graphics.DrawString(txtCodiceSorgente.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, 20, 20);
            });

            printerDialog.Document = document;

            if (printerDialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }

        private void stampaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printManager.Stampa(txtCodiceSorgente.Text, txtCodiceSorgente.Font);
        }

        private void anteprimadistampaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printManager.Anteprima(txtCodiceSorgente.Text, txtCodiceSorgente.Font);
        }

        private void impostaPaginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printManager.ImpostaPagina();
        }
    }
}
