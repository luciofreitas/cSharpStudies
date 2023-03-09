using System;
using System.Globalization;

namespace Retangulo {
    class Program {
        static void Main(string[] args) {
            Retangulo r;
            r = new Retangulo();
            double resposta=0;

            Console.WriteLine("Informe a largura");
            r.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura");
            r.Altura = double.Parse(Console.ReadLine());

            EscreverTela(r);
           
            

        }
        public static void EscreverTela(string texto) {
            Console.WriteLine();
            Console.WriteLine(texto);

        }
        public static void EscreverTela(Retangulo r) {
            Console.WriteLine();
            Console.WriteLine(r);
        }
    }
}
