using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Produto.Model;

namespace Produto {
    class Program {
        static void Main(string[] args) {
 
            int qntd;

            Console.WriteLine("Entre com os dados do produto");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write($"Preço do {nome}: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write($"Quantidade no estoque: ");
            int quantidade_estoque = int.Parse(Console.ReadLine());

            Estoque p = new Estoque(nome, preco, quantidade_estoque);

            EscreverTela("Dados do produto: ");

            EscreverTela(p);
            char op = ' ';

            do {
                Console.WriteLine("Deseja adicionar ou remover um produto no estoque? (s/n)");
                op = char.Parse(Console.ReadLine());
                Console.WriteLine();

                if (op == 's') {
                    Console.WriteLine("Deseja adicionar ou remover um produto no estoque? (a/r)");
                    char op2 = char.Parse(Console.ReadLine());

                    if (op2 == 'a') {
                        AdicionarEstoque(p);
                    } else if (op2 == 'r') {
                        RemoverEstoque(p);
                    } else {
                        Console.WriteLine("Opção inválida");
                    }
                    Console.WriteLine("Dados atualizados: ");
                    EscreverTela(p);
                    Console.WriteLine();
                }

            } while (op != 'n');

        }

        public static void EscreverTela(string texto) {
            Console.WriteLine();
            Console.WriteLine(texto);
        }

        public static void EscreverTela(Estoque produto) {
            Console.WriteLine();
            Console.WriteLine(produto);
        }

        public static void AdicionarEstoque(Estoque produto) {
            EscreverTela("Digite o numero de produtos a ser adicionado no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(quantidade);
        }

        public static void RemoverEstoque(Estoque produto) {
            EscreverTela("Digite o numero de produtos a ser adicionado no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(quantidade);
        }
    }
}