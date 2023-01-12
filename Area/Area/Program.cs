using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, area, pi = 3.14159;

            int menu0 = 0, menu1 = 0, menu2 = 0, menu3 = 0, menu4 = 0, menu5 = 0;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Fazendo programa com c#");
                Console.WriteLine("");
                Console.WriteLine("Escolha uma das opções abaixo");
                Console.WriteLine("");
                Console.WriteLine("1 - Area do triangulo retangulo");
                Console.WriteLine("2 - Area do curculo");
                Console.WriteLine("3 - Area do trapézio");
                Console.WriteLine("4 - Area do quadrado");
                Console.WriteLine("5 - Area do retangulo");
                Console.WriteLine("6 - Sair");
                menu0 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (menu0)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Area do triangulo retangulo");
                            Console.WriteLine("1 - Calcular Area");
                            Console.WriteLine("2 - Sair");
                            menu1 = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (menu1)
                            {
                                case 1:
                                    Console.WriteLine("Informe, por favor, a base do triangulo retangulo");
                                    A = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Informe, agora, a altura do  triangulo retangulo");
                                    C = Convert.ToInt32(Console.ReadLine());
                                    area = A * C;
                                    Console.WriteLine($" A area do triangulo retangulo é igual a {area}");
                                    Console.WriteLine("");
                                    break;
                            }
                        } while (menu1 != 2);
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Area do Circulo");
                            Console.WriteLine("1 - Calcular Area");
                            Console.WriteLine("2 - Sair");
                            menu2 = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (menu2)
                            {
                                case 1:
                                    Console.WriteLine("Informe, por favor, o raio do Circulo");
                                    C = Convert.ToDouble(Console.ReadLine());
                                    area = C * Math.Pow(pi, 2);
                                    Console.WriteLine($"A area do circulo é igual a {area}");
                                    Console.WriteLine("");
                                    break;
                            }
                        } while (menu2 != 2);
                        break;
                    case 3:
                        do
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Area do Trapézio");
                            Console.WriteLine("1 - Calcular Area");
                            Console.WriteLine("2 - Sair");
                            menu3 = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (menu3)
                            {
                                case 1:
                                    Console.WriteLine("Informe, por favor, a base maior");
                                    A = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Informe, agora, a base menor");
                                    B = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Informe a altura");
                                    C = Convert.ToDouble(Console.ReadLine());
                                    area = (A + B) * C / 2;
                                    Console.WriteLine($"A area do circulo é igual a {area}");
                                    Console.WriteLine("");
                                    break;
                            }
                        } while (menu3 != 2);
                        break;
                    case 4:
                        do
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Area do quadrado");
                            Console.WriteLine("1 - Calcular Area");
                            Console.WriteLine("2 - Sair");
                            menu4 = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (menu4)
                            {
                                case 1:
                                    Console.WriteLine("Informe o comprimento");
                                    B = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Informe a altura");
                                    C = Convert.ToDouble(Console.ReadLine());
                                    area = B * C;
                                    Console.WriteLine($"A area do quadrado é igual a {area}");
                                    Console.WriteLine("");
                                    break;
                            }
                        } while (menu4 != 2);
                        break;
                    case 5:
                        do
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Area do retangulo");
                            Console.WriteLine("1 - Calcular Area");
                            Console.WriteLine("2 - Sair");
                            menu5 = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (menu5)
                            {
                                case 1:
                                    Console.WriteLine("Informe o comprimento");
                                    A = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Informe a altura");
                                    B = Convert.ToDouble(Console.ReadLine());
                                    area = A * B;
                                    Console.WriteLine($"A area do retangulo é igual a {area}");
                                    Console.WriteLine("");
                                    break;
                            }
                        } while (menu5 != 2);
                        break;                       
                    default:                     
                        break;
                }
            } while (menu0 != 6);
        }
    }
}