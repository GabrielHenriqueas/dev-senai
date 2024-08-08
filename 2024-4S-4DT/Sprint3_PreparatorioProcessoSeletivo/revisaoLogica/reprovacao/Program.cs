//Crie um programa que receba uma nota e mostre para o usuário se ele está aprovado, reprovado ou recuperação

Console.Clear();

int nota;

Console.WriteLine($"Digite sua nota: ");
nota = int.Parse(Console.ReadLine()!);

if (nota >= 7)
{
    Console.WriteLine($"APROVADO!");
    
} else if (nota >= 5)
{
    Console.WriteLine($"RECUPERAÇÃO!");
} else
{
    Console.WriteLine($"REPROVADO!");
}
