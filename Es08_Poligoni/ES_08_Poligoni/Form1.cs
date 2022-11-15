using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es08_Poligoni
{
    public partial class Form1 : Form
    {
        private readonly PoligoniFactory poligoniFactory;
        public Form1()
        {
            InitializeComponent();
            poligoniFactory = PoligoniFactory.Instance;
        }

        private void throwIfFalse(bool condition , string message)
        {
            if (!condition) throw new Exception(message);
        }

        private void bntAreaPerimetro_Click(object sender, EventArgs e)
        {
            try
            {
                throwIfFalse(int.TryParse(txtNumeroLati.Text.Trim(), out int numeroLati), "error casting sides number");
                throwIfFalse(double.TryParse(txtLunghezzaLato.Text.Trim(), out double lunghezzaLato), "error casting side length");
                IPoligonoEquilatero poligono = poligoniFactory.create(numeroLati, lunghezzaLato);

                double area = poligono.area();
                double perimetro = poligono.Perimetro;

                MessageBox.Show($"Il perimetro del poligono è: {perimetro}\nL'area del poligono è: {area}");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
