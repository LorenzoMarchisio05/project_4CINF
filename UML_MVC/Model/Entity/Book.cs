using Model.Generators;
using System.Security.Policy;

namespace Model.Entity
{
    public sealed class Book
    {
        public string Id { get; set; }
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public string idCe { get; set; }

        public Book()
        {
            Id = IdGenerator.Generate();
        }

        public override string ToString() => 
            $"Id: {Id} Title: {Titolo} Author: {Autore} Publisher ID: {idCe}";
    }
}