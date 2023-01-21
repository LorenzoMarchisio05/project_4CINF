using Model.Interfaces;

namespace Model.Entity
{
    public sealed class Client : IUser
    {
        public string Id { get; }
        public string Password { get; }
        public string Name { get; }
        public string Surname { get; }
        public string FullName  => $"{Name} {Surname}";

        public Client(string password, string name, string surname)
        {
            Id = "...";
            Password = password;
            Name = name;
            Surname = surname;
        }

        public override string ToString() => 
            $"Id: {Id} FullName: {FullName} Password: {Password}";
    }
}