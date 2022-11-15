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
    public abstract class PoligonoEquilatero : IPoligonoEquilatero
    {
        protected int numeroLati;
        protected double lunghezzaLato;

        public PoligonoEquilatero(int numeroLati, double lunghezzaLato)
        {
            this.NumeroLati = numeroLati;
            this.LunghezzaLato = lunghezzaLato;
        }

        public int NumeroLati
        {
            get => numeroLati;
            set
            {
                throwIfInvalid(value, "it can't have 0 or less sides");
                numeroLati = value;
            }
        }

        public double LunghezzaLato
        {
            get => lunghezzaLato;
            set
            {
                throwIfInvalid(value, "it cant be equal or less than 0");
                lunghezzaLato = value;
            }
        }

        public double Perimetro => lunghezzaLato * numeroLati;

        protected void throwIfInvalid(int value, string message)
        {
            if (value <= 0) throw new ArgumentException(message);
        }

        protected void throwIfInvalid(double value, string message)
        {
            if (value <= 0) throw new ArgumentException(message);
        }

        public abstract double area();

    }
}
