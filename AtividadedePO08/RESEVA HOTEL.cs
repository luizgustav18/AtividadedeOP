using System;

namespace AtividadedePO08
{
    public class ReservaHotel
    {
        public string NomeHospede;
        public int NumeroQuarto;
        public int QuantidadeDiarias;
        public double ValorDiaria;
        public string Status;

        public ReservaHotel(string nome, int quarto)
        {
            NomeHospede = string.IsNullOrWhiteSpace(nome) ? "Hóspede não informado" : nome;
            NumeroQuarto = quarto <= 0 ? 1 : quarto;

            QuantidadeDiarias = 1;
            ValorDiaria = 50;
            Status = "Ativa";
        }

        public ReservaHotel(string nome, int quarto, int diarias, double valor)
        {
            NomeHospede = string.IsNullOrWhiteSpace(nome) ? "Hóspede não informado" : nome;
            NumeroQuarto = quarto <= 0 ? 1 : quarto;
            QuantidadeDiarias = diarias <= 0 ? 1 : diarias;
            ValorDiaria = valor <= 0 ? 50 : valor;
            Status = "Ativa";
        }

        public double CalcularTotal()
        {
            return QuantidadeDiarias * ValorDiaria;
        }

        public void ExibirReserva()
        {
            Console.WriteLine("\n--- Dados da Reserva ---");
            Console.WriteLine("Hóspede: " + NomeHospede);
            Console.WriteLine("Quarto: " + NumeroQuarto);
            Console.WriteLine("Diárias: " + QuantidadeDiarias);
            Console.WriteLine("Valor da diária: " + ValorDiaria);
            Console.WriteLine("Status: " + Status);
            Console.WriteLine("Total: " + CalcularTotal());
        }

        public void AdicionarDiarias(int quantidade)
        {
            if (quantidade > 0)
            {
                QuantidadeDiarias += quantidade;
                Console.WriteLine("Diárias adicionadas com sucesso!");
            }
            else
            {
                Console.WriteLine("Quantidade inválida!");
            }
        }

        public void CancelarReserva()
        {
            Status = "Cancelada";
        }

        public void ReativarReserva()
        {
            Status = "Ativa";
        }
    }
}