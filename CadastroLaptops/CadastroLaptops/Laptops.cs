
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CadastroLaptops
{
    // tornar a classe publica (public)
    public class Laptop
    {
        public string Marca, Fabricante, Modelo, PlacaVideo, Processador, Resolucao;
        public bool Hdd, Sdd, Bluetooth;
        public int MemoriaRam, Armazenamento;

        public void ExibirLaptops()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n----------------------------------\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Fabricante: {Fabricante}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Processador: {Processador}");
            Console.WriteLine($"Memoria Ram: {MemoriaRam} GB");
            Console.WriteLine($"Placa De Video: {PlacaVideo}");
            Console.WriteLine($"Hdd: {Hdd}");
            Console.WriteLine($"Sdd: {Sdd}");
            Console.WriteLine($"Armazenamento: {Armazenamento} GB");
            Console.WriteLine($"Resolução: {Resolucao}");
            Console.WriteLine($"Bluetooth: {Bluetooth}");
            Console.ResetColor();


        }
    }
}
