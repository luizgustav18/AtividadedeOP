class Program
{
    static void Main()
    {
        Cliente c = new Cliente();
        c.ReceberDados();

        Vendedor v = new Vendedor();
        v.ReceberDados();

        Produto p = new Produto();
        p.ReceberDados();

        Pagamento pg = new Pagamento();
        pg.ReceberDados();

        Entrega e = new Entrega();
        e.ReceberDados();

        Pedido pedido = new Pedido(1);

        pedido.Cliente = c;
        pedido.Vendedor = v;
        pedido.Produto = p;
        pedido.Pagamento = pg;
        pedido.Entrega = e;

        pedido.ExibirResumo();
    }
}