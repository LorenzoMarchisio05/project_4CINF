using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WordCSharp;
using Microsoft.Office.Interop.Word;

namespace Es20_WordCSharp
{
    public partial class Form : System.Windows.Forms.Form
    {
        private WordHandler _wordHandler;

        public Form()
        {
            InitializeComponent();

            _wordHandler = new WordHandler();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            cmbFont.DataSource = null;
            cmbFont.DataSource = _wordHandler.GetFonts();
            cmbSize.DataSource = null;
            cmbSize.DataSource = _wordHandler.GetSizes();
            cmbModifiers.DataSource = null;
            cmbModifiers.DataSource = _wordHandler.GetMofiers();
            cmbTextAlign.DataSource = null;
            cmbTextAlign.DataSource = _wordHandler.GetTextAlignments();
            cmbColor.DataSource = null;
            cmbColor.DataSource = _wordHandler.GetTextColors();
            cmbRighe.DataSource = null;
            cmbRighe.DataSource = _wordHandler.GetTable();
            cmbColonne.DataSource = null;
            cmbColonne.DataSource = cmbRighe.DataSource;

            cmbRighe.SelectedIndex = cmbColonne.SelectedIndex = 1;
        }

        private void btnNewDocument_Click(object sender, EventArgs e)
        {
            _wordHandler.CreateDocument();
        }

        private void btnInsertText_Click(object sender, EventArgs e)
        {
            object start = 0,
                   end = 0;

            _wordHandler.SetRange(ref start, ref end);

            _wordHandler.InsertText(
                txtText.Text,
                start, 
                end, 
                "\n", 
                cmbFont.Text, 
                cmbSize.Text, 
                cmbModifiers.Text,
                cmbTextAlign.Text,
                chkBold.Checked,
                chkItalic.Checked,
                cmbColor.Text);
        }

        private void btnInsertTable_Click(object sender, EventArgs e)
        {
            object start = 0,
                   end = 0;
            int r = int.Parse(cmbRighe.Text),
                c = int.Parse(cmbColonne.Text);

            _wordHandler.SetRange(ref start, ref end);

            // nb: i need to put a \n to not aggregate to the previous table
            var table = _wordHandler.InsertTable(start, end, r, c);
            _wordHandler.AppendText("\n");

            _wordHandler.WriteTableCell(table,
                r,
                c,
                "testo",
                WdColor.wdColorRose,
                WdCellVerticalAlignment.wdCellAlignVerticalTop,
                WdParagraphAlignment.wdAlignParagraphRight,
                WdColor.wdColorBlack,
                true,
                25);
        }

        private void btnCreatePdf_Click(object sender, EventArgs e)
        {
            string path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\prova.pdf";
            _wordHandler.createPDF(path, true);
        }

        private void btnSaveDoc_Click(object sender, EventArgs e)
        {
            string path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\prova.docx";
            _wordHandler.SaveDocumentAndClose(path);
        }

        private void btnPrintDocument_Click(object sender, EventArgs e) => _wordHandler.printDocument();
    }
}
