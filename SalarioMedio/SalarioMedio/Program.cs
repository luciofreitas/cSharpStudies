using System;
using System.Globalization;

namespace SalarioMedio {
    class Program {
        static void Main(string[] args) {
            double mediaSalario;

            Funcionario x, y;
            x = new Funcionario();
            y = new Funcionario();

            Console.WriteLine("Informe o nome da primeira pessoa:");
            x.nome = Console.ReadLine();
            Console.WriteLine($"Informe o salario do {x.nome}");
            x.salario = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o nome da primeira pessoa:");
            y.nome = Console.ReadLine();
            Console.WriteLine($"Informe o salario do {y.nome}");
            y.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine($"O salario do {x.nome} é igual a R$ {x.salario}");
            Console.WriteLine($"O salario do {y.nome} é igual a R$ {y.salario}");
            Console.WriteLine("");

            mediaSalario = (x.salario + y.salario)/2;

            Console.WriteLine($"A media do salario do {x.nome} e do {y.nome} é igual a R$ {mediaSalario} ");

        }
    }
}