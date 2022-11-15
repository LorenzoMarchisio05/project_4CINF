using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es08_Poligoni
{
    public class Triangolo : PoligonoEquilatero
    {
        public Triangolo(double lunghezzaLato) : base(3, lunghezzaLato)
        {
        }

        public override double area() => Math.Round(((Math.Sqrt(3) / 4) * Math.Pow(lunghezzaLato, 2)), 2);
    }
}
