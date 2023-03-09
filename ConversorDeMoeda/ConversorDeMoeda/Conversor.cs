using System;

namespace ConversorDeMoeda
{
    internal class Conversor
    {
        public static double Real;
        public static double Dolar;
        public static double Cotacao;
        public static double IOF=6/100;

        public static double ConvRealToDolar(double Real, double Cotacao)
        {
            double realIOF = Real - IOF;
            Dolar = realIOF * Cotacao;
            //double conversao = Dolar - (Dolar * IOF);
            return Dolar;
        }

        public static double ConvDolarToReal(double Dolar, double Cotacao )
        {
            double dolarIOF = Dolar - IOF;
            Real = dolarIOF / Cotacao;
            // double conversao = Real - (Dolar * IOF);
            return Real;
        }

        
    }
}
