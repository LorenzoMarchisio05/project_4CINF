using System.Linq;
using System.Runtime.InteropServices;
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

            dgvCaseEditrici.DataSource = _publisherController.GetAllPublisher();
        }

        private void dgvCaseEditrici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            var resultCE = _publisherController.GetPublisherByIndex(index);

            if(!resultCE.Ok)
            {
                MessageBox.Show(resultCE.Error);
                return;
            }

            var books = _booksController.GetBooksFromPublisher(resultCE.Data.IdCe);

            dgvLibri.DataSource = null;
            dgvLibri.DataSource = books;

        }

        private void btnCRUDLibri_Click(object sender, System.EventArgs e)
        {
            var idsCe = _publisherController.GetAllPublisher().Select(publisher => publisher.IdCe).ToList();

            new CRUDLibri(_booksController, idsCe).ShowDialog();
        }
    }
}
