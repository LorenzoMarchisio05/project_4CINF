using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using Model.DTO;
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

        public bool TryAddBook(Book book)
        {
            try
            {
                books.Add(book);
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }
        
        public bool TryAddBooks(IEnumerable<Book> books)
        {
            try
            {
                this.books.AddRange(books);
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }

        public bool TryRemoveBook(Book book) => 
            books.Remove(book);

        public IReadOnlyList<Book> GetAllBooks() => books.AsReadOnly();

        public IReadOnlyList<Book> GetBooksFromPublisher(string pubblisherId) => books
                .Where(book => book.Publisher.Id == pubblisherId)
                .ToList()
                .AsReadOnly();

        public Result<int> BuyBook(string bookId)
        {
            Book book = books.FirstOrDefault(b => b.Id == bookId);

            return book is null ? 
                Result<int>.Fail("No books found") : 
                Result<int>.Success(10);
        }

    }
}