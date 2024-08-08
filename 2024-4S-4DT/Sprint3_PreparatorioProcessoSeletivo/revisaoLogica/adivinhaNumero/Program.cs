//Crie um programa que gere um número aleatório entre 1 e 100. O usuario deve tentar adivinhar esse número. O programa deve continuar pedindo um palpite até que o usuário acerte o número. Ao final, mostre quantas tentativas foram necessárias.

Console.Clear();

int num;
int i = 0;

Random random = new Random();
int numRandon = random.Next(1, 10);

do
{
    Console.WriteLine($"Digite um número: ");
    num = int.Parse(Console.ReadLine()!);

    i++;

    Console.WriteLine(num < numRandon ? "O número aleatório é maior" : num > numRandon ? "O número aleatório é menor" : "");
    
    
} while (num != numRandon);

Console.WriteLine($"Você acertou, o número certo era {numRandon} e você acertou em {i} tentativas");
