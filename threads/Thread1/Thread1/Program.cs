using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var thread1 = new Thread(go);

            thread1.Start();

            go();

            Console.ReadKey();
        }

        private static void go()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i);
            }
        }
    }
}
