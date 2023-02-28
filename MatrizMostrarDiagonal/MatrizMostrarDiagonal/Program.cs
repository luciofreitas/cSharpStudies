using System;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;

namespace MatrizMostrarDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont = 0;

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
            Console.WriteLine("Diagonal principal: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(matriz[i, i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i,j] < 0)
                    {
                        cont++;
                    }
                }
            }
            Console.WriteLine($"Quantidade de negativos na matriz inteira é igual a {cont}");

        }
    }
}