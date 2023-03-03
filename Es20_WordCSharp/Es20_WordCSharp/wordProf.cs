using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es20_WordCSharp
{
    public class clsWord
    {
        //applicazione word
        _Application myWord;
        //documento word
        Document myDoc;
        public clsWord()
        {

        }

        public void creaDocumento(bool visible = true)
        {
            //istanzio applicazione word
            myWord = new Application();
            //la rendo visibile
            myWord.Visible = visible;
            //istanzio-creo documento
            myDoc = new Document();
            myDoc = myWord.Documents.Add();
        }

        public void inserisciTesto(object start, object end, string text, string aCapo, string font = "Arial", string size = "12", string sottolineato = "None", string allineamento = "Left", bool bold = false, bool italic = false, string colore = "Black")
        {
            Range myRange = myDoc.Range(ref start, ref end);
            myRange.Text = text + aCapo;
            myRange.Font.Name = font;
            myRange.Font.Size = Convert.ToInt32(size);
            //
            WdUnderline u = (WdUnderline)Enum.Parse(typeof(WdUnderline),
                            "wdUnderline" + sottolineato);
            myRange.Font.Underline = u;
            //
            WdParagraphAlignment a = (WdParagraphAlignment)Enum.Parse(typeof(WdParagraphAlignment),
                            "wdAlignParagraph" + allineamento);
            myRange.ParagraphFormat.Alignment = a;
            //
            myRange.Bold = Convert.ToInt32(bold);
            myRange.Italic = Convert.ToInt32(italic);
            //
            WdColor c = (WdColor)Enum.Parse(typeof(WdColor),
                            "wdColor" + colore);
            myRange.Font.Color = c;
        }

        public void impostaRange(ref object start, ref object end)
        {
            start = myDoc.Sentences[myDoc.Sentences.Count].End - 1;
            end = myDoc.Sentences[myDoc.Sentences.Count].End;
        }

        public void impostaFont(System.Windows.Forms.ComboBox cmbFont)
        {
            foreach (FontFamily family in FontFamily.Families)
                cmbFont.Items.Add(family.Name);
            cmbFont.SelectedIndex = 9; //arial
        }

        public void impostaSize(System.Windows.Forms.ComboBox cmbSize)
        {
            for (int i = 8; i < 42; i++)
            {
                cmbSize.Items.Add(i.ToString());
            }
            cmbSize.SelectedIndex = 4;
        }

        public void impostaSottolineato(System.Windows.Forms.ComboBox cmbSottolineato)
        {
            string[] wdU = (string[])Enum.GetNames(typeof(WdUnderline));
            foreach (string sottolineato in wdU)
            {
                cmbSottolineato.Items.Add(sottolineato.Substring(11));
            }
            cmbSottolineato.SelectedIndex = 0;
        }

        public void impostaAllineamento(System.Windows.Forms.ComboBox cmbAllineamento)
        {
            string[] wdA = (string[])Enum.GetNames(typeof(WdParagraphAlignment));
            foreach (string sottolineato in wdA)
            {
                cmbAllineamento.Items.Add(sottolineato.Substring(16));
            }
            cmbAllineamento.SelectedIndex = 0;
        }

        public void impostaColore(System.Windows.Forms.ComboBox cmbColore)
        {
            string[] wdC = (string[])Enum.GetNames(typeof(WdColor));
            foreach (string colore in wdC)
            {
                cmbColore.Items.Add(colore.Substring(7));
            }
            cmbColore.SelectedIndex = 0;
        }

        public void impostaTabella(System.Windows.Forms.ComboBox cmbRighe, System.Windows.Forms.ComboBox cmbColonne)
        {
            for (int i = 1; i < 6; i++)
            {
                cmbRighe.Items.Add(i.ToString());
                cmbColonne.Items.Add(i.ToString());
            }
            cmbRighe.SelectedIndex = 1;
            cmbColonne.SelectedIndex = 1;
        }

        public Table creaTabella(object start, object end, int r, int c)
        {
            Table myTable;
            Range myRange = myDoc.Range(ref start, ref end);
            myTable = myDoc.Tables.Add(myRange, r, c);
            myTable.Borders.Enable = 1;
            return myTable;
        }

        public void scriviCella(Table tabella, int r, int c, string testo,
        WdColor cellColor = WdColor.wdColorWhite,
            WdCellVerticalAlignment cellVerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter,
            WdParagraphAlignment paragraphAlignment = WdParagraphAlignment.wdAlignParagraphCenter,
            WdColor colore = WdColor.wdColorBlack, bool bold = false, int size = 12)
        {
            tabella.Cell(r, c).Range.Text = testo;
            tabella.Cell(r, c).Range.Shading.BackgroundPatternColor = cellColor;
            tabella.Cell(r, c).Range.Cells.VerticalAlignment = cellVerticalAlignment;
            tabella.Cell(r, c).Range.Paragraphs.Alignment = paragraphAlignment;
            tabella.Cell(r, c).Range.Bold = Convert.ToInt32(bold);
            tabella.Cell(r, c).Range.Font.Color = colore;
            tabella.Cell(r, c).Range.Font.Size = size;
        }

        public void creaPDF(string path, bool v)
        {
            myDoc.ExportAsFixedFormat(path, WdExportFormat.wdExportFormatPDF, v);
        }

        public void stampa()
        {
            myDoc.PrintOut();
        }

        public void salvaChiudi(string nomeFile = "")
        {
            if (nomeFile == "")
                myDoc.Save();//se il documento non è ancora salvato apre la finestra di dialogo
            else
                myDoc.SaveAs2(nomeFile);
            //myDoc.Saved = true; //da impostare se volessi chiudere word senza salvare
            myDoc.Close(); //chiude il documento
            myWord.Quit(); //chiude applicazione
        }

        public void chiudi()
        {
            myDoc.Saved = true; //da impostare se volessi chiudere word senza salvare
            myDoc.Close(); //chiude il documento
            myWord.Quit(); //chiude applicazione
        }

        public void apriDocumento(string path, bool visible)
        {
            //istanzio applicazione word
            myWord = new Application();
            //la rendo visibile
            myWord.Visible = visible;
            myDoc = myWord.Documents.Open(path);
        }

        public bool controllaRange(object start, object end)
        {
            int Istart, Iend, Iend1;
            bool esito = false;
            object start1 = 0;
            object end1 = 0;
            this.impostaRange(ref start1, ref end1);
            Iend1 = Convert.ToInt32(end1);
            Istart = Convert.ToInt32(start);
            Iend = Convert.ToInt32(end);

            if ((Istart >= 0) && (Istart <= Iend) && (Iend <= Iend1))
                esito = true;
            return esito;
        }

        public string selezionaTesto(object start, object end)
        {
            string testo = "";
            Range myRange = myDoc.Range(ref start, ref end);
            myRange.Select();
            testo = myRange.Text;
            return testo;
        }

        public bool ricercaTesto(string testoDaRicercare, ref object start, ref object end, bool sostituire = false, string testoDaSostituire = "")
        {
            bool trovato = false;
            object findText = testoDaRicercare;
            object replaceText = testoDaSostituire;
            object ms = System.Type.Missing; //da utilizzare in caso di parametro mancante
            //
            myWord.Selection.Find.ClearFormatting(); //senza distinzione maiuscole minuscole
            myWord.Selection.Find.Replacement.ClearFormatting();
            //
            myWord.Selection.Start = myDoc.Content.Start; //mi posiziono all'inizio della prima frase prima di fare la ricerca
            myWord.Selection.End = myDoc.Content.End;
            //
            if (sostituire)
            {
                if (myWord.Selection.Find.Execute(ref findText, ref ms,
                    ref ms, ref ms, ref ms, ref ms, ref ms, ref ms, ref ms,
                    ref replaceText, WdReplace.wdReplaceAll))
                {
                    trovato = true;
                }
                else
                {
                    trovato = false;
                }
            }
            else
            {
                if (myWord.Selection.Find.Execute(ref findText))
                {
                    //N.B. trova solo la prima occorrenza, dovrei fare un while
                    //myWord.Selection.Font.Underline = WdUnderline.wdUnderlineSingle;
                    trovato = true;
                }
                else
                {
                    trovato = false;
                }
            }
            if (trovato)
            {
                start = myWord.Selection.Start;
                end = myWord.Selection.End;
            }
            return trovato;
        }

        public void inserisciTextBox(object start, object end, string nome, string messaggio)
        {
            Range myRange = myDoc.Range(ref start, ref end);
            //creo il controllo
            ContentControl cc;
            //lo aggiungo alla collection dei contentControl
            cc = myRange.ContentControls.Add(
                WdContentControlType.wdContentControlText);
            cc.Title = nome;
            cc.Range.Text = messaggio;//placeHolder
        }

        public void inserisciCheckBox(object start, object end, string nome, bool check = false)
        {
            Range myRange = myDoc.Range(ref start, ref end);
            //creo il controllo
            ContentControl cc;
            //lo aggiungo alla collection dei contentControl
            cc = myRange.ContentControls.Add(
                WdContentControlType.wdContentControlCheckBox);
            cc.Title = nome;
            cc.Checked = check;
        }

        public void inserisciComboBox(object start, object end, string nome, string[] testo, string[] valore)
        {
            Range myRange = myDoc.Range(ref start, ref end);
            //creo il controllo
            ContentControl cc;
            //lo aggiungo alla collection dei contentControl
            cc = myRange.ContentControls.Add(
                WdContentControlType.wdContentControlComboBox);
            cc.Title = nome;
            for (int i = 0; i < testo.Length; i++)
            {
                cc.DropdownListEntries.Add(
                    testo[i], valore[i], i);
            }
        }

        public void proteggiDocumento(object pwd)
        {
            myDoc.Protect(
                WdProtectionType.wdAllowOnlyFormFields, Type.Missing, ref pwd);
        }

        public void sproteggiDocumento(object pwd)
        {
            myDoc.Unprotect(ref pwd);
        }

        public bool leggiCheckBox(string nome)
        {
            bool check = false;
            int i = 1;
            bool trovato = false;
            if (myDoc.ContentControls.Count > 0)
            {
                while (!trovato && i <= myDoc.ContentControls.Count)
                {
                    ContentControl cc = myDoc.ContentControls[i];
                    if (cc.Title == nome)
                    {
                        check = cc.Checked;
                        trovato = true;
                    }
                    else
                        i++;
                }
            }
            return check;
        }

        public String leggiTextBox(string nome)
        {
            string testo = "";
            int i = 1;
            bool trovato = false;
            if (myDoc.ContentControls.Count > 0)
            {
                while (!trovato && i <= myDoc.ContentControls.Count)
                {
                    ContentControl cc = myDoc.ContentControls[i];
                    if (cc.Title == nome)
                    {
                        testo = cc.Range.Text;
                        trovato = true;
                    }
                    else
                        i++;
                }
            }
            return testo;
        }

        public string leggiCombobox(string nome)
        {
            string testo = "";
            int i = 1;
            bool trovato = false;
            if (myDoc.ContentControls.Count > 0)
            {
                while (!trovato && i <= myDoc.ContentControls.Count)
                {
                    ContentControl cc = myDoc.ContentControls[i];
                    if (cc.Title == nome)
                    {
                        testo = cc.Range.Text;
                        trovato = true;
                    }
                    else
                        i++;
                }
            }
            return testo;
        }
    }
}
