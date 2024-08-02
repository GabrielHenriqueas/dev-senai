// 4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o menor valor lido.


    float [] numeros = new float [10];

    for (int i = 0; i < 10; i++ )
    {

        Console.WriteLine($"Insira um numero:");
        numeros[i]= float.Parse(Console.ReadLine()!);
        
    

    }
    
    Console.WriteLine($@"
    Numeros inseridos {numeros.Length}
    Maior numero: {numeros.Max()}
    Menor numero: {numeros.Min()}
    ");