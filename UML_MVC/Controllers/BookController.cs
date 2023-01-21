using System.Collections.Generic;
using Model;
using Model.Entity;

namespace Controllers
{
    public sealed class BooksController
    {
        private readonly List<Book> books;

        public BooksController()
        {
            books = new List<Book>();
        }

        public IReadOnlyList<Book> GetAllBooks() => books.AsReadOnly();

    }
}