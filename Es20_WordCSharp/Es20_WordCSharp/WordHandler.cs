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


        
        public void CreateDocument(bool visible = true)
        {
            // istanzio applicazione word
            application = new Application
            {
                Visible = visible
            };
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

            SetRange(ref start, ref start);

            InsertText(text, start, end, newLine);
        }

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
            string font = "Arial",
            string size = "8",
            string underline = "None",
            string align = "Left",
            bool bold = false,
            bool italic = false,
            string color = "Black")
        {
            var range = table.Cell(r, c).Range;


            range.Font.Name = font;

            range.Font.Size = float.Parse(size);

            range.Underline = (WdUnderline)Enum.Parse(typeof(WdUnderline), $"wdUnderline{underline}");

            range.ParagraphFormat.Alignment = (WdParagraphAlignment)Enum.Parse(typeof(WdParagraphAlignment), $"wdAlignParagraph{align}");

            range.Bold = Convert.ToInt32(bold);

            range.Italic = Convert.ToInt32(italic);

            range.Font.Color = (WdColor)Enum.Parse(typeof(WdColor), $"wdColor{color}");

            range.Text = text;


        }
    }
}
