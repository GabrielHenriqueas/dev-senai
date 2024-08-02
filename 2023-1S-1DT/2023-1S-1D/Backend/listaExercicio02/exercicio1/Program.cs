// Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.

Console.WriteLine($"Informe o dia de nascimento do usúario: ");
int dia = int.Parse(Console.ReadLine()!);

while(dia <= 0 || dia >= 32)
{
    Console.WriteLine($"Dia inválido. Informe o dia de nascimento do usúario novamente: ");
    dia = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Informe o mês de nascimento do usúario: ");
int mes = int.Parse(Console.ReadLine()!);

while(mes <= 0 || mes >= 13)
{
    Console.WriteLine($"Mês inválido. Informe o mês de nascimento do usúario novamente: ");
    mes = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Informe o ano de nascimento do usúario: ");
int ano = int.Parse(Console.ReadLine()!);

while(ano > 2013)
{
    Console.WriteLine($"Ano inválido. Informe o ano de nascimento do usúario novamente: ");
    ano = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Data válida. O ano de nascimento do usúario é: {dia}/{mes}/{ano}.");


