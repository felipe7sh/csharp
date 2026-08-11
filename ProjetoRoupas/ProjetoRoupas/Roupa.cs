using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoRoupas
{
    public class Roupa
    {
        public string Descricao, Tamanho;
        public double Preco;

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Peça: {Descricao} - Tamanho: {Tamanho}");
            Console.WriteLine($"Preço: R$ {Preco:F2}");
        }
    }
}
