using Controllers;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class CRUDLibri : Form
    {
        private readonly BooksController _booksController;
        public CRUDLibri(BooksController booksController, IEnumerable<string> idsCe)
        {
            InitializeComponent();

            _booksController = booksController;

            cmbCaseEditrici.DataSource = null;
            cmbCaseEditrici.DataSource = idsCe;

            ShowBooks();
        }

        private void ShowBooks()
        {
            dgv.DataSource = null;
            dgv.DataSource = _booksController.GetAllBooks();
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            var book = new Book
            {
                Autore = txtAutore.Text,
                IdLibro = txtId.Text,
                Titolo = txtTitolo.Text,
                idCe = cmbCaseEditrici.Text
            };


            MessageBox.Show(_booksController.TryAddBook(book) ?
                "Libro aggiunto con successo" :
                "Errore aggiunta libro");

            ShowBooks();
        }

        private void btnRimuovi_Click(object sender, EventArgs e)
        {
            var idLibro = dgv.SelectedRows[0].Cells[0];

            _booksController.TryRemoveBook(idLibro);
        }
    }
}
