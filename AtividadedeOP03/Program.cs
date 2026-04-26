using AtividadedeOP03;
class Program
{
    static void Main()
    {
        Produto produtoi = new Produto();
        produtoi.ReceberDados();
        produtoi.AdicionarEstoque();
        produtoi.removerestoque();
        produtoi.MostrarProduto();

    }
}
