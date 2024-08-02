// Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.

Console.WriteLine($"Informe os gols do Vasco: ");
int vasco = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe os gols do Agua Santa: ");
int aguaSanta = int.Parse(Console.ReadLine());

if( vasco > aguaSanta)
{
    Console.WriteLine($"Vitoria do Vasco placar de {vasco} x {aguaSanta}");
}

else if( vasco < aguaSanta)
{
    Console.WriteLine($"Vitoria do Agua Santa placar de {aguaSanta} x {vasco}");
}

else
{
    Console.WriteLine($"EMPATE! Jogo vergonhoso demais");
}
