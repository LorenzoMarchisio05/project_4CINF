namespace Es12_Interfacce
{
    public interface IPersona
    {
        string Cognome { get; set; }
        string Nome { get; set; }

        string visualizza();
    }
}