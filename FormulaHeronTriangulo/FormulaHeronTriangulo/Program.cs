using System;
using System.Globalization;

namespace FormulaHeronTriangulo {
    class Program {
        static void Main(string[] args) {

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaX = x.CalcArea();


            double areaY = y.CalcArea();

            Console.WriteLine($"Area do triangulo X é igual a {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area do triangulo Y é igual a {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areaX > areaY) {
                Console.WriteLine("Area do triangulo X é maior");
            } else {
                Console.WriteLine("Area do triangulo Y é maior");
            }
        }
    }
}