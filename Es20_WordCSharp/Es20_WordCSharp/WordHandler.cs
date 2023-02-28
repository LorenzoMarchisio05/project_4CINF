using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace WordCSharp
{
    public sealed class WordHandler
    {
        /// <summary>
        /// Applicazione word
        /// </summary>
        private Application application;

        /// <summary>
        /// Documento word
        /// </summary>
        private Document document;

        private void OpenWord(bool visible = true)
        {
            application = new Application
            {
                Visible = visible
            };
        }
        
        public void CreateDocument(bool visible = true)
        {
            // istanzio applicazione word
            if(application is null)
            {
                OpenWord();
            }
           
            document = new Document();
            document = application.Documents.Add();
        }

        public List<string> GetFonts() => FontFamily.Families
            .Select(family => family.Name)
            .ToList();

        public List<string> GetSizes()
        {
            var sizes = new float[100];
            sizes[0] = 8;
            for(int i = 1; i < sizes.Length; i++)
            {
                sizes[i] = sizes[i - 1] + 0.5f;
            }
            return sizes
                .Select(size => size.ToString())
                .ToList();
        }

        public List<string> GetMofiers() => Enum
            .GetNames(typeof(WdUnderline))
            .Select(type => type.Substring(11))
            .ToList();

        public List<string> GetTextAlignments() => Enum
            .GetNames(typeof(WdParagraphAlignment))
            .Select(type => type.Substring(16))
            .ToList();

        public List<string> GetTextColors() => Enum
           .GetNames(typeof(WdColor))
           .Select(type => type.Substring(7))
           .ToList();

        public List<string> GetTable() => Enumerable
                .Range(1, 5)
                .Select(count => count.ToString())
                .ToList();

        #region word operations

        public void SetRange(ref object start, ref object end)
        {
            start = document.Sentences[document.Sentences.Count].End - 1;
            end = document.Sentences[document.Sentences.Count].End;
        }

        public void InsertText(
            string text,
            object start,
            object end,
            string newLine = "",
            string font = "Arial",
            string size = "8",
            string underline = "None",
            string align = "Left",
            bool bold = false,
            bool italic = false,
            string color = "Black")
        {
            var range = document.Range(ref start, ref end);

            range.Font.Name = font;

            range.Font.Size = float.Parse(size);

            range.Underline = (WdUnderline)Enum.Parse(typeof(WdUnderline), $"wdUnderline{underline}");

            range.ParagraphFormat.Alignment = (WdParagraphAlignment)Enum.Parse(typeof(WdParagraphAlignment), $"wdAlignParagraph{align}");

            range.Bold = Convert.ToInt32(bold);

            range.Italic = Convert.ToInt32(italic);

            range.Font.Color = (WdColor)Enum.Parse(typeof(WdColor), $"wdColor{color}");

            range.Text = text + newLine; 
        }

        public void AppendText(string text, string newLine = "")
        {
            object start = 0,
                   end = 0;

            SetRange(ref start, ref end);

            InsertText(text, start, end, newLine);
        }

        #endregion

        #region word tables

        public Table InsertTable(object start, object end, int rowCount, int columnCount)
        {
            var range = document.Range(ref start, ref end);

            var table = document.Tables.Add(range, rowCount, columnCount);

            table.Borders.Enable = 1;

            return table;
        }

        public void WriteTableCell(
            Table table,
            int r,
            int c,
            string text,
            WdColor cellColor = WdColor.wdColorWhite,
            WdCellVerticalAlignment verticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter,
            WdParagraphAlignment paragraphAlignment = WdParagraphAlignment.wdAlignParagraphCenter,
            WdColor color = WdColor.wdColorBlack,
            bool bold = false,
            float size = 12f)
        {
            var range = table.Cell(r, c).Range;

            range.Cells.VerticalAlignment = verticalAlignment;

            range.Paragraphs.Alignment = paragraphAlignment;

            range.Bold = Convert.ToInt16(bold);

            range.Shading.BackgroundPatternColor = cellColor;

            range.Font.Color = color;

            range.Font.Size = size;

            range.Text = text;

        }

        #endregion

        public void createPDF(string path, bool open = false)
        {
            document.ExportAsFixedFormat(path, WdExportFormat.wdExportFormatPDF, open);
        }

        public void printDocument()
        {
            document.PrintOut();
        }

        public void SaveDocumentAndClose(string fileName = "")
        {
            SaveDocument(fileName);
            CloseDocument();
        }

        public void SaveDocument(string fileName = "")
        {
            if(fileName is "")
            {
                document.Save();
            }
            else
            {
                document.SaveAs2(fileName);
            }
        }

        public void CloseApplication()
        {
            application.Quit();
        }

        public void CloseDocument()
        {
            // da impostare se voglio chiudere word senza salvare
            document.Saved = true;
            document.Close();
        }

        public void OpenDocument(string path, bool visible = true)
        {
            if(application is null)
            {
                OpenWord(visible);
            }
            document = application.Documents.Open(path);
        }

        public bool DoRangeExist(int start, int end)
        {
            object start_obj = 0, end_obj = 0;
            this.SetRange(ref start_obj, ref end_obj);

            return (start <= end)  
                && (end <= Convert.ToInt32(end_obj))
                && (start >= 0);
        }

        public string SelectTextFromTo(object start, object end)
        {
            var range = document.Range(ref start, ref end);
            range.Select();
            return range.Text;
        }

        public string GetTextFromTo(object start, object end) => document
            .Range(ref start, ref end)
            .Text;

        public bool SearchAndReplaceText(
            object searchText,
            ref object start,
            ref object end,
            object replacementText = null)
        {
            object missing = Type.Missing;

            var find = application.Selection.Find;

            // tolgo formattazione, ricerca e sostituzione insensitive
            find.ClearFormatting();
            find.Replacement.ClearFormatting();

            application.Selection.Start = document.Content.Start;


            if (!(replacementText is null))
            {
                 find.Execute(
                    ref searchText,
                    missing, missing, missing, missing,
                    missing, missing, missing, missing,
                    ref replacementText,
                    WdReplace.wdReplaceAll);
            }
            else
            {
                find.Execute(ref searchText);
            }

            if(find.Found)
            {
                start = application.Selection.Start;
                end = application.Selection.End;
            }

            return find.Found;
        }

        #region Moduli

        public void AddTextBox(object start, object end, string name, string placeholder = "")
        {

            var range = document.Range(ref start, ref end);

            ContentControl textbox = document
                .ContentControls
                .Add(WdContentControlType.wdContentControlText, range);


            textbox.Title = name;
            textbox.Range.Text = placeholder;
        }

        public void AddChekBox(object start, object end, string name)
        {
            var range = document.Range(ref start, ref end);

            ContentControl checkbox = document
                .ContentControls
                .Add(WdContentControlType.wdContentControlCheckBox, range);

            checkbox.Title = name;
        }

        public void AddComboBox(object start, object end, string name, Dictionary<string, string> options)
        {
            var range = document.Range(ref start, ref end);

            ContentControl combobox = document
                .ContentControls
                .Add(WdContentControlType.wdContentControlComboBox, range);

            combobox.Title = name;

            int i = 0;
            foreach(var keyValues in options)
            {
                combobox.DropdownListEntries.Add(keyValues.Value, keyValues.Key, i);
                i++;
            }
        }

        public void ProtectDocument(object password)
        {
            document.Protect(WdProtectionType.wdAllowOnlyFormFields, Type.Missing, password);
        }

        public void UnProtectDocument(object password)
        {
            document.Unprotect(ref password);
        }

        public IReadOnlyDictionary<string, string> ReadAllModulesData()
        {
            var titleTextData = new Dictionary<string, string>(document.ContentControls.Count);
            
            foreach (ContentControl control in document.ContentControls)
            {
                titleTextData.Add(
                        control.Title,
                        control.Range.Text
                    );
            }

            return titleTextData;
        }

        public IReadOnlyDictionary<string, string> ReadAllModulesDataOfType<TContentControlType>()
        {
            var contentControls = document.ContentControls.OfType<TContentControlType>();
            var titleTextData = new Dictionary<string, string>(contentControls.Count());

            foreach (ContentControl control in contentControls)
            {
                titleTextData.Add(
                        control.Title,
                        control.Range.Text
                    );
            }

            return titleTextData;
        }

        public string ReadDataByName(string name)
        {
            foreach(ContentControl control in document.ContentControls)
            {
                if(control.Title == name)
                {
                    return control.Range.Text;
                }
            }

            return "";
        }

        #endregion
    }
}
