﻿using System;
using System.Globalization;

namespace AreaCirulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 3.14159;
            double area, raio;

            raio = double.Parse(Console.ReadLine());

            area = n * Math.Pow(raio,2);

            Console.WriteLine("A= " + area.ToString("F4"));

            Console.ReadLine();
        }
    }
}