using System;

namespace MenorNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;


            String[] vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            z = int.Parse(vet[2]);

            if (x < y && x < z)
            {
                Console.WriteLine($" X = {x}, logo, é menor");
            }
            else if (y < x && y < z)
            {
                Console.WriteLine($"Y = {y}, logo, é menor");
            }else
            {
                Console.WriteLine($"Z = {z}, logo, é menor");
            }

                Console.ReadLine();
        }
    }
}