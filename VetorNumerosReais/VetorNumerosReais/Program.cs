using System;
using System.Globalization;

namespace VetorNumerosReais
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] vet;
            int cont = 0;

            n = int.Parse(Console.ReadLine());
            vet = new int[n];
            string[] s = Console.ReadLine().Split(' ');
            Console.WriteLine($"Os numeros pares digitados foram:");
            for (int i=0; i < n; i++)
            {
                vet[i] = int.Parse(s[i]);
                if (vet[i] % 2 == 0)
                {
                    Console.Write($"{vet[i]}");
                    cont++;
                }

            }           
            Console.WriteLine($"A quantidade de numeros pares digitados foram: {cont}");
        }
    }
}