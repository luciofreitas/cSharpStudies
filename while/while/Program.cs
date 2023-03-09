using System;
using System.Globalization;

namespace While {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite um valor: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0) {
                double raiz = Math.Sqrt(x);

                Console.Write($"A raiz de {x} é igual a {raiz.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine();
                Console.Write("Insire outro valor: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Valor negativo, o programa foi finalizado, obrigado!");
        }
    }
}