// 1. Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.

Console.WriteLine($"Digite a nota do usúsario: ");
float nota = float.Parse(Console.ReadLine()!);

while(nota < 0 || nota > 10)
{
    Console.WriteLine($"Entrada inválida. Digite a nota do usúsario novamente: ");
    nota = float.Parse(Console.ReadLine()!);
}

Console.WriteLine($"A nota do usúsario é: {nota}");