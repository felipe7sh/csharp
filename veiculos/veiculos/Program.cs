class Veiculo
{
    public string Fabricante, Marca, Combustivel;
    public int Ano, Portas;
    public double Quilometragem;
    public void ExibirVeiculo()
    {
        Console.WriteLine($"Carro: {Marca}, Fabricante: {Fabricante}, Combustível: {Combustivel}, Ano {Ano}, Quilometragem {Quilometragem}, Portas {Portas}");
    }
}


class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine($"===== Sistema De Cadastro de Veiculo ======");
        Console.Write("Deseja cadastrar um veiculo? S ou N: ");

        List<Veiculo> listaVeiculos = new List<Veiculo>();

        string resposta = Console.ReadLine();
        while (resposta.ToLower() == "s") {
            Veiculo novoVeiculo = new Veiculo();
            Console.Write("Insira o Marca do Veiculo: ");
            novoVeiculo.Marca = Console.ReadLine();

            Console.Write("Insira o Fabricante do Veiculo: ");
            novoVeiculo.Fabricante = Console.ReadLine();

            Console.Write("Insira o Combustivel do Veiculo: ");
            novoVeiculo.Combustivel = Console.ReadLine();

            Console.Write("Insira o Ano do Veiculo: ");
            novoVeiculo.Ano = int.Parse(Console.ReadLine());

            Console.Write("Insira o Quilometragem do Veiculo: ");
            novoVeiculo.Quilometragem = double.Parse(Console.ReadLine());

            Console.Write("Insira quantas portas o Veiculo tem: ");
            novoVeiculo.Portas = int.Parse(Console.ReadLine());

            listaVeiculos.Add(novoVeiculo);
            Console.Write("Deseja continuar a cadastrar veiculos? S ou N : ");
            string rp = Console.ReadLine();

            if (rp.ToLower() == "s")
            {
                continue;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("\n\n ===== LISTA DE VEICULOS ==== \n\n");
        if (listaVeiculos.Count > 0)
        {
            foreach (Veiculo veiculoAtual  in listaVeiculos)
            {
                veiculoAtual.ExibirVeiculo();
            }
        }
        else
        {
            Console.WriteLine("Nenhum veiculo cadastrado");
        }

        Console.WriteLine("FIM DA APLICAÇAO");
    }
}

