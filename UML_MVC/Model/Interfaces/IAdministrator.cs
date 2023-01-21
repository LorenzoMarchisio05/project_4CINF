namespace Model.Interfaces
{
    public interface IAdministrator : IUser
    {
        double Salary { get; }
    }
}