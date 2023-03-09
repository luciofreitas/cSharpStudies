using System;
using System.Globalization;

namespace ClasseSalarioAtualizar {
    class Program {
        static void Main(string[] args) {
            Funcionario f;
            f = new Funcionario();

            Console.Write("Informe o nome do funcionário: ");
            f.Nome = Console.ReadLine();

            Console.Write($"Informe o salario bruto do {f.Nome}: ");
            f.Salario = double.Parse(Console.ReadLine());

            Console.Write($"Informe a porcentagem para aumentar o salario do {f.Nome}: ");
            f.Porcentagem = double.Parse(Console.ReadLine());

            EscreverTela($"Funcionário: {f.Nome}, recebe R$ {f.SalarioLiquido()}");
            EscreverTela(f);
        }

        public static void EscreverTela(string texto) {
            Console.WriteLine();
            Console.Write(texto);
            
        }

        public static void EscreverTela(Funcionario f) {
            Console.WriteLine();
            Console.WriteLine(f);
            
        }
    }
}