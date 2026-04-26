using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadedeOP02
{
    class ContaBancaria
    {
        public int Id;
        public string NomeTitular;
        public double Saldo;

        public void ReceberDados()
        {

            Console.Write("Digite o ID da conta: ");
            Id = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular: ");
            NomeTitular = Console.ReadLine();
            Saldo = 0;
            Console.WriteLine("Saldo inicial: " + Saldo);
        }

        public void Depositar()
        {
            Console.Write("Digite o valor a ser depositado: ");
            int valorDeposito = int.Parse(Console.ReadLine());
            Saldo += valorDeposito;
            Console.WriteLine("Saldo atualizado: " + Saldo);
        }

        public void Sacar()
        {
            Console.Write("Digite um valor a sacar: ");
            int valorSaque = int.Parse(Console.ReadLine());

            if (valorSaque > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }
            else
            {
                Saldo -= valorSaque;
                Console.WriteLine("Saque realizado com sucesso. Saldo atualizado: " + Saldo);
            }
        }

        public void MostrarSaldo()
        {
            Console.WriteLine("Saldo atual: " + Saldo);
        }   
    }
}

