namespace Es12_Interfacce.Interface
{
    public interface IPersona
    {
        string Cognome { get; set; }
        string Nome { get; set; }

        string visualizza();
    }
}