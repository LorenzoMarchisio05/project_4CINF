using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es10_Delegate
{
    public partial class frmMain : Form
    {
        private delegate double operationHandler(double a, double b);

        public frmMain()
        {
            InitializeComponent();
        }

        public void btnOperazione_Click(object sender, EventArgs e)
        {
            string tipoOperazione = (sender as Button).Text.ToLower();
            
            try
            {
                operationHandler operationHandler = initOperationHandler(tipoOperazione);

                checkNumber(txtNumero1.Text, out double numero1);

                checkNumber(txtNumero2.Text, out double numero2);

                double result = Math.Round(operationHandler.Invoke(numero1, numero2), 3);
                
                MessageBox.Show($"Result of {tipoOperazione} is {result}");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkNumber(string text, out double data)
        {
            if (!double.TryParse(text, out data)) throw new InvalidCastException($@"""{text}"" is not a number");
        }

        private operationHandler initOperationHandler(string tipoOperazione)
        {
            operationHandler operationHandler;
            switch (tipoOperazione)
            {
                case "somma":
                    operationHandler = somma;
                    break;
                case "sottrazione":
                    operationHandler = sottrazione;
                    break;
                case "divisione":
                    operationHandler = divisione;
                    break;
                case "prodotto":
                    operationHandler = moltiplicazione;
                    break;
                default:
                    throw new InvalidOperationException($@"Unsopported operation: ""{tipoOperazione}""");
            }

            return operationHandler;
        }


        private double somma(double a, double b) => a + b;

        private double sottrazione(double a, double b) => a - b;

        private double moltiplicazione(double a, double b) => a * b;

        private double divisione(double a, double b) => a / b;
    }
}
