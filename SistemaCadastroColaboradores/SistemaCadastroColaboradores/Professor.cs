namespace SistemaCadastroColaboradores
{
    public class Professor : Funcionario
    {
        public string Disciplina;
        public int HorasAulaSemanal;
        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Disciplina: {Disciplina}");
            Console.WriteLine($"Horas de Aula Semanal: {HorasAulaSemanal}");
        }
    }
}