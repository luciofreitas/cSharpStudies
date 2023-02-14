using System;


namespace forN
{
    class Program
    {
        static void Main(string[] args)
        {
           int n,x,soma;
            Console.WriteLine("Informe a quantidade de numeros que voce digitará");
            n = int.Parse(Console.ReadLine());

            soma = 0;
            Console.WriteLine("Agora insira os numeros");
            for (int i=1;i<=n ;i++)
            {
                x = int.Parse(Console.ReadLine());

                soma += x;
            }

            Console.WriteLine($"A soma dos numeros digitados é igual a {soma}");
        }

    }
}
