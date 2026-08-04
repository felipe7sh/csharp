class Produtos
{
    public string nome;
    public int Quantidade;
    public double Preço;
    public double peso;
    public void ExibirProduto()
    {
        Console.WriteLine($"Produto: {nome}, Quantidade {Quantidade}, Preço {Preço} Reais, Peso {peso} Gramas");
    }
}


class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine($"===== Sistema De Cadastro de Produtos ======");

        Produtos p1 = new Produtos();
        p1.nome = "Limão";
        p1.Quantidade = 50;
        p1.Preço = 4.99;
        p1.peso = 50;
        p1.ExibirProduto();

        Produtos p2 = new Produtos();
        p2.nome = "Banana";
        p2.Quantidade = 50;
        p2.Preço = 7.99;
        p2.peso = 100;
        p2.ExibirProduto();

        Produtos p3 = new Produtos();
        p3.nome = "Maça";
        p3.Quantidade = 30;
        p3.Preço = 5.99;
        p3.peso = 100;
        p3.ExibirProduto();

        Produtos p4 = new Produtos();
        p4.nome = "Abacaxi";
        p4.Quantidade = 30;
        p4.Preço = 10.99;
        p4.peso = 1000;
        p4.ExibirProduto();

        Produtos p5 = new Produtos();
        p5.nome = "Melancia";
        p5.Quantidade = 20;
        p5.Preço = 15.99;
        p5.peso = 2000;
        p5.ExibirProduto();

        string ti = p1.nome + ", " + p2.nome + ", " + p3.nome + ", " + p4.nome + ", " + p5.nome;
        int qt = p1.Quantidade + p2.Quantidade + p3.Quantidade + p4.Quantidade + p5.Quantidade;
        double tp = p1.Quantidade * p1.Preço + p2.Quantidade * p2.Preço + p3.Quantidade * p3.Preço + p4.Quantidade * p4.Preço + p5.Quantidade * p5.Preço; 
        double tpeso = p1.peso*p1.Quantidade + p2.peso*p2.Quantidade + p3.peso * p3.Quantidade + p4.peso * p4.Quantidade + p5.peso * p5.Quantidade;

        Console.WriteLine($"[Total] Itens: {ti}");
        Console.WriteLine($"[Total] Quantidade: {qt} Itens");
        Console.WriteLine($"[Total] Preço: {tp} Reais");
        Console.WriteLine($"[Total] Peso: {tpeso} Gramas");


    }
}

