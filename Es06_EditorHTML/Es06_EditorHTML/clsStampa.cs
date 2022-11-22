using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Es06_EditorHTML
{
    public sealed class clsStampa
    {
        #region costants

        // 1 unit = 1/100 inch ( 0,254mm )
        private const int INLINE_MARGIN = 79;

        private const int BLOCK_MARGIN = 100;

        #endregion

        

        private PrintDocument _printDocument;

        private PageSetupDialog _pageSetupDialog;

        private PrintDialog _printDialog;

        private PrintPreviewDialog _printPreviewDialog;



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
        }



        private void initDefaultParameters()
        {

            // setting margins 
            _printDocument
                .DefaultPageSettings
                .Margins
                .Left = INLINE_MARGIN;

            _printDocument
                .DefaultPageSettings
                .Margins
                .Right = INLINE_MARGIN;

            _printDocument
                .DefaultPageSettings
                .Margins
                .Top = BLOCK_MARGIN;

            _printDocument
                .DefaultPageSettings
                .Margins
                .Bottom = BLOCK_MARGIN;

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
