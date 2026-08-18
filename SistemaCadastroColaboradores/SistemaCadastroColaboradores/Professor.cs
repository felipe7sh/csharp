namespace SistemaCadastroColaboradores
{
    public class Professor : Funcionario
    {
        public string Disciplina, CargaHoraria, Formacao;

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Disciplina: {Disciplina}");
            Console.WriteLine($"Carga Horaria: {CargaHoraria}");
            Console.WriteLine($"Formacao: {Formacao}");
        }
    }
}