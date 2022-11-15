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
    public class Quadrato : PoligonoEquilatero
    {
        public Quadrato(double lunghezzaLato) : base(4, lunghezzaLato)
        {
        }

        public override double area() => Math.Round(lunghezzaLato * lunghezzaLato, 2);
    }
}
