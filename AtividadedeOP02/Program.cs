using AtividadedeOP02;
class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria();
        conta.ReceberDados();
        conta.Depositar();
        conta.Sacar();
        conta.MostrarSaldo();
    }
}