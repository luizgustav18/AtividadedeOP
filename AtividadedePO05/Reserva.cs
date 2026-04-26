using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadedePO05
{
    public class Reserva
    {
        public int NumeroReserva;
        public int QuantidadeDiarias;
        public int ValorDiaria;
        public int ValorTotal;
        public double ValorDesconto;
        public double ValorFinal;

        public void ReceberDadosReserva()
        {
            Console.WriteLine("Digite o número da reserva: ");
            NumeroReserva = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de diárias: ");
            QuantidadeDiarias = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da diária: ");
            ValorDiaria = int.Parse(Console.ReadLine());
        }

        public void CalcularValorTotal()
        {
            ValorTotal = QuantidadeDiarias * ValorDiaria;
        }

        public void CalcularDesconto()
        {
            Console.WriteLine("Digite a porcentagem de desconto (%): ");
            double porcentagem = double.Parse(Console.ReadLine());

            ValorDesconto = ValorTotal * (porcentagem / 100);
            ValorFinal = ValorTotal - ValorDesconto;
        }

        public void MostrarReserva()
        {
            Console.WriteLine("\n--- Dados da Reserva ---");
            Console.WriteLine("Número da reserva: " + NumeroReserva);
            Console.WriteLine("Quantidade de diárias: " + QuantidadeDiarias);
            Console.WriteLine("Valor da diária: " + ValorDiaria);
            Console.WriteLine("Valor total: " + ValorTotal);
            Console.WriteLine("Desconto: " + ValorDesconto);
            Console.WriteLine("Valor final com desconto: " + ValorFinal);
        }
    }
}