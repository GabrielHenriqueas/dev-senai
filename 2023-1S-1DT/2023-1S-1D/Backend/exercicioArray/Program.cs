//Criar um programa em c# que receba 5 números inteiros e ao final exiba o seu dobro.
//Você deve utilizar a estrutura array com tamanho 5 para o armazenamento dos números, a estrututa for para a leitura dos números e a estrutura foreach para exibí-los.

int[]numeros = new int[5];

for(int cont = 0 ; cont <= 4 ; cont++)
{
    Console.WriteLine($"Digite o {cont + 1}º número: ");
    numeros[cont] = int.Parse(Console.ReadLine()!);
}

foreach (int cont in numeros)
{
    Console.WriteLine($"O numero escolhido foi {cont} e o dobro é {cont * 2}");
}