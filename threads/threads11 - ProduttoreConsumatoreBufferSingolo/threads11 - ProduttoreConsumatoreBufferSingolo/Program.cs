using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace threads11___ProduttoreConsumatoreBufferSingolo
{
    internal class Program
    {
        private const int NUMERO_DATI = 10;
        private const int TEMPO_PRODUZIONE = 200;
        private const int TEMPO_CONSUMO = 500;


        private static SemaphoreSlim _emptySemaphore = new SemaphoreSlim(1);

        private static SemaphoreSlim _fullSemaphore = new SemaphoreSlim(0);

        private static int buffer;

        static void Main(string[] args)
        {
            Console.WriteLine($"full semaphore -> current count: {_fullSemaphore.CurrentCount}");

            Console.WriteLine("sull semaphore -> release");
            _fullSemaphore.Release();

            Console.WriteLine($"full semaphore -> current count: {_fullSemaphore.CurrentCount}");
            
            Console.WriteLine("sull semaphore -> wait");
            _fullSemaphore.Wait();

            Console.Read();
        }
    }
}

