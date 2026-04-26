using System;

class Cliente
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Cidade { get; set; }

    public void ReceberDados()
    {
        Console.Write("Nome: ");
        Nome = Console.ReadLine();

        Console.Write("CPF: ");
        Cpf = Console.ReadLine();

        Console.Write("Cidade: ");
        Cidade = Console.ReadLine();
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Cliente: {Nome} | CPF: {Cpf} | Cidade: {Cidade}");
    }

    public string RetornarApresentacao()
    {
        return $"Cliente {Nome}, CPF {Cpf}, mora em {Cidade}";
    }
}