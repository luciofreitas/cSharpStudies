using System;
using System.Globalization;

namespace MatrizSomaDaLinha
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            int[,] matriz;

            string[] s1 = Console.ReadLine().Split(' ');
            m = int.Parse(s1[0]);
            n = int.Parse(s1[1]);

            matriz = new int[m, n];

            for(int i = 0; i < m; i++)
            {
                string[]s2 = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(s2[j]);
                }
            }
            int[] vet = new int[m];

            for(int i = 0; i < m; i++)
            {
                int soma = 0;
                for(int j = 0; j < n; j++)
                {
                    soma += matriz[i, j];
                }
                vet[i] = soma;
            }
            for(int i = 0; i < m; i++)
            {
                Console.Write(vet[i]);
            }

        }
    }
}