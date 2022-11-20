using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es11_Events
{
    public partial class frmMain : Form
    {
        private int numeroGiri;

        private delegate void reachedLimit();
        private event reachedLimit reachedLimitEvent;

        private delegate void aggiorna(ref int numeroGiri);

        public const int INCREMENTO_GIRI = 1000;
        private static aggiorna aggiornaHandler;

        public frmMain()
        {
            InitializeComponent();

            timer1.Interval = 1000;
        }


        public void handleCambioGiri(object sender, EventArgs e)
        {
            string tipoOperazione = (sender as Button).Text.ToLower();

            if (tipoOperazione == "accellera")
            {
                aggiornaHandler = incrementa;
            }
            else
            {
                aggiornaHandler = decrementa; 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            aggiornaHandler?.Invoke(ref numeroGiri);
        }

        private void incrementa(ref int giri)
        {
            giri += INCREMENTO_GIRI;
        }

        private void decrementa(ref int giri)
        {
            giri -= INCREMENTO_GIRI;
        }

        private void changeProgressBarState()
        {
            pbVelocità.Value = numeroGiri;
            if(numeroGiri >= pbVelocità.Value)
            {
                
            }
        }
    }
}
