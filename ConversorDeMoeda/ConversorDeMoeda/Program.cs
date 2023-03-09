using System;
using System.Globalization;

namespace ConversorDeMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;

            do
            {
                Console.WriteLine("Informe que tipo de conversão deseja fazer");
                Console.WriteLine("1 - Real pro Dolar");
                Console.WriteLine("2 - Dolar pro Real ");
                Console.WriteLine("3 - Sair");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.WriteLine("Informe o valor da cotação atual");
                    double cotacao = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe quantos dolares você quer comprar");
                    double real = double.Parse(Console.ReadLine());
                    double realToDolar = Conversor.ConvRealToDolar(real, cotacao);
                    Console.WriteLine($"Você conseguiu comprar com ${real} R${realToDolar.ToString("F2", CultureInfo.InvariantCulture)} reais");

                }
                else if (op == 2)
                {
                    Console.WriteLine("Informe o valor da cotação atual");
                    double cotacao = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe quantos reais você quer comprar");
                    double dolar = double.Parse(Console.ReadLine());
                    double dolarToReal = Conversor.ConvDolarToReal(dolar, cotacao);
                    Console.WriteLine($"Você conseguiu comprar com ${dolar} R${dolarToReal.ToString("F2", CultureInfo.InvariantCulture)} reais");

                }
            } while (op != 3);



        }
    }
}