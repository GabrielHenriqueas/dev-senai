Console.Write("Informe sua idade em anos: ");
int idade = int.Parse(Console.ReadLine()!);

int meses = idade * 12;
int dias = idade * 365;
int horas = dias * 24;
int minutos = horas * 60;

Console.WriteLine($"Sua idade em meses é: {meses}");
Console.WriteLine($"Sua idade em dias é: {dias}");
Console.WriteLine($"Sua idade em horas é: {horas}");
Console.WriteLine($"Sua idade em minutos é: {minutos}");