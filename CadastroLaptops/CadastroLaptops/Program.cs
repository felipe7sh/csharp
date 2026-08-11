// fazer using para apontar arquivos do projeto
using CadastroLaptops;

Console.WriteLine("=== SISTEMA DE CADASTRO LAPTOPS ===");

Laptop Laptop1 = new Laptop();
Laptop1.Marca = "Acer";
Laptop1.Fabricante = "Acer";
Laptop1.Modelo = "Nitro 5";
Laptop1.Processador = "Intel Core i5-9300H";
Laptop1.MemoriaRam = 16;
Laptop1.PlacaVideo = "RTX 2060";
Laptop1.Hdd = false;
Laptop1.Sdd = true;
Laptop1.Armazenamento = 512;
Laptop1.Resolucao = "1920x1080";
Laptop1.Bluetooth = true;

Laptop Laptop2 = new Laptop();
Laptop2.Marca = "Dell";
Laptop2.Fabricante = "Dell";
Laptop2.Modelo = "G15";
Laptop2.Processador = "Intel Core i5-10200H";
Laptop2.MemoriaRam = 16;
Laptop2.PlacaVideo = "RTX 3050";
Laptop2.Hdd = false;
Laptop2.Sdd = true;
Laptop2.Armazenamento = 512;
Laptop2.Resolucao = "1920x1080";
Laptop2.Bluetooth = true;

Laptop Laptop3 = new Laptop();
Laptop3.Marca = "Lenovo";
Laptop3.Fabricante = "Lenovo";
Laptop3.Modelo = "Legion 5";
Laptop3.Processador = "AMD Ryzen 7 5800H";
Laptop3.MemoriaRam = 32;
Laptop3.PlacaVideo = "RTX 3060";
Laptop3.Hdd = false;
Laptop3.Sdd = true;
Laptop3.Armazenamento = 1000;
Laptop3.Resolucao = "1920x1080";
Laptop3.Bluetooth = true;

Laptop Laptop4 = new Laptop();
Laptop4.Marca = "ASUS";
Laptop4.Fabricante = "ASUS";
Laptop4.Modelo = "TUF Gaming F15";
Laptop4.Processador = "Intel Core i7-12700H";
Laptop4.MemoriaRam = 16;
Laptop4.PlacaVideo = "RTX 4060";
Laptop4.Hdd = false;
Laptop4.Sdd = true;
Laptop4.Armazenamento = 512;
Laptop4.Resolucao = "1920x1080";
Laptop4.Bluetooth = true;

Laptop Laptop5 = new Laptop();
Laptop5.Marca = "HP";
Laptop5.Fabricante = "HP";
Laptop5.Modelo = "Victus 15";
Laptop5.Processador = "AMD Ryzen 5 5600H";
Laptop5.MemoriaRam = 16;
Laptop5.PlacaVideo = "RTX 3050";
Laptop5.Hdd = true;
Laptop5.Sdd = false;
Laptop5.Armazenamento = 1000;
Laptop5.Resolucao = "1920x1080";
Laptop5.Bluetooth = true;


Laptop1.ExibirLaptops();
Laptop2.ExibirLaptops();
Laptop3.ExibirLaptops();
Laptop4.ExibirLaptops();
Laptop5.ExibirLaptops();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\n\n=== Fim da Aplicação ===");
Console.ResetColor();