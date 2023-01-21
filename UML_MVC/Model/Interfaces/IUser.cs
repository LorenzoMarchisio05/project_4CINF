namespace Model.Interfaces
{
    public interface IUser
    {
        string Id { get; }
        string Password { get; }
        string Nome { get; }
        string Cognome { get; }
    }
}