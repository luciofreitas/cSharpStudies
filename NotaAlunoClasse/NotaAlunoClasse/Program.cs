using System;
using System.Globalization;

namespace NotaAlunoClasse {
    class Program {
        static void Main(string[] args) {
            Aluno a;
            a = new Aluno();

            Console.Write("Informe o nome do aluno: ");
            a.Nome = Console.ReadLine();

            EscreverTexto($"Informe as notas do aluno {a.Nome}");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            EscreverTexto($"NOTA FINAL = {a.Media().ToString("F2", CultureInfo.InvariantCulture)} ");

            if (a.Aprovado()) {
                Console.WriteLine("APROVADO");
            } else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }
        }
        public static void EscreverTexto(string texto) {
            Console.WriteLine();
            Console.WriteLine(texto);
        }
    }
}