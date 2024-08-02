//5 - Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
//Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.

int numero = 1;

for (int cont = 1; cont <= 10; cont++)
{
Console.ForegroundColor=ConsoleColor.Blue;

Console.WriteLine($"A tabuada do {numero}! ");

Console.ResetColor();
    
for (int contt = 1; contt <= 10; contt++)
{
Console.ForegroundColor=ConsoleColor.Green;

Console.WriteLine($"{numero} x {contt} = {numero * contt}");

Console.ResetColor();
}
numero++;
}