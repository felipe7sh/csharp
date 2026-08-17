using System;
using System.Collections.Generic;
using System.Text;

namespace ProjAlimentos
{
    public class Alimentos
    {
        public string Nome, Categoria, Peso, Validade, Marca;
        public double Preco;

        public void ExibirAlimentos()
        {
            Console.WriteLine($"\nNome: {Nome}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Categoria: {Categoria}"); 
            Console.WriteLine($"Peso: {Peso}");
            Console.WriteLine($"Validade: {Validade}");
            Console.WriteLine($"Preço: R$ {Preco:F2}");
        }
    }
}