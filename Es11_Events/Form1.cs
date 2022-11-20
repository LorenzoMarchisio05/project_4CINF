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

        private delegate void reachedLimit(string msg);
        private event reachedLimit ReachedLimit;

        private delegate void aggiorna(ref int numeroGiri);

        public const int INCREMENTO_GIRI = 1000;
        private static aggiorna aggiornaHandler;

        public frmMain()
        {
            InitializeComponent();

            timer1.Interval = 1000;

            this.ReachedLimit += reachedLimitEventHandler;

            this.btnAccellera.Click += handleCambioGiri;
            this.btnFrena.Click += handleCambioGiri;
        }


        public void handleCambioGiri(object sender, EventArgs e)
        {
            string tipoOperazione = (sender as Button).Text.ToLower();
            
            timer1.Stop();
            timer1.Start();

            if (tipoOperazione == "accellera")
            {
                aggiornaHandler = incrementa;
            }
            else
            {
                aggiornaHandler = decrementa; 
            }
        }

        private void reachedLimitEventHandler(string message)
        {
            MessageBox.Show(message);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            aggiornaHandler?.Invoke(ref numeroGiri);
        }

        private void incrementa(ref int giri)
        {
            giri += INCREMENTO_GIRI;
            changeProgressBarState();
        }

        private void decrementa(ref int giri)
        {
            giri -= INCREMENTO_GIRI;
            changeProgressBarState();
        }

        private void changeProgressBarState()
        {
            pbVelocità.Value = numeroGiri;
            if(numeroGiri >= pbVelocità.Maximum)
            {
                ReachedLimit?.Invoke("Giri troppo alti");
                timer1.Stop();
            }
            else
            {
                ReachedLimit?.Invoke("Giri troppo bassi");
                timer1.Stop();
            }
            
        }
    }
}
