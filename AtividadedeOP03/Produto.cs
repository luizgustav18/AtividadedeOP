using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AtividadedeOP03
{
    class Produto
    {
        public string nome;
        public string codigo;
        public double preco;
        public int quantidade;
        public int estoqueatual;

        public void ReceberDados()
        {
            Console.Write("Digite o codigo do produto: ");
            codigo= Console.ReadLine();
            Console.Write("Digite o nome do produto: ");
            nome = Console.ReadLine();
            Console.Write("Digite o preço do produto: ");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de produtos: ");
            quantidade = int.Parse(Console.ReadLine());
        }
        public void AdicionarEstoque()
        {
            Console.WriteLine("Estoque atual: " + estoqueatual);
            Console.WriteLine("Deseja adicionar ao estoque? ");
            string resposta = Console.ReadLine();

            if (resposta.ToLower() == "sim")
            {
                Console.WriteLine("Digite a quantidade a ser adicionada: ");
                int quantidadeAdicionar = int.Parse(Console.ReadLine());

                estoqueatual += quantidadeAdicionar;

                Console.WriteLine("Quantidade atualizada: " + estoqueatual);
            }
            else
            {
                Console.WriteLine("Nenhuma alteração feita no estoque.");
            }

        }
        public void removerestoque()
        {
            Console.WriteLine("Deseja retirar algo do estoque? ");
            string resposta = Console.ReadLine();
            if (resposta.ToLower() == "sim")
            {
                Console.WriteLine("Digite a quantidade a ser retirada: ");
                int quantidadeRetirar = int.Parse(Console.ReadLine());
                if (quantidadeRetirar > estoqueatual)
                {
                    Console.WriteLine("Quantidade insuficiente no estoque para retirar.");
                }
                else
                {
                    estoqueatual -= quantidadeRetirar;
                    Console.WriteLine("Quantidade atualizada: " + estoqueatual);
                }
            }
            else
            {
                Console.WriteLine("Nenhuma alteração feita no estoque.");

            }
        }
        public void MostrarProduto()
        {
            Console.WriteLine("Código do produto: " + codigo);
            Console.WriteLine("Nome do produto: " + nome);
            Console.WriteLine("Preço do produto: " + preco);
            Console.WriteLine("Quantidade em estoque: " + estoqueatual);
        }
    }
}
