using System;
using System.Globalization;

namespace ValidacaoNota
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;


            nota1 = double.Parse(Console.ReadLine());
            while (nota1 < 0 || nota1 > 10)
            {
                Console.WriteLine("Nota inválida");
                nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }

            nota2 = double.Parse(Console.ReadLine());
            while (nota2 < 0 || nota2 > 10)
            {
                Console.WriteLine("Nota inválida");
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);       
            }

            media = (nota1 + nota2) / 2.0;

            Console.WriteLine($"a média do aluno é igual a {media.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}