namespace SistemaCadastroColaboradores
{
    public class Secretario : Funcionario
    {
        public string Setor, Ramal, Turno;

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Setor: {Setor}");
            Console.WriteLine($"Ramal: {Ramal}");
            Console.WriteLine($"Turno: {Turno}");
        }
    }
}