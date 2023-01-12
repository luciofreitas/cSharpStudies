using System;

namespace Esfera
{
    class Program
    {
        static void Main(string[] args) {
            
            double volume, pi=3.14159, r;

            Console.WriteLine("Informe o raio da esfera");
            r = Convert.ToDouble(Console.ReadLine());

            volume = (4 / 3.0) * pi * Math.Pow(r, 3);

            Console.WriteLine($"O volume da esfera é igual a {volume.ToString("F3")}");
        }
    }
}
