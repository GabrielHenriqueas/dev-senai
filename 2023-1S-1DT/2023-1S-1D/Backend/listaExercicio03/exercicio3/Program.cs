// 3. Faça um programa que receba um número inteiro e mostre a sua tabuada.

Console.WriteLine($"Digite um número para saber sua respectiva tabuada: ");
int num = int.Parse(Console.ReadLine()!);

while(num < 0)
{
    Console.WriteLine($"Valor inválido. Digite um número para saber sua respectiva tabuada novamente: ");
    num = int.Parse(Console.ReadLine()!);
}

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{num} x {i} = {num * i}");
}

// Console.WriteLine(@$"
//     {num} X 0 = {num * 0}
//     {num} X 1 = {num * 1}
//     {num} X 2 = {num * 2}
//     {num} X 3 = {num * 3}
//     {num} X 4 = {num * 4}
//     {num} X 5 = {num * 5}
//     {num} X 6 = {num * 6}
//     {num} X 7 = {num * 7}
//     {num} X 8 = {num * 8}
//     {num} X 9 = {num * 9}
//     {num} X 10 = {num * 10}
// ")
