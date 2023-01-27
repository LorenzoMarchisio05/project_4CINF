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

        private void btnNewDocument_Click(object sender, EventArgs e)
        {
            _wordHandler.CreateDocument();
        }

        private void btnInsertText_Click(object sender, EventArgs e)
        {
            object start = 0,
                   end = 0;
            _wordHandler.InsertText(start, end, txtText.Text);
        }
    }
}
