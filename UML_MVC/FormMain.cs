using System.Windows.Forms;
using Controllers;

namespace View
{
    public partial class frmMain : Form
    {
        private readonly PublisherController _publisherController;
        private readonly BooksController _booksController;
        
        public frmMain()
        {
            InitializeComponent();

            _publisherController = new PublisherController();
            _booksController = new BooksController();
        }

    }
}
