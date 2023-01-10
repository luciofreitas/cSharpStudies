using System;
using System.Globalization;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int nFunc, nHorasTrab;
            double vRecebeHora, salarioFunc;

            nFunc = int.Parse(Console.ReadLine());

            nHorasTrab = int.Parse(Console.ReadLine());

            vRecebeHora = double.Parse(Console.ReadLine());

            salarioFunc = (double) nHorasTrab * vRecebeHora;

            Console.WriteLine($"NUMBER = {nFunc.ToString("F2")}");
            Console.WriteLine($"SALARY = U$ {salarioFunc.ToString("F2")}");

            Console.ReadKey();
        }
    }
}
