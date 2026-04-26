class Vendedor
{
    private string nome;
    private double percentual;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Matricula
    {
        get { return nome + "10"; }
    }

    public double PercentualComissao
    {
        get { return percentual; }
        set
        {
            if (value >= 0)
                percentual = value;
        }
    }

    public void ReceberDados()
    {
        Console.Write("Nome do vendedor: ");
        Nome = Console.ReadLine();

        Console.Write("Percentual de comissão: ");
        PercentualComissao = double.Parse(Console.ReadLine());
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Vendedor: {Nome} | Matrícula: {Matricula} | Comissão: {PercentualComissao}%");
    }

    public double CalcularComissao(double valorPedido)
    {
        return valorPedido * (PercentualComissao / 100);
    }
}