using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaCadastroColaboradores
{
    public class Funcionario
    {
        public string Nome, Email;
        public double Salario;
        public virtual void ExibirDados()
        {
            Console.WriteLine($"\nNome: {Nome}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Salario: {Salario}");
        }

        public virtual void CalcularBonus()
        {
            Console.WriteLine($"Bonus: {Salario * 0.10}");
        }
    }
}