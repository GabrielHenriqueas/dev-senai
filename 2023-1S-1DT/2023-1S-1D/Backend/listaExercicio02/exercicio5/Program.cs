// Faça um programa que verifique se uma letra digitada é vogal ou consoante

Console.WriteLine($"Digite uma letra qualquer: ");
char letra = char.Parse(Console.ReadLine()!.ToUpper());

if(letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
{
    Console.WriteLine($"A letra digitada é uma vogal!");
}
else
{
    Console.WriteLine($"A letra digitada é uma consoante!");
}
