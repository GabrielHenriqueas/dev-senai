// Escreva um programa que pergunte o raio de uma circunferência, e em seguida mostre o diâmetro, comprimento e área da circunferência.

Console.WriteLine($"Digite o raio da circunferência desejada: ");
double raio = int.Parse(Console.ReadLine()!);

double diametro = raio * 2;
double comprimento = 3.14 * diametro;
double area = 3.14 * (raio * raio);


Console.WriteLine(@$"
O diâmetro da circunferência é de:{diametro}
O comprimento da circunferência é de:{comprimento}
O área da circunferência é de:{area}");
