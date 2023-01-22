using Model.Generators;
using Model.Interfaces;

namespace Model.Entity
{
    public sealed class ShopAssistant : IAdministrator
    {
        public string UserCode { get; }
        public string Password { get; }
        public string Name { get; }
        public string Surname { get; }
        public double Salary { get; }
        public string NickNamme { get; }
        public string FullName  => $"{Name} {Surname}";

        public ShopAssistant(string userCode, string password, string name, string surname, string nickNamme, double salary)
        {
            UserCode = userCode;
            Password = password;
            Name = name;
            Surname = surname;
            NickNamme = nickNamme;
            Salary = salary;
        }

        public override string ToString() => 
            $"UserCode: {UserCode} Fullname: {FullName} Nickname: {NickNamme} Password: {Password} Salary: {Salary}";
    }
}