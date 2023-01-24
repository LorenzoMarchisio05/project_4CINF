namespace Model.Entity
{
    public sealed class PremiumManager : Manager
    {
        protected override double SalaryMultiplier => 1.75;

        public PremiumManager(string userCode, string password, string name, string surname, double salary) : base(userCode, password, name, surname, salary)
        {
        }
    }
}