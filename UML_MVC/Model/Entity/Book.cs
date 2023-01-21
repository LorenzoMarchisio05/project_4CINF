namespace Model.Entity
{
    public sealed class Book
    {
        public string Id { get; }
        public string Title { get; }
        public string Author { get; }
        public Publisher Publisher { get; }

        public Book(string title, string author, Publisher publisher)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
        }

        public override string ToString() => 
            $"Id: {Id} Title: {Title} Author: {Author} Publisher: {Publisher}";
    }
}