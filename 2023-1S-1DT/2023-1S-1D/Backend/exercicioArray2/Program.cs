//exercício de fixação

//escreva um programa que receba e imprima o nome e idade de 5 pessoas

//personalizar cores: a resposta do nome em azul e a resposta da idade em verde (cor da font)

string[]nomes = new string[5];
int[]idades = new int[5];

for(int cont = 0 ; cont <= 4 ; cont++)
{
    Console.WriteLine($"Digite o nome da {cont + 1}º pessoa: ");
    nomes[cont] = Console.ReadLine()!;

    Console.WriteLine($"Digite a idade da {cont + 1}º pessoa: ");
    idades[cont] = int.Parse(Console.ReadLine()!);
}


for(int cont = 0 ; cont <= 4 ; cont++)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{cont + 1}) nome: {nomes[cont]} ");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"idade: {idades[cont]} \r\n");
    Console.ResetColor();
}
