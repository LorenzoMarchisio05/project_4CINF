using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Thread2
{
    internal class Program
    {
        private static int n;

        static void Main(string[] args)
        {
            var thread1 = new Thread(go);

            thread1.Start();

            go();

            Console.ReadKey();
            
        }

        private static void go()
        {
            for(n = 0; n < 5; n++)
            {
                Console.WriteLine(n);
            }
        }
    }
}
