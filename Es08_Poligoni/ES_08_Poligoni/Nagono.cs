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
    public class Nagono : PoligonoEquilatero
    {
        private double apotema = -1;

        public Nagono(int numeroLati, double lunghezzaLato) : base(throwIfInvalidSides(numeroLati), lunghezzaLato)
        {
            this.apotema = calcolaApotema();
        }

        public double Apotema
        {
            get => apotema == -1 ? calcolaApotema() : apotema;

            set
            {
                if (calcolaApotema() != value)
                {
                    throw new ArgumentException("invalid apothema value");
                }

                apotema = value;
            }
        }

        private double calcolaApotema() => lunghezzaLato * Math.Tan(
                (Math.PI * (numeroLati - 2)) / (2 * numeroLati)
            ) / 2;

        public override double area() => Math.Round(Perimetro * apotema / 2, 2);

        private static int throwIfInvalidSides(int numeroLati) => numeroLati > 4 ? 
                                            numeroLati : 
                                            throw new ArgumentException("sides number can't be less than 5 ");

    }
}
