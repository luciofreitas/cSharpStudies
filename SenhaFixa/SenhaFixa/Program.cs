using System;

namespace SenhaFixa
{
    class Program
    {
        static void Main(string[] args)
        {
            int inserirSenha;

            inserirSenha = int.Parse(Console.ReadLine());

            while(inserirSenha != 2002)
            {
                Console.WriteLine("Senha Inválida");
                inserirSenha = int.Parse(Console.ReadLine());              
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}