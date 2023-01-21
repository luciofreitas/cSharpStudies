using System;

namespace ifHoras
{
    class Program
    {
        static void Main(string[] args)
        {
            double horas;

            Console.WriteLine("Informe as horas ");
            horas = double.Parse(Console.ReadLine());

            if (horas < 12)
            {
                Console.WriteLine("Bom dia");

            }
            else if (horas >= 12 && horas < 18)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }



        }
    }
}