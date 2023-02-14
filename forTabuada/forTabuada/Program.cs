using System;

namespace forTabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,y;
            Console.WriteLine("Informe qual numero voce deseja a tabuada");
            n=int.Parse(Console.ReadLine());

            Console.WriteLine("Informe até onde irá a sua tabuada");
            y=int.Parse(Console.ReadLine());


            for(int i=0; i<=y; i++)
            {
                int resultado = i * n;

                Console.WriteLine($"{i} x {n} = {resultado}");
            }
        }
    }
}