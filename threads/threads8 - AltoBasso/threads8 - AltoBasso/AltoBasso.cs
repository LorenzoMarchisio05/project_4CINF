using System;
using System.Threading;

namespace threads8___AltoBasso
{
    internal partial class Program
    {
        public static class AltoBasso
        {
            private static readonly Random rnd = new Random(420);

            private static int numeroSegreto;

            private static int tentativi = 0;

            private static int start = 0, end = 100;

            public static void Run()
            {
                generaNumeroSegreto();

                Thread indovina = new Thread(Indovina);

                indovina.Start("alto;101");
            }

            private static void generaNumeroSegreto()
            {
                numeroSegreto = rnd.Next(100) + 1;
                tentativi = 0;
            }

            private static void Indovina(object data)
            {
                tentativi++;
                var split = data.ToString().Split(';');
                string esito = split[0];
                int valore = int.Parse(split[1]);

                if (esito.ToLower() == "alto")
                {
                    end = valore - 1;
                }
                else
                {
                    start = valore + 1;
                }

                var numeroGenerato = rnd.Next(start, end + 1);

                Console.WriteLine($"Numero Generato: {numeroGenerato}");

                Thread controlla = new Thread(Controlla);

                controlla.Start(numeroGenerato);
            }

            private static void Controlla(object data)
            {
                var numero = (int)data;

                if (numero == numeroSegreto)
                {
                    Console.WriteLine($"indovinato: {numero} -> {numeroSegreto}");
                    return;
                }

                Thread indovina = new Thread(Indovina);

                if (numero > numeroSegreto)
                {
                    indovina.Start($"alto;{numero}");
                    return;
                }

                if (numero < numeroSegreto)
                {
                    indovina.Start($"basso;{numero}");
                }
            }
        }
    }

}
