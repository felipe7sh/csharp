using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaCadastroColaboradores
{
    public class Funcionario
    {
        public string Nome, Email, Salario, Telefone, CPF;

        public virtual void ExibirDados()
        {
            Console.WriteLine($"\nNome: {Nome}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Salario: {Salario}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"CPF: {CPF}");
        }
    }
}