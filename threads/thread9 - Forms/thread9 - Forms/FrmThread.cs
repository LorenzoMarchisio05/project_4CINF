using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thread9___Forms
{
    public partial class FrmThread : Form
    {

        private static readonly CancellationTokenSource cts = new CancellationTokenSource();

        private const int MAX = 1000;

        private static Thread thClock;

        public FrmThread()
        {
            InitializeComponent();

            progressBar.Minimum = 0;
            progressBar.Maximum = MAX;

            timer.Interval = 1000;

            lblClock.Text = DateTime.Now.ToLongTimeString();

            thClock = new Thread(() => clockLogic(cts.Token));
        }

        private void clockLogic(CancellationToken cancellationToken)
        {
            while(!cancellationToken.IsCancellationRequested)
            {
                this.BeginInvoke(
                        new Action(() => lblClockThread.Text = DateTime.Now.ToLongTimeString())
                    );

                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void FrmThread_FormClosing(object sender, FormClosingEventArgs e)
        {
            cts.Cancel();
        }

        private void FrmThread_Load(object sender, EventArgs e)
        {
            timer.Start();
            thClock.Start();
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            writeFile();
        }

        private void writeFile()
        {
            using ( var sw = new StreamWriter("file.txt"))
            {
                for(int i = 0; i < MAX; i++)
                {
                    Thread.Sleep(5);
                    sw.Write("*");
                    progressBar.Value = i + 1;
                }
            }
        }

        private void btnSaveFileThread_Click(object sender, EventArgs e)
        {
            new Thread(() => writeFileThread(cts.Token)).Start();
        }

        private void writeFileThread(CancellationToken cancellationToken)
        {
            using (var sw = new StreamWriter("file.txt"))
            {
                for (int i = 0; i < MAX && !cancellationToken.IsCancellationRequested; i++)
                {
                    Thread.Sleep(5);
                    sw.Write("*");
                    this.BeginInvoke(new Action(() => progressBar.Value = i));
                }
            }
        }

        private void btnOtherOperations_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eseguo altra operazione");
        }
    }
}
