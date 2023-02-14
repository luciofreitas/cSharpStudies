using System;
using System.Globalization;

namespace foreachNomesLidos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string nome;
            string[] vet;
            n = int.Parse(Console.ReadLine());
            vet = new string[n];
            for (int i = 0; i < n; i++)
            {
                vet[i] = Console.ReadLine();
            }
            Console.WriteLine($"Nomes lidos");
            foreach (string x in vet)
            {
                Console.WriteLine(x);
            }
        }
    }
}
