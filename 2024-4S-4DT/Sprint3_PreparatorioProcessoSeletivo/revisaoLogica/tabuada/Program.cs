//implementar um programa que solicita ao usuário um número e imprime a tabuada desse número.

Console.Clear();

int num;

Console.WriteLine($"Digite um número: ");
num = int.Parse(Console.ReadLine()!);

Console.WriteLine($"A tabuada escolhida é a do número " + num);

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{i} x {num} = {i * num}");
}