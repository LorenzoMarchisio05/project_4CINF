using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread6
{
    internal class Program
    {
        private static Random rnd = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Main thread: avvio thread A");

            var threadA = new Thread(metodo_threadA);

            threadA.Start();

            threadA.Join();

            Console.WriteLine("Main thread: thread A terminato");

            Console.ReadKey();
        }

        private static void metodo_threadA()
        {
            int n = rnd.Next(101);

            Thread thread;

            if(n <= 50)
            {
                thread = new Thread(metodo_threadB);
                Console.WriteLine("Thread A: Avvio thread B");
            }
            else
            {
                thread = new Thread(metodo_threadC);
                Console.WriteLine("Thread A: Avvio thread B");
            }

            thread.Start();
            thread.Join();


            Console.WriteLine("Thread A: Terminato");
        }


        private static void metodo_threadB()
        {
            Console.WriteLine("Thread B: In Esecuzione");

            Thread.Sleep(30);

            Console.WriteLine("Thread B: Terminato");
        }
        private static void metodo_threadC()
        {

            Console.WriteLine("Thread C: In Esecuzione");

            Thread.Sleep(30);

            Console.WriteLine("Thread C: Terminato");
        }
    }
}
