using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Model;
using Model.DTO;
using Model.Entity;
using Newtonsoft.Json;

namespace Controllers
{
    public sealed class BooksController
    {
        private readonly List<Book> books;

        public BooksController()
        {
            books = getData();
        }

        public bool TryAddBook(Book book)
        {
            try
            {
                books.Add(book);
                WriteBooksOnFile();

                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }

        private void WriteBooksOnFile()
        {
            using (StreamWriter sw = new StreamWriter("Libri.json"))
            {
                string json = JsonConvert.SerializeObject(books);
                sw.WriteLine(json);            
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

        public void RemoveBook(string id) => books
            .RemoveAt(books.FindIndex(book => book.IdLibro == id));

        public IReadOnlyList<Book> GetAllBooks() => books.AsReadOnly();

        public IReadOnlyList<Book> GetBooksFromPublisher(string pubblisherId) => books
                .Where(book => book.idCe == pubblisherId)
                .ToList()
                .AsReadOnly();

        public Result<int> BuyBook(string bookId)
        {
            Book book = books.FirstOrDefault(b => b.IdLibro == bookId);

            return book is null ? 
                Result<int>.Fail("No books found") : 
                Result<int>.Success(10);
        }

        private List<Book> getData()
        {
            try
            {
                string fileBuffer = File.ReadAllText("Libri.json");
                var books = JsonConvert.DeserializeObject<List<Book>>(fileBuffer);
                return books;
            }
            catch (Exception)
            {
                return null;
            }
            
        }

        public string GetFirstIdAvaiable()
        {
            var ids = books.Select(book => book.IdLibro).OrderBy(id => int.Parse(id));

            for(int i = 0; i < ids.Count() - 1; i++)
            {
                int id = int.Parse(ids.ElementAt(i));
                int idNext = int.Parse(ids.ElementAt(i + 1));

                if(idNext - 1 != id)
                {
                    return (idNext - 1).ToString();
                }
            }

            var idAviable = int.Parse(ids.Last()) + 1;
            return idAviable.ToString();
        }
    }
}