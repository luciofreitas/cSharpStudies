using System;
using System.Globalization;

namespace LeituraNomeIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            string pessoa1, pessoa2,nome1,nome2;
            int idade1, idade2;
            double idadeMedia;

            Console.WriteLine("Informe o nome da pessoa e a idade");
            string[] vet = Console.ReadLine().Split(' ');
            nome1= vet[0];
            idade1 = Convert.ToInt32(vet[1]);

            Console.WriteLine("Informe o nome da pessoa e a idade");
            string[] vet2 = Console.ReadLine().Split(' ');
             nome2 = vet2[0];
             idade2 = Convert.ToInt32(vet2[1]);

            idadeMedia = (double) (idade1 + idade2) / 2;

            Console.WriteLine($"A idade média de {nome1} e de {nome2} é igual a {idadeMedia.ToString("F1", CultureInfo.InvariantCulture)}");

        }
    }
}