using System;

namespace TempoJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal,duracaoJogo;

            string[] vet = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(vet[0]);
            horaFinal = int.Parse(vet[1]);

            duracaoJogo = horaFinal - horaInicial; 
            
            if(horaInicial < horaFinal)
            {
                duracaoJogo = horaFinal - horaInicial;

            }
            else
            {
                duracaoJogo = 24 - horaInicial + horaFinal;
            }
            Console.WriteLine($"O jogo durou {duracaoJogo} horas");
        }
    }
}