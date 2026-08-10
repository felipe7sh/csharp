class Veiculo
{
    public string Marca, Modelo, Combustivel, Cor, Placa, Cilindrada;
    public int Ano, Portas, Cv;
    public double Quilometragem;
    public void ExibirVeiculo()
    {
        Console.WriteLine($"Marca: {Marca}\nModelo: {Modelo}\nCombustível: {Combustivel}\nCor: {Cor}\nPlaca: {Placa}\nAno: {Ano}\nQuilometragem: {Quilometragem} km\nPortas: {Portas}\nCilindrada: {Cilindrada}L\nPotência: {Cv} CV");
    }
}

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine($"===== Sistema De Cadastro de Veiculo ======");
        Console.Write("\nDeseja cadastrar um veiculo? S ou N: \n");

        List<Veiculo> listaVeiculos = new List<Veiculo>();

        string resposta = Console.ReadLine();
        while (resposta.ToLower() == "s")
        {
            Veiculo novoVeiculo = new Veiculo();
            Console.Write("Insira o Marca do Veiculo: ");
            novoVeiculo.Marca = Console.ReadLine();

            Console.Write("Insira o Modelo do Veiculo: ");
            novoVeiculo.Modelo = Console.ReadLine();

            Console.Write("Insira o Combustivel do Veiculo: ");
            novoVeiculo.Combustivel = Console.ReadLine();

            Console.Write("Insira o Cor do Veiculo: ");
            novoVeiculo.Cor = Console.ReadLine();

            Console.Write("Insira a Placa do Veiculo: ");
            novoVeiculo.Placa = Console.ReadLine();

            Console.Write("Insira o Ano do Veiculo: ");
            novoVeiculo.Ano = int.Parse(Console.ReadLine());

            Console.Write("Insira o Quilometragem do Veiculo: ");
            novoVeiculo.Quilometragem = double.Parse(Console.ReadLine());

            Console.Write("Insira quantas portas o Veiculo tem: ");
            novoVeiculo.Portas = int.Parse(Console.ReadLine());

            Console.Write("Insira a cilindrada do veículo (em litros): ");
            novoVeiculo.Cilindrada = Console.ReadLine();

            Console.Write("Insira a Potencia do veículo: ");
            novoVeiculo.Cv = int.Parse(Console.ReadLine());

            listaVeiculos.Add(novoVeiculo);
            Console.Write("\nDeseja continuar a cadastrar veiculos? S ou N : \n");
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
            foreach (Veiculo veiculoAtual in listaVeiculos)
            {
                veiculoAtual.ExibirVeiculo();
            }
        }
        else
        {
            Console.WriteLine("Nenhum veiculo cadastrado");
        }

        Console.WriteLine("\nFIM DA APLICAÇAO");
    }
}