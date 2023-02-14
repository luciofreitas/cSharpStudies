//digitar o tamanho do vetor, informar os valores e retornar apenas os numeros negativos

using System;

namespace VetorLeiaNNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] vet;

            n = int.Parse(Console.ReadLine());
            vet = new int[n];

            string[] s = Console.ReadLine().Split(' ');
            for (int i=0; i<=n; i++)
            {
                n = int.Parse(Console.ReadLine());
                vet[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < n; i++)
            {
                if (vet[i] < 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }
        }
    }
}