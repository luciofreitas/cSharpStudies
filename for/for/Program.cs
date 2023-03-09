using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace For {
    class Program {
        static void Main(string[] args) {
            Console.Write("Informe a quantidade de numeros: ");
            int x = int.Parse(Console.ReadLine());

            int soma = 0;
            for(int i=0; i<x; i++) {               
                Console.Write($"Valor #{i}: ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine($"Soma = {soma}");
        }
    }
}