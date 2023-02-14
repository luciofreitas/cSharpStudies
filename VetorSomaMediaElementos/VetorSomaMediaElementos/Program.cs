//Faça um programa que leia numeros reais e armazene-os em um vetor. Em seguida: imprimir todos os elementos do vetor
// e mostrar na tela a soma e a media dos elementos do vetor

using System;
using System.Globalization;

namespace VetorSomaMediaElementos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double[] vet;
            double soma = 0.0;
            

            n = int.Parse(Console.ReadLine());
            vet = new double[n];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{vet[i].ToString("F1",CultureInfo.InvariantCulture)} ");
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                soma += vet[i];
            }
            double media = soma / n;
            Console.WriteLine($"{soma.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}