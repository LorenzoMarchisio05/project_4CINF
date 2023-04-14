using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var threadA = new Thread(threadA_method);

            var threadB = new Thread(threadB_method);

            Console.WriteLine("Main thread: starting parallels thread");

            threadA.Start();
            threadB.Start();

            threadA.Join();
            threadB.Join();

            Console.WriteLine("Main thread: end parallels thread");

            Console.ReadKey();
        }


        private static void threadA_method()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Thread A executing... {i}");
                Thread.Sleep(20);
            }

            Console.WriteLine("Thread A terminato");
        }
        private static void threadB_method()
        {
            for (int i = 100; i < 110; i++)
            {
                Console.WriteLine($"Thread B executing... {i}");
                Thread.Sleep(50);
            }

            Console.WriteLine("Thread B terminato");
        }
    }
}
