//DESAFIOS
//Faça um programa que carregue um array de tamanho 6 com números inteiros. Calcule e imprima a quantidade de números ímpares e a quantidade de números pares.

int[]num = new int[6];
int impar = 0;
int par = 0;

for(int cont = 0 ; cont <=5 ; cont++)
{
    Console.WriteLine($"Digite o {cont + 1}º numero: ");
    num[cont] = int.Parse(Console.ReadLine()!);

    if(num[cont]%2 == 0)
    {
        par++;   
    }
    else
    {
        impar++;
    }
}

Console.WriteLine($"A quantidade de números impares é: {impar} e a quantidade de números pares é: {par}");
