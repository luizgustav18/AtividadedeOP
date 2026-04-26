using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AtividadedeOP04
{
    class CalculadoradeSalario
    {
        public string nomefuncionario;
        public double salario;
        public double salarioTotal;

        public void ReceberDados()
        {
            Console.Write("Digite o nome do funcionário: ");
            nomefuncionario = Console.ReadLine();
            Console.Write("Digite o salário do funcionário: ");
            salario = double.Parse(Console.ReadLine());
        }
        public void aumentosaliral()
        {
            Console.WriteLine("É um aumento de salário? ");
            string resposta = Console.ReadLine();
            if (resposta.ToLower() == "sim") 
            {
                
                Console.WriteLine("Qual a porcentagem de aumento a receber? ");
                int porcentagem = int.Parse(Console.ReadLine());
                double somasalario = salario * (porcentagem / 100.0);
                salarioTotal = salario + somasalario;

                Console.WriteLine("O salario com a porcentagem: " + salarioTotal);
            }
            else
            {
                Console.WriteLine("Nenhuma alteração feita no salário.");
            }
            
        }
        public void descontos()
        {
            Console.WriteLine("Houve descontos? ");
            string resposta = Console.ReadLine();
            if (resposta.ToLower() == "sim")
            {
                Console.WriteLine("Qual a porcentagem de desconto a receber? ");
                int porcentagem = int.Parse(Console.ReadLine());
                double descsalario = salario * (porcentagem / 100.0);
                salarioTotal = salarioTotal - descsalario;
                Console.WriteLine("O salario com a porcentagem: " + salarioTotal);
            }
            else
            {
                Console.WriteLine("Nenhuma alteração feita no salário.");
            }
        }
        public void exibirsalario()
        {
            Console.WriteLine("Nome do funcionário: " + nomefuncionario);
            Console.WriteLine("Salário bruto: " + salario );
            Console.WriteLine("Salário liquido: " + salarioTotal );
        }

    }
}
