using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thread10___Programmazione_concorrente
{
    public partial class FrmThread : Form
    {
        private static object _lock = new object();

        private static Mutex _mutex = new Mutex(false);

        private static Semaphore _semaphore = new Semaphore(2, 2);

        private static SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(2, 2);

        public FrmThread()
        {
            InitializeComponent();

        }

        private void FrmThread_Load(object sender, EventArgs e)
        {
        }

        private void initDataGridView(DataGridView dgv)
        {
            dgv.RowHeadersVisible = dgv.ColumnHeadersVisible = false;
            dgv.ColumnCount = 1;

            dgv.Columns[0].Width = dgvLock.Width;
            
            dgv.Rows.Clear();

            dgv.ReadOnly = true;
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            btnLock.Enabled = false;
            initDataGridView(dgvLock);

            var thread1 = new Thread(lock_handler)
            { 
                Name = "thread 1"
            };

            var thread2 = new Thread(lock_handler)
            {
                Name = "thread 2"
            };

            var thread3 = new Thread(lock_handler)
            {
                Name = "thread 3"
            };

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private void btnMutex_Click(object sender, EventArgs e)
        {
            btnMutex.Enabled = false;
            initDataGridView(dgvMutex);

            var thread1 = new Thread(mutex_handler)
            {
                Name = "thread 1"
            };

            var thread2 = new Thread(mutex_handler)
            {
                Name = "thread 2"
            };

            var thread3 = new Thread(mutex_handler)
            {
                Name = "thread 3"
            };

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private void btnSemaphore_Click(object sender, EventArgs e)
        {
            btnSemaphore.Enabled = false;
            initDataGridView(dgvSemaphore);

            var thread1 = new Thread(semaphore_handler)
            {
                Name = "thread 1"
            };

            var thread2 = new Thread(semaphore_handler)
            {
                Name = "thread 2"
            };

            var thread3 = new Thread(semaphore_handler)
            {
                Name = "thread 3"
            };

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private void btnSemaphoreSlim_Click(object sender, EventArgs e)
        {
            btnSemaphoreSlim.Enabled = false;
            initDataGridView(dgvSemaphoreSlim);

            var thread1 = new Thread(semaphoreSlim_handler)
            {
                Name = "thread 1"
            };

            var thread2 = new Thread(semaphoreSlim_handler)
            {
                Name = "thread 2"
            };

            var thread3 = new Thread(semaphoreSlim_handler)
            {
                Name = "thread 3"
            };

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        #region Handlers
        private void lock_handler()
        {
            var s = "";

            var operation = new Action(() => {

                dgvLock.Rows.Add(s);
                btnLock.Enabled = true;
            });


            lock (_lock)
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(1000);

                    s = $"{Thread.CurrentThread.Name}-> Sezione critica: {i}";

                    this.BeginInvoke(operation);
                }
            }

            // Istruzioni non bloccanti
            /*
            for (int i = 10; i >= 0; i--)
            {
                Thread.Sleep(1000);

                s = $"{Thread.CurrentThread.Name}-> Sezione non bloccante: {i}";

                this.Invoke(operation);
            }
            */
        }

        private void mutex_handler()
        {
            var s = "";

            var operation = new Action(() => {

                dgvMutex.Rows.Add(s);
                btnMutex.Enabled = true;
            });

            _mutex.WaitOne();

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);

                s = $"{Thread.CurrentThread.Name}-> Sezione critica: {i}";

                this.BeginInvoke(operation);
            }

            _mutex.ReleaseMutex();

            // Istruzioni non bloccanti
            /*
            for (int i = 10; i >= 0; i--)
            {
                Thread.Sleep(1000);

                s = $"{Thread.CurrentThread.Name}-> Sezione non bloccante: {i}";

                this.Invoke(operation);
            }
            */
            
        }

        private void semaphore_handler()
        {
            var s = "";

            var operation = new Action(() => {

                dgvSemaphore.Rows.Add(s);
                btnSemaphore.Enabled = true;
            });

            _semaphore.WaitOne();

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);

                s = $"{Thread.CurrentThread.Name}-> Sezione critica: {i}";

                this.BeginInvoke(operation);
            }

            _semaphore.Release();

            // Istruzioni non bloccanti
            /*
            for (int i = 10; i >= 0; i--)
            {
                Thread.Sleep(1000);

                s = $"{Thread.CurrentThread.Name}-> Sezione non bloccante: {i}";

                this.Invoke(operation);
            }
            */
        }

        private void semaphoreSlim_handler()
        {
            var s = "";

            var operation = new Action(() => {

                dgvSemaphoreSlim.Rows.Add(s);
                btnSemaphoreSlim.Enabled = true;
            });

            _semaphoreSlim.Wait();

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);

                s = $"{Thread.CurrentThread.Name}-> Sezione critica: {i}";

                this.BeginInvoke(operation);
            }

            _semaphoreSlim.Release();

            // Istruzioni non bloccanti
            /*
            for (int i = 10; i >= 0; i--)
            {
                Thread.Sleep(1000);

                s = $"{Thread.CurrentThread.Name}-> Sezione non bloccante: {i}";

                this.Invoke(operation);
            }
            */
        }

        #endregion

        private void FrmThread_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
