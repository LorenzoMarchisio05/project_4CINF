using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread7
{
    internal class Program
    {
        private static volatile int[] risultati;

        private static Random rnd = new Random();

        static void Main(string[] args)
        {
            const int numeroFacce = 6;
            const int numeroThread = 100;

            risultati = new int[numeroFacce];

            var threads = new Thread[numeroThread];

            for (int i = 0; i < numeroFacce; i++)
            {
                risultati[i] = 0;
            }

            for (int i = 0; i < numeroThread; i++)
            {
                threads[i] = new Thread(lancia);

                threads[i].Start(numeroFacce);

                threads[i].Join();
            }

            int totLanci = 0;

            for(int i = 0; i < numeroFacce; i++)
            {
                Console.WriteLine($"Faccia {i + 1} -> {risultati[i]}");
                totLanci += risultati[i];
            }

            Console.WriteLine($"numero lanci: {totLanci}");

            Console.ReadKey();
        }

        private static void lancia(object args)
        {
            
        }
    }
}
