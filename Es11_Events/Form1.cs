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
        private event clsAuto.reachedLimit ReachedLimit;
        private static clsAuto.aggiorna aggiornaHandler;

        private clsAuto auto;

        public frmMain()
        {
            InitializeComponent();

            toggleMacchina(true);

            auto = new clsAuto();

            pbVelocità.Minimum = 0;

            pbVelocità.Value = auto.NumeroGiri;

            pbVelocità.Maximum = clsAuto.MAXGIRI;

            timer1.Interval = 1000;

            lblMarcia.Text = "N";

            this.ReachedLimit += reachedLimitEventHandler;

            this.btnAccellera.Click += handleCambioGiri;
            this.btnFrena.Click += handleCambioGiri;

            var dictionary = new Dictionary<string, int>();

            
        }


        public void handleCambioGiri(object sender, EventArgs e)
        {
            string tipoOperazione = (sender as Button).Text.ToLower();
            
            timer1.Stop();
            timer1.Start();

            if (tipoOperazione == "accellera")
            {
                aggiornaHandler = auto.incrementa;
            }
            else
            {
                aggiornaHandler = auto.decrementa; 
            }            
        }

        private void reachedLimitEventHandler(string message)
        {
            MessageBox.Show(message);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            aggiornaHandler?.Invoke();
            changeProgressBarState();
        }

        

        private void changeProgressBarState()
        {
            if(auto.NumeroGiri >= clsAuto.MAXGIRI)
            {
                timer1.Stop();
                ReachedLimit?.Invoke("Giri troppo alti");
            }
            else if(auto.NumeroGiri <= clsAuto.MINGIRI)
            {
                timer1.Stop();
                ReachedLimit?.Invoke("Giri troppo bassi");
            }
            pbVelocità.Value = auto.NumeroGiri;

            lblMarcia.Text = ((auto.NumeroGiri + auto.NumeroGiri % clsAuto.RANGE)/ clsAuto.RANGE).ToString();
        }

        private void btnAccendiMacchina_Click(object sender, EventArgs e)
        {
            toggleMacchina(false);
        }

        private void toggleMacchina(bool isOff)
        {
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl.Name == "btnAccendiMacchina")
                {
                    ctrl.Enabled = isOff;
                }
                else
                {
                    ctrl.Enabled = !isOff;
                }
            }
        }

        
    }
}
