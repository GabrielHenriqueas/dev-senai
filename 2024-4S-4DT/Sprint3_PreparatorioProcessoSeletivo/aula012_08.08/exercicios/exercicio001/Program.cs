//Escreva um programa que peça ao usuário para digitar um número inteiro e informe se o número é par ou ímpar. Utilize uma estrutura condicional if/else para realizar o teste.

Console.Clear();

Console.WriteLine($"Digite um número inteiro: ");
int num = int.Parse(Console.ReadLine()!);

if (num % 2 == 0)
{
    Console.WriteLine($"O número escolhido é par");
} else {
    Console.WriteLine($"O número escolhido é impar");
}