using CadastroPessoa;

/* nesse sistema o usuario ira cadastrar pessoas fisicas e juridicas.
 * iremos utiliza recurso de LIST para gerarmos uma lista de pessoas
 */

List<Pessoa> listaPessoa = new List<Pessoa>();

Console.WriteLine("===== SISTEMA CADASTRO DE PESSOAS =====\n");
Console.Write("Deseja cadastrar uma pessoa? (s/n): ");
string resposta = Console.ReadLine();

while (resposta.ToLower() == "s")
{
    Console.WriteLine("\n----- CADASTRAR -----");
    Console.WriteLine("1. Cadastrar Pessoa Fisica");
    Console.WriteLine("2. Cadastrar Pessoa Juridica");
    Console.WriteLine("3. Listar Cadastros");
    Console.WriteLine("4. Sair");
    Console.Write("\nEscolha sua opção: ");
    string opcao = Console.ReadLine();

    if (opcao == "1")
    {
        PessoaFisica pf = new PessoaFisica();
        Console.Write("Informe o Nome: ");
        pf.Nome = Console.ReadLine();

        Console.Write("Informe o Endereço: ");
        pf.Endereco = Console.ReadLine();

        Console.Write("Informe a Cidade: ");
        pf.Cidade = Console.ReadLine();

        Console.Write("Informe o Estado: ");
        pf.Estado = Console.ReadLine();

        Console.Write("Informe o CEP: ");
        pf.CEP = Console.ReadLine();

        Console.Write("Informe o CPF: ");
        pf.CPF = Console.ReadLine();

        listaPessoa.Add(pf);
    }

    else if (opcao == "2")
    {
        PessoaJuridica pj = new PessoaJuridica();
        Console.Write("Informe o Nome: ");
        pj.Nome = Console.ReadLine();

        Console.Write("Informe o Endereço: ");
        pj.Endereco = Console.ReadLine();

        Console.Write("Informe a Cidade: ");
        pj.Cidade = Console.ReadLine();

        Console.Write("Informe o Estado: ");
        pj.Estado = Console.ReadLine();

        Console.Write("Informe o CEP: ");
        pj.CEP = Console.ReadLine();

        Console.Write("Informe o CNPJ: ");
        pj.CNPJ = Console.ReadLine();

        listaPessoa.Add(pj);
    }

    else if (opcao == "3")
    {
        Console.WriteLine("Lista de Pessoas Cadastradas");
        foreach (var p in listaPessoa)
        {
            p.ExibirDados();
        }
    }

    else if (opcao == "4")
    {
        resposta = "n";
    }

    else 
    {
        Console.WriteLine("Opção Invalida.");
    }
}

