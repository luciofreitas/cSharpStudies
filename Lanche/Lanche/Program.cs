using System;
using System.Globalization;

namespace Lanche
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double preco, valorPagar=0.0;

            Console.WriteLine("Informe o codigo do produto");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade");
            quantidade = int.Parse(Console.ReadLine());
            switch (codigo)
            {
                case 1:
                    preco = 4.00;
                    valorPagar = quantidade * preco;
                    break;
                case 2:
                    preco = 4.50;
                    valorPagar = quantidade * preco;
                    break;
                case 3:
                    preco = 5.00;
                    valorPagar = quantidade * preco;
                    break;
                case 4:
                    preco = 2.00;
                    valorPagar = quantidade * preco;
                    break;
                case 5:
                    preco = 1.50; 
                    valorPagar = quantidade * preco;
                    break;
            }

            Console.WriteLine($"Total: R$ {valorPagar} ,00");
        }
    }
}