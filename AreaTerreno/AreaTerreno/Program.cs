using System;
using System.Globalization;

namespace AreaTerreno
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, precoMetroQuadrado;
            double area, precoTerreno;

            Console.WriteLine("Informe a largura desejada");
            largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o comprimento desejado");
            comprimento = double.Parse(Console.ReadLine());

            area = largura * comprimento;

            Console.WriteLine("Informe o valor por metro quadrado");
            precoMetroQuadrado = double.Parse(Console.ReadLine());

            precoTerreno = area * precoMetroQuadrado;

            Console.WriteLine("O valor da area é de " + area.ToString("F2", CultureInfo.InvariantCulture) + " e o valor do metro quadrado é de R$ " + precoTerreno.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}