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
    Console.WriteLine("3. Cadastrar Coordenador");
    Console.WriteLine("4. Listar Cadastros");
    Console.WriteLine("5. Buscar Colaborador");
    Console.WriteLine("6. Remover Colaborador");

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("7. Sair");
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
        pro.Salario = double.Parse(Console.ReadLine());

        Console.Write("Informe a Disciplina: ");
        pro.Disciplina = Console.ReadLine();

        Console.Write("Informe a Quantidade de Horas de Aula Semanal: ");
        pro.HorasAulaSemanal = int.Parse(Console.ReadLine()); 

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
        sec.Salario = double.Parse(Console.ReadLine());

        Console.Write("Informe o Setor: ");
        sec.Setor = Console.ReadLine();

        Console.Write("Informe o Ramal: ");
        sec.Ramal = int.Parse(Console.ReadLine());

        listaPessoa.Add(sec);
    }

    else if (opcao == "3")
    {
        Coordenador coor = new Coordenador();
        Console.Write("Informe o Nome: ");
        coor.Nome = Console.ReadLine();

        Console.Write("Informe o Email: ");
        coor.Email = Console.ReadLine();

        Console.Write("Informe o Salario: ");
        coor.Salario = double.Parse(Console.ReadLine());

        Console.Write("Informe o Curso Supervisionado: ");
        coor.CursoSupervisionado = Console.ReadLine();

        Console.Write("Informe Quantidade de Professores Supervisionados: ");
        coor.ProfessoresSupervisionados = int.Parse(Console.ReadLine()); 
        listaPessoa.Add(coor);
    }
    else if (opcao == "4")
    {
        Console.WriteLine("Lista de Colaboradores Cadastrados");

        double total = 0;

        foreach (var p in listaPessoa)
        {
            
            p.ExibirDados();
            p.CalcularBonus();
            if (p is Coordenador)
            {
                total = total + p.Salario + (p.Salario * 0.15);
            }

            else
            {
                total = total + p.Salario + (p.Salario * 0.10);
            }
            
        }

        Console.WriteLine($"\nCusto total da folha salarial: {total}");
    }

    else if (opcao == "5")
    {
        Console.Write("Digite o email: ");
        string emailBusca = Console.ReadLine();

        bool encontrado = false;

        foreach (var p in listaPessoa)
        {
            if (p.Email == emailBusca)
            {
                p.ExibirDados();
                p.CalcularBonus();
                encontrado = true;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine("Colaborador não encontrado.");
        }
    }

    else if (opcao == "6")
    {
        Console.Write("Digite o nome ou email: ");
        string busca = Console.ReadLine();

        foreach (var p in listaPessoa)
        {
            if (p.Nome == busca || p.Email == busca)
            {
                listaPessoa.Remove(p);
                Console.WriteLine("Colaborador removido");
                break;
            }
        }
    }

    else if (opcao == "7")
    {
        Console.WriteLine("Saindo...");
        resposta = "n";
    }

    else 
    {
        Console.WriteLine("Opção Invalida.");
    }
}

