using System;

class Aluno
{
    public string RA;
    public string Nome;
    public double NotaProva;
    public double NotaTrabalho;
    public double NotaFinal;

    public void ReceberDados()
    {
        Console.Write("Digite o RA: ");
        RA = Console.ReadLine();

        Console.Write("Digite o Nome: ");
        Nome = Console.ReadLine();

        Console.Write("Digite a Nota da Prova: ");
        NotaProva = double.Parse(Console.ReadLine());

        Console.Write("Digite a Nota do Trabalho: ");
        NotaTrabalho = double.Parse(Console.ReadLine());
    }

    public void CalcularMedia()
    {
        NotaFinal = (NotaProva + NotaTrabalho) / 2;
    }

    public bool CalcularNotaFinal()
    {


        if (NotaFinal >= 7)
        {
            Console.WriteLine("Aluno aprovado diretamente!");
            return true;
        }
        else
        {
            double precisa = (10 - NotaFinal);

            Console.WriteLine("Precisa fazer prova final.");
            Console.WriteLine("Nota necessária na final: " + precisa);

            return false;
        }
    }

    public void ImprimirNotaFinal()
    {
        Console.WriteLine("Nota final (média): " + NotaFinal);
    }
}