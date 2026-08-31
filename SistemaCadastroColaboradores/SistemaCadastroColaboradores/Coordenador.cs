namespace SistemaCadastroColaboradores
{
    public class Coordenador : Funcionario
    {
        public string CursoSupervisionado;
        public int ProfessoresSupervisionados;
        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Curso Supervisionado: {CursoSupervisionado}");
            Console.WriteLine($"Professores Supervisionados: {ProfessoresSupervisionados}");
        }

        public override void CalcularBonus()
        {
            Console.WriteLine($"Bonus: {Salario * 0.15}");
        }
    }
}