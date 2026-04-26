using AtividadedePO08;
using System;

namespace AtividadedePO05
{
    class Program
    {
        static void Main()
        {
            ReservaHotel r1 = new ReservaHotel("Carlos", 12);
            ReservaHotel r2 = new ReservaHotel("", -8, 0, -300);

            r1.ExibirReserva();
            r2.ExibirReserva();

            Console.WriteLine("\nTotal r1: " + r1.CalcularTotal());
            Console.WriteLine("Total r2: " + r2.CalcularTotal());

            Console.WriteLine("\nAdicionando diárias em r1...");
            r1.AdicionarDiarias(2);
            r1.ExibirReserva();

            Console.WriteLine("\nCancelando r2...");
            r2.CancelarReserva();
            r2.ExibirReserva();

            Console.WriteLine("\nReativando r2...");
            r2.ReativarReserva();
            r2.ExibirReserva();
        }
    }
}