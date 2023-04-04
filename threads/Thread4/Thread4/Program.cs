using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread4
{
    internal class Program
    {

        private static int n;
        static void Main(string[] args)
        {
            var thread1 = new Thread(go);
            var thread2 = new Thread(go);

            thread1.Start();
            thread1.Join();

            thread2.Start();
            thread2.Join();

            Console.ReadKey();
        }

        private static void go()
        {
            for(n = 0; n < 5; n++)
            {
                Console.Write(n);
            }
        }
    }
}
