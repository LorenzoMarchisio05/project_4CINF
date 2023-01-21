namespace Model.Interfaces
{
    public interface IUser
    {
        string Id { get; }
        string Password { get; }
        string Name { get; }
        string Surname { get; }
        string FullName { get; }
    }
}