// fazer using para apontar arquivos do projeto
using LojaPet;

Console.WriteLine("=== SISTEMA DE LOJA PET ===");

Animal MeuPet01 = new Animal();
MeuPet01.Nome = "Bidu";
MeuPet01.Especie = "Cachorro";
MeuPet01.Peso = 10.3;
MeuPet01.Tutor = "Joao";

Animal MeuPet02 = new Animal();
MeuPet02.Nome = "Garfield";
MeuPet02.Especie = "Gato";
MeuPet02.Peso = 5.5;
MeuPet02.Tutor = "Felipe";

Animal MeuPet03 = new Animal();
MeuPet03.Nome = "Kuzco";
MeuPet03.Especie = "Lhama";
MeuPet03.Peso = 103.8;
MeuPet03.Tutor = "Daniel";

MeuPet01.ExibitPet();
MeuPet02.ExibitPet();
MeuPet03.ExibitPet();

Console.WriteLine("\n\n=== Fim da Aplicação ===");