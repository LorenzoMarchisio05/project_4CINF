using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread3
{
    internal class Program
    {
        private static int n;
        private static object @lock = new object();

        static void Main(string[] args)
        {
            var thread1 = new Thread(go);
            var thread2 = new Thread(go);

            thread1.Start();
            thread2.Start();

            Console.ReadKey();
        }

        private static void go()
        {
            lock (@lock)
            {
                for(n = 0; n < 5; n++)
                {
                    Console.Write(n);
                }
            }
        }
    }
}
