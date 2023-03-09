using System;
using System.Globalization;

namespace MaisVelhoClasses {
    class Program {
        static void Main(string[] args) {

            Pessoa x, y;
            x = new Pessoa();
            y = new Pessoa();

            Console.Write("Informe o nome da pessoa desejada: ");
            x.nomePessoa = Console.ReadLine();
            Console.Write("Informe a idade da pessoa: ");
            x.idadePessoa = int.Parse(Console.ReadLine());

            Console.Write("Informe o nome da pessoa desejada: ");
            y.nomePessoa = Console.ReadLine();
            Console.Write("Informe a idade da pessoa: ");
            y.idadePessoa = int.Parse(Console.ReadLine());

            if (x.idadePessoa > y.idadePessoa) {
                Console.WriteLine($"O {x.nomePessoa} é mais velho que o {y.nomePessoa}");
            } else {
                Console.WriteLine($"O {y.nomePessoa} é mais velho que o {x.nomePessoa}");
            }
        }
    }
}