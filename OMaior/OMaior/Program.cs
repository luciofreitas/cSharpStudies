using System;
using System.Collections;

namespace OMaior
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, maiorAB, maior;

            Console.WriteLine("Informe três valores");


            string[] valores = Console.ReadLine().Split(' ');

            a = double.Parse(valores[0]);
            b = double.Parse(valores[1]);
            c = double.Parse(valores[2]);

            maiorAB = (a + b + Math.Abs(a - b)) / 2;

            maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

            Console.WriteLine($"{maior} é o maior");
        }
    }
}