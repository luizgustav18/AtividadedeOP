class Entrega
{
    private double distancia;

    public string Endereco { get; set; }

    public double DistanciaKm
    {
        get { return distancia; }
        set
        {
            if (value >= 0)
                distancia = value;
        }
    }

    public string TipoEntrega { get; set; }

    public void ReceberDados()
    {
        Console.Write("Endereço: ");
        Endereco = Console.ReadLine();

        Console.Write("Distância (km): ");
        DistanciaKm = double.Parse(Console.ReadLine());

        Console.Write("Tipo de entrega: ");
        TipoEntrega = Console.ReadLine();
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Entrega: {Endereco} | Distância: {DistanciaKm} km | Tipo: {TipoEntrega}");
    }

    public double CalcularTaxaEntrega()
    {
        return DistanciaKm * 2;
    }
}