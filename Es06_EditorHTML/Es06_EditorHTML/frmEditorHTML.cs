using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public frmEditorHTML()
        {
            InitializeComponent();
            filemanager = new clsFile();
        }

        private void frmEditorHTML_Load(object sender, EventArgs e)
        {

        }
    }
}
