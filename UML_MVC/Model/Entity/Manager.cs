
using Model.Interfaces;

namespace Model.Entity
{
    public abstract class Manager : IAdministrator
    {
        public string UserCode { get; }
        public string Password { get; }
        public string Name { get; }
        public string Surname { get; }
        public double Salary { get; }
        public string FullName  => $"{Name} {Surname}";
        protected abstract double SalaryMultiplier { get; }

        public Manager(string userCode, string password, string name, string surname, double salary)
        {
            UserCode = userCode;
            Password = password;
            Name = name;
            Surname = surname;
            Salary = salary;
        }

        public override string ToString() => 
            $"UserCode: {UserCode} Fullname: {FullName} Password: {Password} Salary: {Salary}";
    }
}