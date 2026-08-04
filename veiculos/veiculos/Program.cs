class Veiculos
{
    public string Fabricante, Marca, Combustível, ano, portas, quilometragem;
    public void ExibirVeiculo()
    {
        Console.WriteLine($"Carro: {Marca}, Fabricante: {Fabricante}, Combustível: {Combustível}, Ano {ano}, Quilometragem {quilometragem}, Portas {portas}");
    }
}


class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine($"===== Sistema De Cadastro de Veiculo ======");
        Console.Write("Deseja cadastrar um veiculo? S ou N: ");

        List<Veiculos> listaVeiculos = new List<Veiculos>();

        string resposta = Console.ReadLine();
        while (resposta.ToLower() == "s") {
            Veiculos novoVeiculo = new Veiculos();
            Console.Write("Ensira o Marca do Veiculo: ");
            novoVeiculo.Marca = Console.ReadLine();

            Console.Write("Ensira o Fabricante do Veiculo: ");
            novoVeiculo.Fabricante = Console.ReadLine();

            Console.Write("Ensira o Combustivel do Veiculo: ");
            novoVeiculo.Combustível = Console.ReadLine();

            Console.Write("Ensira o Ano do Veiculo: ");
            novoVeiculo.ano = Console.ReadLine();

            Console.Write("Ensira o Quilometragem do Veiculo: ");
            novoVeiculo.quilometragem = Console.ReadLine();

            Console.Write("Ensira quantas portas o Veiculo tem: ");
            novoVeiculo.portas = Console.ReadLine();

            novoVeiculo.ExibirVeiculo();

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
            foreach (Veiculos livroAtual in listaVeiculos)
            {
                livroAtual.ExibirVeiculo();
            }
        }
        else
        {
            Console.WriteLine("Nenhum veiculo cadastrado");
        }

        Console.WriteLine("FIM DA APLICAÇAO");
    }
}

