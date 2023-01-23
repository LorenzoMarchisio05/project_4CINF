
using System.Security.Policy;

namespace Model.Entity
{
    public sealed class Book
    {
        public string IdLibro { get; set; }
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public string idCe { get; set; }



        public override string ToString() => 
            $"Id: {IdLibro} Title: {Titolo} Author: {Autore} Publisher ID: {idCe}";
    }
}