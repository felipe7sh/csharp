using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroPessoa
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ;
        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Tipo: Pessoa Juridica - CNPJ: {CNPJ} \n");
        }
    }
}
