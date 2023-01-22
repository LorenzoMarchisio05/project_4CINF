using Model.Generators;
using Model.Interfaces;

namespace Model.Entity
{
    public sealed class ShopAssistant : IAdministrator
    {
        public string Id { get; }
        public string Password { get; }
        public string Name { get; }
        public string Surname { get; }
        public double Salary { get; }
        public string NickNamme { get; }
        public string FullName  => $"{Name} {Surname}";

        public ShopAssistant(string password, string name, string surname, string nickNamme, double salary)
        {
            Id = IdGenerator.Generate();
            Password = password;
            Name = name;
            Surname = surname;
            NickNamme = nickNamme;
            Salary = salary;
        }

        public override string ToString() => 
            $"Id: {Id} Fullname: {FullName} Nickname: {NickNamme} Password: {Password} Salary: {Salary}";
    }
}