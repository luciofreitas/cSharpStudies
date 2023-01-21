using System;

namespace TesteSelecao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);
            d = int.Parse(vet[3]);

            if (b > c)
            {
                if (d > a)
                {
                    if (c + d > a + b)
                    {
                        if (c > 0 && d > 0)
                        {
                            if (a % 2 ==0)
                            {
                                Console.WriteLine("Valores aceitos");
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Valores não aceitos");
            }


        }
    }
}