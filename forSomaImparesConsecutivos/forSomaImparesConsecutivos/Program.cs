using System;

//Leia 2 valores inteiros X e Y. A seguir calcule e mostre a soma dos numeros impares entre eles.

namespace forSomaImparesConsecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, min, max, soma = 0;

            Console.WriteLine("Informe os numeros");
            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            if (x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }
            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine($"A soma dos numeros impares entre eles é igual a {soma}");
        }
    }
}