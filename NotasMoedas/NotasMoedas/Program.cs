using System;
using System.Globalization;

namespace NotasMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            double N;

            int quociente, resto, nota, moeda;

            string valorInicial = string.Empty;

            valorInicial = Console.ReadLine();

            if (valorInicial.Contains(","))
                valorInicial = valorInicial.Replace(",",".");

            N = double.Parse(valorInicial,CultureInfo.InvariantCulture);



            //Vamos multiplicar n por 100 e forçar a conversão para int.
            //Vamos também somar 0.5 antes de converter, para assegurar que o numero seja devidamente arredondado, pois o tipo double
            //as vezes, da problema de arredondamento

            resto = (int)(N * 100.0 + 0.5);

            Console.WriteLine("NOTAS: ");

            //Como multiplicamos o valor por 1200 acima, o valor de cada nota também deverá ser multiplicado por 100 a seguir

            nota = 100;
            quociente = resto / (nota * 100);
            Console.WriteLine($"{quociente}nota(s) de R$ {nota} .00");
            resto = resto % (nota * 100);

            nota = 50;
            quociente = resto / (nota * 100);
            Console.WriteLine($"{quociente} notas(s) de R$ {nota} .00");
            resto = resto % (nota * 100);

            nota = 20;
            quociente = resto / (nota * 100);
            Console.WriteLine($"{quociente} notas(s) de R$ {nota} .00");
            resto = resto % (nota * 100);

            nota = 10;
            quociente = resto / (nota * 100);
            Console.WriteLine($"{quociente} nota(s) de R$ {nota} .00");
            resto = resto % (nota * 100);

            nota = 5;
            quociente = resto / (nota * 100);
            Console.WriteLine($"{quociente} nota(s) de R$ {nota} .00");
            resto = resto % (nota * 100);

            nota = 2;
            quociente = resto / (nota * 100);
            Console.WriteLine($"{quociente} nota(s) de R$ {nota} .00");
            resto = resto % (nota * 100);

            Console.WriteLine("MOEDAS: ");

            //o valor de cada moeda deverá ser representado em centavos

            moeda = 100;
            quociente = resto / moeda;
            Console.WriteLine($"{quociente} moeda(s) de R$ 1.00");
            resto = resto % moeda;

            moeda = 50;
            quociente = resto / moeda;
            Console.WriteLine($"{quociente} moeda(s) de R$ 0.50");
            resto = resto % moeda;

            moeda = 25;
            quociente = resto / moeda;
            Console.WriteLine($"{quociente} moeda(s) de R$ 0.25");
            resto = resto % moeda;

            moeda = 10;
            quociente = resto / moeda;
            Console.WriteLine($"{quociente} moeda(s) de R$ 0.10");
            resto = resto % moeda;

            moeda = 5;
            quociente = resto / moeda;
            Console.WriteLine($"{quociente} moeda(s) de R$ 0.05");
            resto = resto % moeda;


            Console.WriteLine($"{resto} moeda(s) de R$ 0.01");
        }
    }
}