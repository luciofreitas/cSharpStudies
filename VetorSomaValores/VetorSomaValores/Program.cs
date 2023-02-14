//leia n numeros reais e armazene-os em um vetor. em seguida: imprimir todos os elementos do vetor,
//e mostrar na tela a soma e a media dos elementos do vetor

using System;

namespace VetorSomaValores
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

            for(int i=0; i<n; i++)
            {
                n = int.Parse(Console.ReadLine());
                vet[i] = int.Parse(s[i]);
            }
            for (int i=0;i<n;i++)
            {

            }
        }
    }
}