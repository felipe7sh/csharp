using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroPessoa
{
    public class PessoaFisica : Pessoa
    {
        public string CPF;

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Tipo: Pessoa Fisica - CPF: {CPF} \n");
        }

    }
}
