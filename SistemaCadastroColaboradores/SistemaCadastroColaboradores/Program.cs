using SistemaCadastroColaboradores;

List<Funcionario> listaPessoa = new List<Funcionario>();

Console.WriteLine("===== SISTEMA CADASTRO DE COLABORADORES =====\n");
Console.Write("Deseja cadastrar um colaborador? (s/n): ");
string resposta = Console.ReadLine();

while (resposta.ToLower() == "s")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n----- MENU DE CADASTRO -----");
    Console.ResetColor();

    Console.WriteLine("1. Cadastrar Professor");
    Console.WriteLine("2. Cadastrar Secretario");
    Console.WriteLine("3. Listar Cadastros");

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("4. Sair");
    Console.ResetColor();

    Console.Write("\nEscolha sua opção: ");
    string opcao = Console.ReadLine();

    if (opcao == "1")
    {
        Professor pro = new Professor();
        Console.Write("Informe o Nome: ");
        pro.Nome = Console.ReadLine();

        Console.Write("Informe o Email: ");
        pro.Email = Console.ReadLine();

        Console.Write("Informe o Salario: ");
        pro.Salario = Console.ReadLine();

        Console.Write("Informe o Telefone: ");
        pro.Telefone = Console.ReadLine();

        Console.Write("Informe o CPF: ");
        pro.CPF = Console.ReadLine();

        Console.Write("Informe a Disciplina: ");
        pro.Disciplina = Console.ReadLine();

        Console.Write("Informe a Carga Horaria: ");
        pro.CargaHoraria = Console.ReadLine(); 

        Console.Write("Informe a Formação: ");
        pro.Formacao = Console.ReadLine();


        listaPessoa.Add(pro);
    }

    else if (opcao == "2")
    {
        Secretario sec = new Secretario();
        Console.Write("Informe o Nome: ");
        sec.Nome = Console.ReadLine();

        Console.Write("Informe o Email: ");
        sec.Email = Console.ReadLine();

        Console.Write("Informe o Salario: ");
        sec.Salario = Console.ReadLine();

        Console.Write("Informe o Telefone: ");
        sec.Telefone = Console.ReadLine();

        Console.Write("Informe o CPF: ");
        sec.CPF = Console.ReadLine();

        Console.Write("Informe o Setor: ");
        sec.Setor = Console.ReadLine();

        Console.Write("Informe o Ramal: ");
        sec.Ramal = Console.ReadLine();

        Console.Write("Informe o Turno: ");
        sec.Turno = Console.ReadLine();

        listaPessoa.Add(sec);
    }

    else if (opcao == "3")
    {
        Console.WriteLine("Lista de Colaboradores Cadastrados");
        foreach (var p in listaPessoa)
        {
            
            p.ExibirDados();
        }

        
    }

    else if (opcao == "4")
    {
        Console.WriteLine("Saindo...");
        resposta = "n";
    }

    else 
    {
        Console.WriteLine("Opção Invalida.");
    }
}

