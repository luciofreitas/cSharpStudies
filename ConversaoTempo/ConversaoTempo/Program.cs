using System;

namespace ConversaoTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, horas, resto, minutos, segundos;

            Console.WriteLine("Informe quantos segundos deseja converter");
            n = Convert.ToInt32(Console.ReadLine());

            horas = n / 3600;
            resto = n % 3600; // % = mod = o resultado é o resto da divisão

            minutos = resto / 60;
            segundos = resto/ 60;

            Console.WriteLine($"{horas} : {minutos} : {segundos}");
        }
    }
}