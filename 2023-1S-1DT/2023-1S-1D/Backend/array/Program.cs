// //SEM ARRAY

// string carro1;
// string carro2;
// string carro3;

// Console.WriteLine($"Digite o nome do carro: ");
// carro1 = Console.ReadLine()!;

// Console.WriteLine($"Digite o nome do carro: ");
// carro2 = Console.ReadLine()!;

// Console.WriteLine($"Digite o nome do carro: ");
// carro3 = Console.ReadLine()!;

// Console.WriteLine(@$"
// {carro1}
// {carro2}
// {carro3}
// ");

// //SEM ARRAY

// //Criamos uma variável do tipo array de strings co capacidade de armazenar 3 carros
// string[] carros = new string[3];

// Console.WriteLine($"Digite o nome do carro: ");
// carros[0] = Console.ReadLine()!;

// Console.WriteLine($"Digite o nome do carro: ");
// carros[1] = Console.ReadLine()!;

// Console.WriteLine($"Digite o nome do carro: ");
// carros[2] = Console.ReadLine()!;

// Console.WriteLine($"O primeiro carro da lista: {carros[0]}");
// Console.WriteLine($"O segundo carro da lista: {carros[1]}");
// Console.WriteLine($"O terceiro carro da lista: {carros[2]}");

string[]carros = new string[3];
//carros[0] = "Fusca"
//carros[1] = "Gol"
//carros[2] = "Corsa"

for (int i = 0; i < 3; i++)
{
    //bloco de código a ser executado
    Console.WriteLine($"Digite o nome do {i + 1}º carro: ");
    carros[i] = Console.ReadLine()!;
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"O {i + 1}º carro é: {carros[i]}");
}
