using System;
using System.Globalization;
namespace vetorMediaIdadeEMenorIdade
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = 0, i;

            n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            double[] altura = new double[n];
            int[] idade = new int[n];



            for (i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                idade[i] = int.Parse(s[1]);
                altura[i] = double.Parse(s[2], CultureInfo.InvariantCulture);

            }

            double soma = 0.0;

            for (i = 0; i < n; i++)
            {
                soma += altura[i];    
            }
            double mediaAltura = soma / n;

            Console.WriteLine($"Altura media = {mediaAltura}");

            int cont = 0;
            for(i=0; i<n; i++)
            {
                if (idade[i] < 16)
                {
                    cont++;
                }
            }
            double porcentagem = (double) cont / n * 100;

            Console.WriteLine($"Pessoas com menos de 16 anos é = {porcentagem.ToString("F1",CultureInfo.InvariantCulture)}%");

        }
    }
}
