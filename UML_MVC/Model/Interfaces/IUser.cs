namespace Model.Interfaces
{
    public interface IUser
    {
        string UserCode { get; }
        string Password { get; }
        string Name { get; }
        string Surname { get; }
        string FullName { get; }
    }
}