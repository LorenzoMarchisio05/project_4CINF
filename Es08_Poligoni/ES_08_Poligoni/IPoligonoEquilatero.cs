namespace Es08_Poligoni
{
    public interface IPoligonoEquilatero
    {
        double LunghezzaLato { get; set; }
        int NumeroLati { get; set; }
        double Perimetro { get; }

        double area();
    }
}