namespace Model.Entity
{
    public sealed class NormalManager : Manager
    {
        protected override double SalaryMultiplier => 1.25;

        public NormalManager(string userCode, string password, string name, string surname, double salary) : base(userCode, password, name, surname, salary)
        {
        }
    }
}