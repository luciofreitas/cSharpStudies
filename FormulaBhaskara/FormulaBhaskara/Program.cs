using System;
using System.Globalization;

namespace FormulaBhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, R1, R2, delta;

            Console.WriteLine("Informe, respectivamente, os valores de A, B, C ");

            String[] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0], CultureInfo.InvariantCulture);

            B = double.Parse(vet[1], CultureInfo.InvariantCulture);

            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(B, 2.0) - 4 * A * C;

            if (delta < 0.0 || A == 0.0)
            {
                Console.WriteLine("Impossivel Calcular");
            }
            else
            {
                R1 = (-B + Math.Sqrt(delta)) / (2 * A);
                R2 = (-B - Math.Sqrt(delta)) / (2 * A);

                Console.WriteLine($"As raizes são respectivamente iguais a {R1.ToString("F5",CultureInfo.InvariantCulture)} e {R2.ToString("F5",CultureInfo.InvariantCulture)}");
            }



        }
    }
}