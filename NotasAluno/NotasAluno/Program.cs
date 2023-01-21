using System;
using System.Globalization;

namespace NotasAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double nota1, nota2, nota3, media;

            Console.WriteLine("Informe o nome do aluno");
            nome = Console.ReadLine();

            Console.WriteLine("Informe a primeira nota do aluno");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a segunda nota do aluno");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a terceira nota do aluno");
            nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"O {nome} ficou com a média igual a {media.ToString("F2", CultureInfo.InvariantCulture)}");

            if (media < 5)
            {
                Console.WriteLine($"{nome} está reprovado");
            }
            else if (media >= 5 && media < 7)
            {
                Console.WriteLine($"{nome} ficou em recuperação");
            }
            else if (media >= 7 && media < 10)
            {
                Console.WriteLine($"{nome} está aprovado ");

            }
            else if (media == 10)
            {
                Console.WriteLine($"{nome} passou com nota máxima, parabéns");
            }

        }
    }
}