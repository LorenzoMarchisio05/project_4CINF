namespace Es12_Interfacce
{
    public interface ICartaIdentita
    {
        string Comune { get; set; }
        string DataRilascio { get; set; }
        string NumeroCI { get; set; }

        string visualizza();
    }
}