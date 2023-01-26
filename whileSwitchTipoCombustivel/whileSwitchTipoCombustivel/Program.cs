using System;

namespace whileSwitchTipoCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, alcool = 0, gasolina = 0, diesel = 0;

            codigo = int.Parse(Console.ReadLine());

            while (codigo > 0 && codigo < 4)
            {
                if (codigo == 1)
                {
                    alcool++;
                }
                else if (codigo == 2)
                {
                    gasolina++;
                }
                else if (codigo == 3)
                {
                    diesel++;
                }
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito Obrigado");
            Console.WriteLine($"Alcool = {alcool}");
            Console.WriteLine($"Gasolina = {gasolina}");
            Console.WriteLine($"Diesel = {diesel}");
        }
    }
}