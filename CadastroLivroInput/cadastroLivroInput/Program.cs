class Livro
{
    public string nome, autor, genero;
    public void Exibirlivro()
    {
        Console.WriteLine($"Nome: {nome}, Autor: {autor}, Genero: {genero}");
    }
}


class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine($"===== Sistema De Cadastro de Livro ======");
        Console.WriteLine("Bem Vindo ao Sistema de cadastro de livros!");
        Console.Write("Deseja cadastrar um livro? S ou N: ");

        List<Livro> listaLivros = new List<Livro>();

        string resposta = Console.ReadLine(); 
        while (resposta.ToLower() == "s" ) {

            Livro novolivro = new Livro();
            Console.Write("Ensira o Nome do Livro: ");
            novolivro.nome = Console.ReadLine();

            Console.Write("Ensira o Autor do Livro: ");
            novolivro.autor = Console.ReadLine();

            Console.Write("Ensira o Genero do Livro: ");
            novolivro.genero = Console.ReadLine();
            novolivro.Exibirlivro();

            listaLivros.Add(novolivro);
            Console.Write("Deseja continuar a cadastrar? S ou N : ");
            string rp = Console.ReadLine();

            if (rp.ToLower() == "s")
            {
                continue;
            } else
            {
                break;
            }
        }

        Console.WriteLine("\n\n ===== LISTA DE LIVROS ==== \n\n");
        if (listaLivros.Count > 0) {
            foreach (Livro livroAtual in listaLivros) {
                livroAtual.Exibirlivro();
            }
        } else { 
            Console.WriteLine("Nenhum livro cadastrado");
        }

        Console.WriteLine("FIM DA APLICAÇAO");
    }
}

