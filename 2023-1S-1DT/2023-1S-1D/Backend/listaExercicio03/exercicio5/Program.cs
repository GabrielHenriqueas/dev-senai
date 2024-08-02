// 5. Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:   
// A.Total de Homens;      
// B.Total de Mulheres;      
// C.Média de idade dos Homens;      
// D.Média de idade das mulheres.

int homens = 0;
int mulheres = 0;
int idadeHomens = 0;
int idadeMulheres = 0;

for (int cont = 1; cont <= 10; cont++)
{
    Console.WriteLine($"Informe o sexo do usúario: H/M ");
    string sexo = (Console.ReadLine()!.ToUpper());
    
    while (sexo != "H" && sexo != "M")
    {
        Console.WriteLine($"Entrada inválida. Informe o sexo do usúario novamente: H/M");
        sexo = (Console.ReadLine()!.ToUpper());
    }

    Console.WriteLine($"Informe a idade do usúario: ");
    int idade = int.Parse(Console.ReadLine()!);
    while (idade < 0)
    {
        Console.WriteLine($"Entrada inválida. Informe a idade do usúario novamente: ");
        idade = int.Parse(Console.ReadLine()!);
    }

    Console.WriteLine($"Informe o peso do usúario: ");
    int peso = int.Parse(Console.ReadLine()!);
    while(peso < 0)
    {
        Console.WriteLine($"Entrada inválida. Informe o peso do usúario novamente: ");
        peso = int.Parse(Console.ReadLine()!);
    }

    if (sexo == "H")
    {
        homens++;
        idadeHomens += idade;
    }
    else
    {
        mulheres++;
        idadeMulheres += idade;
    }
}

Console.WriteLine($"O total de homens é: {homens}");
Console.WriteLine($"O total de mulheres é: {mulheres}");
if(homens == 0)
{
    Console.WriteLine($"A média de idade dos homens é: 0");
}
else
{
    Console.WriteLine($"A média de idade dos homens é: {idadeHomens/homens}");
}

if(mulheres == 0)
{
    Console.WriteLine($"A média de idade das mulheres é: 0");
}
else
{
    Console.WriteLine($"A média de idade das mulheres é: {idadeMulheres/mulheres}");
}
