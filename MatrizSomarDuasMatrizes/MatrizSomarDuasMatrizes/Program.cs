using System;
using System.Globalization;

namespace MatrizSomarDuasMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            int[,] a, b, c;


            Console.WriteLine("Informe quantas linhas e colunas terão as matrizes");
            string[] valores = Console.ReadLine().Split(' ');
            m = int.Parse(valores[0]);
            n = int.Parse(valores[1]);
            a = new int[m, n];
            b = new int[m, n];
            c = new int[m, n];

            Console.WriteLine("Informe os valores da primeira matriz");
            for (int i = 0; i < m; i++)
            {
                valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(valores[j]);
                }
            }
            Console.WriteLine("Informe os valores da segunda matriz");
            for (int i = 0; i < m; i++)
            {
                valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    b[i, j] = int.Parse(valores[j]);
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}