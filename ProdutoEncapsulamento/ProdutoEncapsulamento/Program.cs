using System;
using System.Globalization;

namespace ProdutoEncapsulamento
{
    class Program
    {
        static void Main(string[] args) {
            Estoque p = new Estoque("TV", 900.00, 10);

            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
           

        }
    }
}