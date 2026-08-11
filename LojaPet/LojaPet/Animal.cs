using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LojaPet
{
    // tornar a classe publica (public)
    public class Animal
    {
        public string Nome;
        public string Especie;
        public double Peso;
        public string Tutor;

        public void ExibitPet()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Especie: {Especie} ");
            Console.WriteLine($"Peso: {Peso}");
            Console.WriteLine($"Tutor: {Tutor}\n");
        }
    }
}
