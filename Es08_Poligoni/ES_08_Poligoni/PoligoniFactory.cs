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
    public sealed class PoligoniFactory 
    {
        private static PoligoniFactory _instance = null;
        private PoligoniFactory()
        {
        }

        public static PoligoniFactory Instance
        {
            get
            {
                if(_instance is null)
                {
                    _instance = new PoligoniFactory();
                }
                return _instance;
            }
        }


        public IPoligonoEquilatero create(int numeroLati, double lunghezzaLato)
        {
            if (numeroLati < 3)
            {
                throw new ArgumentOutOfRangeException("sides number can't be less than 3");
            }

            return getPoligono(numeroLati, lunghezzaLato);
        }

        private IPoligonoEquilatero getPoligono(int numeroLati, double lunghezzaLato)
        {
            IPoligonoEquilatero poligono;
            switch (numeroLati)
            {
                case 3:
                    poligono = new Triangolo(lunghezzaLato);
                    break;
                case 4:
                    poligono = new Quadrato(lunghezzaLato);
                    break;
                default:
                    poligono = new Nagono(numeroLati, lunghezzaLato);
                    break;
            }

            return poligono;
        }
    }
}
