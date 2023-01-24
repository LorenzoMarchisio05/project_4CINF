namespace Model.Entity
{
    public sealed class VipManager : Manager
    {
        protected override double SalaryMultiplier => 2;

        public VipManager(string userCode, string password, string name, string surname, double salary) : base(userCode, password, name, surname, salary)
        {
        }
    }
}