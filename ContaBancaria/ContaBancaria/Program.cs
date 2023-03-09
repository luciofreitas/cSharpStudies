using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(String[] args)
        {
            Conta c;
            Console.Write("Numero da Conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Titular da Conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)");
            char op = char.Parse(Console.ReadLine());
            if (op == 's' || op == 'S')
            {
                Console.Write("Entre com o valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(numero, titular, depositoInicial);
            }
            else
            {
                c = new Conta(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c);
            Console.WriteLine("Deseja realizar algum saque ou deposito?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            int op2 = int.Parse(Console.ReadLine());
            do
            {              
                switch (op2)
                {
                    case 1:
                        Console.WriteLine("O que o senhor(a) deseja realizar");
                        Console.WriteLine("1 - Saque");
                        Console.WriteLine("2 - Deposito");
                        Console.WriteLine("3 - Sair");
                        int op3 = int.Parse(Console.ReadLine());
                        do
                        {
                            switch (op3)
                            {
                                case 1:
                                    Console.Write("Entre com o valor do saque que deseja fazer: ");
                                    double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                    c.Saque(quantia);
                                    EscreverDadosAtualizados("Dados da conta atualizados:");
                                    Console.WriteLine(c);
                                    break;
                                case 2:
                                    Console.Write("Entre com o valor do deposito que deseja fazer: ");
                                    quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                    c.Deposito(quantia);
                                    EscreverDadosAtualizados("Dados da conta atualizados:");
                                    Console.WriteLine(c);
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida");
                                    break;
                            }
                        } while (op3 != 3);
                        break;
                }
            } while (op2 != 2);
        }
        public static void EscreverDadosAtualizados(string texto)
        {
            Console.WriteLine();
            Console.WriteLine(texto);
        }
    }
}