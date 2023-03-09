using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Retangulo {
    internal class Retangulo {
       
        public double Largura;
        public double Altura;

        public double Area() {
           double area = Altura * Largura;
            return area;
        }

        public double Perimetro () {
            double perimetro = 2 * (Altura + Largura);
            return perimetro;
        }

        public double Diagonal () {
            double diagonal = Math.Sqrt(Math.Pow(Largura,2)+Math.Pow(Altura,2));
            return diagonal;
        }
        public override string ToString() {
            return $"AREA = {Area().ToString("F2", CultureInfo.InvariantCulture)}, PERIMETRO = {Perimetro().ToString("F2", CultureInfo.InvariantCulture)}, DIAGONAL = {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
