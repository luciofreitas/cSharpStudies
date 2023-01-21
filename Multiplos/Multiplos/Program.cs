using System;

namespace Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            if (a % b == 0)
            {
                Console.WriteLine($"Os numeros {a} e {b} São multiplos");
            }
            else
            {
                Console.WriteLine($"Os numeros {a} e {b} Não são multiplos");
            }
        }
    }
}