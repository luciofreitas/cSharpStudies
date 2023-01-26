using System;
using System.Globalization;

namespace MediaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, soma, mediaIdade;
            int cont;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = 0.0;
            cont = 0;
            while (idade >= 0)
            {
                soma += idade;
                cont++;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            if (cont == 0)
            {
                Console.WriteLine("mpossivel calcular");
            }
            else
            {
                mediaIdade = soma / cont;
                Console.WriteLine($"A media das idades é igual a {mediaIdade.ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }
    }
}
