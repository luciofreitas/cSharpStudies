using System;
using System.Globalization;

namespace MatrizSomaElementosAcimaDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[,] matriz;

            n = int.Parse(Console.ReadLine());
            matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("A diagonal principal da matriz é ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }
            Console.WriteLine();

            int soma = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    soma += matriz[i, j];
                }
            }
            Console.WriteLine($"A soma dos numeros que ficam em cima da diagonal principal é {soma}");
        }
    }
}