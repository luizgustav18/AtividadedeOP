using AtividadedeOP04;
class Program
{
    static void Main()
    {
        CalculadoradeSalario funcionario = new CalculadoradeSalario();
        funcionario.ReceberDados();
        funcionario.aumentosaliral();
        funcionario.descontos();
        funcionario.exibirsalario();
    }
}