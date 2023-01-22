using Model.Generators;
using Model.Interfaces;

namespace Model.Entity
{
    public sealed class Manager : IAdministrator
    {
        public string Id { get; }
        public string Password { get; }
        public string Name { get; }
        public string Surname { get; }
        public double Salary { get; }
        public string FullName  => $"{Name} {Surname}";

        public Manager(string password, string name, string surname, double salary)
        {
            Id = IdGenerator.Generate();
            Password = password;
            Name = name;
            Surname = surname;
            Salary = salary;
        }

        public override string ToString() => 
            $"Id: {Id} Fullname: {FullName} Password: {Password} Salary: {Salary}";
    }
}