class Aluno
{
    public string nome;
    public double nota;
    public void exibirdados()
    {
        Console.WriteLine($"Aluno {nome}, Nota {nota}");
    }
}


class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine($"===== Sistema De Cadastro de Alunos ======");

        Aluno a1 = new Aluno();
        a1.nome = "Murilo";
        a1.nota = 8.5;
        a1.exibirdados();

        Aluno a2 = new Aluno();
        a2.nome = "fernando";
        a2.nota = 9.0;
        a2.exibirdados();

        Aluno a3 = new Aluno();
        a3.nome = "maria";
        a3.nota = 9.5;
        a3.exibirdados();
    }
}

