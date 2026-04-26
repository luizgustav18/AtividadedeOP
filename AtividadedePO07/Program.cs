using AtividadedePO07;
using System;

namespace AtividadedePO07
{
    class Program
    {
        static void Main()
        {
            Filme f1 = new Filme();
            Filme f2 = new Filme();

            Console.WriteLine("=== Filme 1 ===");
            f1.ReceberDadosFilme();

            Console.WriteLine("\n=== Filme 2 ===");
            f2.ReceberDadosFilme();

            f1.ExibirResumo();
            f2.ExibirResumo();

            Console.WriteLine("\nTestando permissão:");
            f1.EhPermitido();

            Console.WriteLine("\nAlterando duração do Filme 2:");
            f2.AlterarDuracao();
            f2.ExibirResumo();
        }
    }
}