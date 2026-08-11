using ProjAlimentos;

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("=== SISTEMA DE CADASTRO DE ALIMENTOS ===");
Console.ResetColor();

Console.WriteLine("Deseja cadastrar Alimentos (s/n)?");

List<Alimentos> estoque = new List<Alimentos>();

string resposta = Console.ReadLine();
while (resposta.ToLower() == "s")
{
    Alimentos novoAlimento = new Alimentos();

    Console.WriteLine("Digite o nome do alimento: ");
    novoAlimento.Nome = Console.ReadLine();

    Console.WriteLine("Digite a marca do alimento: ");
    novoAlimento.Marca = Console.ReadLine();

    Console.WriteLine("Digite a categoria do alimento: ");
    novoAlimento.Categoria = Console.ReadLine();

    Console.WriteLine("Digite o peso do alimento: ");
    novoAlimento.Peso = Console.ReadLine();

    Console.WriteLine("Digite a validade do alimento: ");
    novoAlimento.Validade = Console.ReadLine();

    Console.WriteLine("Digite o valor do alimento: ");
    novoAlimento.Preco = Convert.ToDouble(Console.ReadLine());

    estoque.Add(novoAlimento);

    Console.Write("Deseja cadastrar outro alimento (s/n)");
    resposta = Console.ReadLine();
}

Console.WriteLine("=== ESTOQUE FINAL DE ALIMENTOS ===");

if (estoque.Count > 0)
{
    foreach (Alimentos alimeATual in estoque)
    {
        alimeATual.ExibirAlimentos();
    }
}
else
{
    Console.WriteLine("ESTOQUE VAZIO");
}
Console.WriteLine("FIM DA APLICAÇAO");