using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseSalarioAtualizar {
    internal class Funcionario {
        public string Nome;
        public double Salario;
        public double Imposto=1000;
        public double Porcentagem;
        double salarioAcrescido;
        public double SalarioLiquido() {
            double salarioLiquido;
            salarioLiquido = Salario - Imposto;
            return salarioLiquido;
        }

        public double PorcentagemSalario() {
            double porcentagem;
            porcentagem = Porcentagem / 100;
            return porcentagem;
        }
        public double AumentarSalario() {
            double salarioAcrescido;           
            salarioAcrescido = Salario + (Salario * PorcentagemSalario());
            return salarioAcrescido;
        }
        public override string ToString() {
            return $"Dados atualizados: O salario do {Nome} com aumento de {Porcentagem}% vai para R$ {AumentarSalario().ToString("F2",CultureInfo.InvariantCulture)}";
        }

    }
}
