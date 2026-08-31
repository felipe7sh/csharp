namespace SistemaCadastroColaboradores
{
    public class Secretario : Funcionario
    {
        public string Setor;
        public int Ramal;
        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Setor: {Setor}");
            Console.WriteLine($"Ramal: {Ramal}");
        }
    }
}