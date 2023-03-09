using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto.Model
{
    internal class Estoque
    {
        public string Nome;
        public double Preco;
        public int Qntd_estoque;

        public Estoque()
        {

        }

        public Estoque(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Qntd_estoque = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Qntd_estoque;
        }

        public void AdicionarProdutos(int qntd)
        {
            Qntd_estoque += qntd;

        }

        public void RemoverProdutos(int qntd)
        {
            Qntd_estoque -= qntd;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, têm {Qntd_estoque} unidades no estoque, R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)} e o Total {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
