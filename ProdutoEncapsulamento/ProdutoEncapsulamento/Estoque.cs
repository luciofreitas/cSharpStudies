using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoEncapsulamento
{
    internal class Estoque
    {
        private string _nome;
        public double Preco { get; private set; }
        public double Quantidade { get; private set; }

        public Estoque()
        {

        }

        public Estoque(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int qntd)
        {
            Quantidade += qntd;

        }

        public void RemoverProdutos(int qntd)
        {
            Quantidade -= qntd;
        }

        public override string ToString()
        {
            return $"Nome: {_nome}, têm {Quantidade} unidades no estoque, R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)} e o Total {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
