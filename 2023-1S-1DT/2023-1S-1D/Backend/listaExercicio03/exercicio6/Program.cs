// Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.

int num = 1;

for (int cont = 1; cont <= 10; cont++)
{
    Console.WriteLine($"\r\nTabuada do {num}! r\n\");
    
    for (int cont2 = 1; cont2 <= 10; cont2++)
    {
        Console.WriteLine($"{num} x {cont2} = {num * cont2}");
    }
    num++;
}