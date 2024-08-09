//Crie um programa que calcule a soma dos números pares de um vetor de 10 elementos. Utilize um laço for para percorrer o vetor e uma estrutura condicional if para identificar os números pares.

Console.Clear();

int[] numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

int soma = 0;

foreach (int numero in numeros)
{
    if (numero % 2 == 0)
    {
        soma+=numero;
    }
}

Console.WriteLine(soma);