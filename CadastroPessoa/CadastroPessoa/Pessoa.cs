using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroPessoa
{
    public class Pessoa
    {
        //esta classe é a nossa classe pai
        //tera atributos e metodos genericos

        public string Nome, Endereco, Cidade, Estado, CEP;

        public virtual void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Endereço: {Endereco}, {Cidade} - {Estado}, CEP: {CEP}");
        }
    }
}
