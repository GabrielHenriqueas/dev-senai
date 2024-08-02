// Instanciar um objeto da classe Personagem

using Introdução_POO;

Personagem person1 = new Personagem();

Console.WriteLine($"Informe o nome do Personagem :");
person1.nome = Console.ReadLine()!;
Console.WriteLine($"Informe a idade do Personagem :");
person1.idade = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe a armadura do Personagem :");
person1.armadura = Console.ReadLine()!;
Console.WriteLine($"Informe a IA do Personagem :");
person1.ia = Console.ReadLine()!;




Console.WriteLine(@$"
{person1.nome}
{person1.idade}
{person1.armadura}
{person1.ia}
");

person1.Atacar();
person1.Defender();
person1.RestaurarArmadura();