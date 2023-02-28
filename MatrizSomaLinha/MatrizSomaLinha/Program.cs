using System;
using System.Globalization;

namespace MatrizMaiorElemento
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
            
            for (int i = 0; i < n; i++)
            {
                int valorMaior = 0;
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] > valorMaior)
                    {
                        valorMaior = matriz[i, j];
                    }
                }
                Console.WriteLine($"O maior da linha {i} valor é igual a {valorMaior}");
            }
            
        }
    }
}