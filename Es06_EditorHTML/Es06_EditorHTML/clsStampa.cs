using System.Drawing;
using System.Drawing.Printing;
using System.Threading;
using System.Windows.Forms;

namespace Es06_EditorHTML
{
    public sealed class clsStampa
    {
        #region costants

        // 1 unit = 1/100 inch ( 0,254mm )
        private const int InlineMargin = 79;

        private const int BlockMargin = 100;

        #endregion


       // Documento stampa
        private readonly PrintDocument _printDocument;


        // Finestre di dialogo
        private readonly PageSetupDialog _pageSetupDialog;

        private readonly PrintDialog _printDialog;

        private readonly PrintPreviewDialog _printPreviewDialog;


        // user settings
        private string _userText;

        private Font _userFont;



        public clsStampa()
        {
            _printDocument = new PrintDocument();

            _pageSetupDialog = new PageSetupDialog();

            _printDialog = new PrintDialog();

            _printPreviewDialog = new PrintPreviewDialog();

            // imposto parametri di default
            initDefaultParameters();

            _printDocument.PrintPage += printDocument_PrintPage;
        }

        public void ImpostaPagina()
        {
            _pageSetupDialog.ShowDialog();
            /*
             * In corrispondenza dell'ok i valori impostati vengono
             * automaticamente copiati dentro il printDocument
             */
        }


        public void Anteprima(string text, Font font)
        {
            _userText = text;
            _userFont = font;

            _printPreviewDialog.ShowDialog();
        }


        public void Stampa(string text, Font font)
        {
            _userText = text;
            _userFont = font;

            // L'utente può decidere se stampare o annullare
            if (_printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                _printDocument.Print();
            }
        }


        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            /*
             * la ppagina di stampa è vista come un oggetto grafico 
             * sul quale posso agire con le GDI+
             */

            SolidBrush brush = new SolidBrush(Color.Black);

            int left = _printDocument.DefaultPageSettings.Margins.Left;
            int top = _printDocument.DefaultPageSettings.Margins.Top;
            int width = _printDocument.DefaultPageSettings.PaperSize.Width;
            int height = _printDocument.DefaultPageSettings.PaperSize.Height;

            Rectangle rectangle = new Rectangle(
                left,
                top,
                width,
                height
                );

            e.Graphics.DrawString(_userText, _userFont, brush, rectangle);

            // per disegnare il rettangolo 
            Pen pen = new Pen(Color.Red, 2);
            e.Graphics.DrawRectangle(pen, rectangle);

        }


        private void initDefaultParameters()
        {

            // setting margins 
            _printDocument
                .DefaultPageSettings
                .Margins
                .Left = InlineMargin;

            _printDocument
                .DefaultPageSettings
                .Margins
                .Right = InlineMargin;

            _printDocument
                .DefaultPageSettings
                .Margins
                .Top = BlockMargin;

            _printDocument
                .DefaultPageSettings
                .Margins
                .Bottom = BlockMargin;

            // setting copies count
            _printDocument
                .PrinterSettings
                .Copies = 1;


            // linking commond dialog with print document
            _pageSetupDialog.Document = _printDocument;

            _printPreviewDialog.Document = _printDocument;

            _printDialog.Document = _printDocument;

            _pageSetupDialog.EnableMetric = true;
        }


    }
}
