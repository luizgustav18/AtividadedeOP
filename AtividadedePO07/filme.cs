using System;

namespace AtividadedePO07
{
    public class Filme
    {
        public string Titulo;
        public string Genero;
        public int DuracaoMinutos;
        public int Classificacao;

        public void ReceberDadosFilme()
        {
            Console.WriteLine("Digite o título do filme:");
            Titulo = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(Titulo))
                Titulo = "Sem título";

            Console.WriteLine("Digite o gênero:");
            Genero = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(Genero))
                Genero = "Não informado";

            Console.WriteLine("Digite a duração em minutos:");
            DuracaoMinutos = int.Parse(Console.ReadLine());

            if (DuracaoMinutos <= 0)
                DuracaoMinutos = 1;

            Console.WriteLine("Digite a classificação indicativa:");
            Classificacao = int.Parse(Console.ReadLine());

            if (Classificacao < 0)
                Classificacao = 0;
        }

        public void ExibirResumo()
        {
            Console.WriteLine("\n--- Dados do Filme ---");
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Gênero: " + Genero);
            Console.WriteLine("Duração: " + DuracaoMinutos + " minutos");
            Console.WriteLine("Classificação: " + Classificacao + "+");
        }

        public void EhPermitido()
        {
            Console.WriteLine("Digite a idade da pessoa:");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= Classificacao)
                Console.WriteLine("Pode assistir ao filme.");
            else
                Console.WriteLine("Não pode assistir ao filme.");
        }

        public void AlterarDuracao()
        {
            Console.WriteLine("Digite a nova duração:");
            int novaDuracao = int.Parse(Console.ReadLine());

            if (novaDuracao > 0)
            {
                DuracaoMinutos = novaDuracao;
                Console.WriteLine("Duração alterada com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor inválido!");
            }
        }
    }
}