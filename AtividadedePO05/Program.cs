using AtividadedePO05;

class Program
{
    static void Main()
    {
       hopedes hospedes_ = new hopedes();
       hospedes_.Receberdados();
      
       Reserva reserva_ = new Reserva();
       reserva_.ReceberDadosReserva();
       reserva_.CalcularValorTotal();
       reserva_.CalcularDesconto();


       reserva_.MostrarReserva();
       hospedes_.exibirdados();
    }
}