using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thread13_NProduttoriNConsumatori
{
    public partial class FrmThread : Form
    {

        private const int producerNumber = 5;

        private const int consumerNumber = 2;

        private const int bufferSize = 4;

        private const int productionTime = 5 * 1000;

        private const int consumeTime = 1 * 1000;

        private static SemaphoreSlim emptySemaphore = new SemaphoreSlim(bufferSize);

        private static SemaphoreSlim fullSemaphore = new SemaphoreSlim(0);

        private static object lockProducerConsumer = new object();

        private static int[] buffer = new int[bufferSize];

        private int put = 0;

        private int remove = 0;

        private bool stopProduction = false;

        private int bufferElementNumber = 0;

        private int producedElement;

        private static Random rnd = new Random(420);

        public FrmThread()
        {
            InitializeComponent();

            init();
        }

        private void init()
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            pbBuffer.Minimum = 0;
            pbBuffer.Maximum = bufferSize;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var productionThreads = Enumerable.Range(0, producerNumber)
                .Select(i => new Thread(produce) { Name = $"Thread Produci{i}"});

            var consumerThreads = Enumerable.Range(0, producerNumber)
                .Select(i => new Thread(consume) { Name = $"Thread Consuma{i}" });

            Parallel.ForEach(productionThreads, (thread) => thread.Start());
            Parallel.ForEach(consumerThreads, (thread) => thread.Start());

            btnStart.Enabled = false;
            btnStop.Enabled = true;

            put = remove = 0;
            stopProduction = false;

            producedElement = 0;
        }

        private void consume()
        {
            string name = Thread.CurrentThread.Name;

            var updateProgressBar = new Action(() =>
            {
                pbBuffer.Value = bufferElementNumber;
            });

            var updateLabel = new Action(() =>
            {
                lblBuffer.Text = readBuffer();
            });

            while (!stopProduction || emptyBuffer())
            {
                fullSemaphore.Wait();

                lock (lockProducerConsumer)
                {

                    buffer[remove] = 0;

                    bufferElementNumber--;

                    remove = (remove + 1) % bufferSize;

                    this.Invoke(updateProgressBar);
                    this.Invoke(updateLabel);
                }

                Thread.Sleep(rnd.Next(1, consumeTime));

                emptySemaphore.Release();
            }
        }

        private bool emptyBuffer() => buffer
            .All(element => element == 0);

        private void produce()
        {
            string name = Thread.CurrentThread.Name;

            var updateProgressBar = new Action(() =>
            {
                pbBuffer.Value = bufferElementNumber;
            });

            var updateLabel = new Action(() =>
            {
                lblBuffer.Text = readBuffer();
            });

            while (!stopProduction)
            {
                emptySemaphore.Wait();

                lock (lockProducerConsumer)
                {
                    producedElement++;

                    buffer[put] = producedElement;

                    bufferElementNumber++;

                    put = (put + 1) % bufferSize;

                    this.Invoke(updateProgressBar);
                    this.Invoke(updateLabel);
                }

                Thread.Sleep(rnd.Next(1, productionTime));

                fullSemaphore.Release();
            }
        }

        private string readBuffer()
        {
            string s = "";

            foreach(var data in buffer)
            {
                s += $", {data}";
            }

            return $"{s.Substring(1)} -> {bufferElementNumber}<-";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnStart.Enabled = true;

            stopProduction = true;
        }

        private void FrmThread_Load(object sender, EventArgs e)
        {
        }
    }
}
