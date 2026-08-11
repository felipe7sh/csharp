using ProjetoRoupas;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("=== SISTEMA DE CADASTRO DE ROUPAS ===");
Console.ResetColor();

Console.ForegroundColor= ConsoleColor.Red;
Console.WriteLine("Deseja cadastrar roupa (s/n)?");
Console.ResetColor();

List<Roupa> estoque = new List<Roupa>();

string resposta = Console.ReadLine();
while (resposta.ToLower() == "s")
{
    Roupa novapeca = new Roupa();

    Console.WriteLine("Digite a descrição da peça (ex: Camiseta Polo): ");
    novapeca.Descricao = Console.ReadLine();


    Console.WriteLine("Digite o tamanho da peça (ex: P, M, G): ");
    novapeca.Tamanho = Console.ReadLine();

    Console.WriteLine("Digite o valor da peça: ");
    novapeca.Preco = Convert.ToDouble(Console.ReadLine());

    estoque.Add(novapeca);

    Console.Write("Deseja cadastrar outra peça (s/n)");
    resposta = Console.ReadLine();
}

Console.WriteLine("=== ESTOQUE FINAL DE ROUPAS ===");

if (estoque.Count > 0)
{
    foreach (Roupa PecaAtual in estoque)
    {
        PecaAtual.ExibirDetalhes();
    }
}
else
{
    Console.WriteLine("ESTOQUE VAZIO");
}
Console.WriteLine("FIM DA APLICAÇAO");