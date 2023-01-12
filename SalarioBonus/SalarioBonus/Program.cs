using System;
using System.Globalization;

namespace SalarioBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeVendedor;
            double salarioFixo, salarioBonus, vendasEfetuadas, salarioTotal;

            Console.WriteLine("Informe o nome do vendedor");
            nomeVendedor= Console.ReadLine();

            Console.WriteLine($"Informe o salario fixo do {nomeVendedor}");
            salarioFixo = Convert.ToDouble( Console.ReadLine() );

            Console.WriteLine($"Informe o total de vendas do {nomeVendedor}");
            vendasEfetuadas = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);

            salarioBonus = vendasEfetuadas * 0.15;

            salarioTotal = salarioBonus + salarioFixo;

            Console.WriteLine($"O funcionário {nomeVendedor} deverá receber um bonus de R$ {salarioBonus.ToString("F2")}, logo, o total que deverá receber é {salarioTotal.ToString("F2")}");
        }
    }
}