// Faça um programa que leia três números e mostre o maior e o menor deles.

Console.WriteLine($"Digite o primeiro número: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o segundo número: ");
int num2 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o terceiro número: ");
int num3 = int.Parse(Console.ReadLine()!);

if(num1 > num2 && num1 > num3)
{
    Console.WriteLine($"O maior número é: {num1}");
}

if(num2 > num1 && num2 > num3)
{
    Console.WriteLine($"O maior número é: {num2}");
}

if(num3 > num1 && num3 > num2)
{
    Console.WriteLine($"O maior número é: {num3}");
}
