using System.Collections.Generic;
using System.Linq;
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

        public IReadOnlyList<Book> GetBooksFromPublisher(string pubblisherId) => books
                .Where(book => book.Publisher.Id == pubblisherId)
                .ToList()
                .AsReadOnly();

    }
}