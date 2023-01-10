using System;
using System.Globalization;

namespace AreaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, area, perimetro, diagonal;

            Console.WriteLine("Informe a largura do retangulo");
            largura= Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o comprimento do retangulo");
            comprimento= Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            perimetro = 2*(largura + comprimento);
            diagonal = Math.Sqrt(Math.Pow(comprimento, 2) + Math.Pow(largura, 2));

            Console.WriteLine($" Area={area.ToString("F4", CultureInfo.InvariantCulture)}, Perimetro={perimetro.ToString("F4", CultureInfo.InvariantCulture)}, Diagonal={diagonal.ToString("F4" , CultureInfo.InvariantCulture)}");
        }
    }
}