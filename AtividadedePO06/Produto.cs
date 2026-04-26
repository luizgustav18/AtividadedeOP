class Produto
{
    private double preco;
    private int quantidade;

    public string Descricao { get; set; }

    public double PrecoUnitario
    {
        get { return preco; }
        set
        {
            if (value >= 0)
                preco = value;
        }
    }

    public int Quantidade
    {
        get { return quantidade; }
        set
        {
            if (value > 0)
                quantidade = value;
        }
    }

    public void ReceberDados()
    {
        Console.Write("Descrição: ");
        Descricao = Console.ReadLine();

        Console.Write("Preço: ");
        PrecoUnitario = double.Parse(Console.ReadLine());

        Console.Write("Quantidade: ");
        Quantidade = int.Parse(Console.ReadLine());
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Produto: {Descricao} | Preço: {PrecoUnitario} | Qtd: {Quantidade}");
    }

    public double CalcularSubtotal()
    {
        return PrecoUnitario * Quantidade;
    }
}