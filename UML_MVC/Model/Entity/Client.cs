
using Model.Interfaces;

namespace Model.Entity
{
    public sealed class Client : IUser
    {
        public string UserCode { get; }
        public string Password { get; }
        public string Name { get; }
        public string Surname { get; }
        public string FullName  => $"{Name} {Surname}";

        public Client(string userCode, string password, string name, string surname)
        {
            UserCode = userCode;
            Password = password;
            Name = name;
            Surname = surname;
        }

        public override string ToString() => 
            $"UserCode: {UserCode} FullName: {FullName} Password: {Password}";
    }
}