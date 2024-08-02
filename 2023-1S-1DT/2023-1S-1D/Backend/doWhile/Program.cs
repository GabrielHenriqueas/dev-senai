//Olá professoar Carlão, eu utilizei While e doWhile, o While está comentado, para utiliza-lo, desfaça o comentario e comente o doWhile e veja a mágia acontecer, grato! abraços!

// Console.WriteLine($"Digite o nome do usúario? ");
// string nome = Console.ReadLine()!;

// while (nome == "")
// {
//     Console.WriteLine($"Digite o nome do usúario novamente ");
//     nome = Console.ReadLine()!;
// }

// Console.WriteLine($"O nome do úsuario é: {nome}");


// Console.WriteLine($"Digite a idade do usúario? ");
// int idade = int.Parse(Console.ReadLine()!);

// while (idade < 0 || idade > 100)
// {
//     Console.WriteLine($"Digite a idade do usúario novamente ");
//     idade = int.Parse(Console.ReadLine()!);
// }

// Console.WriteLine($"A idade do úsuario é: {idade}");


// Console.WriteLine($"Digite o salario do usúario? ");
// float salario = float.Parse(Console.ReadLine()!);

// while (salario <= 0)
// {
//     Console.WriteLine($"Digite o salario do usúario novamente ");
//     salario = float.Parse(Console.ReadLine()!);
// }

// Console.WriteLine($"O salario do úsuario é: {salario}");


// Console.WriteLine($"Digite o estado civil do usúario? ");
// char estadoCivil = char.Parse(Console.ReadLine()!);

// while (estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd')
// {
//     Console.WriteLine($"Digite o estado civil do usúario novamente ");
//     estadoCivil = char.Parse(Console.ReadLine()!.ToLower());
// }

// Console.WriteLine($"O estado civil do úsuario é: {estadoCivil}");


bool nomeCerto = true;

do
{
    Console.WriteLine($"Qual é o nome do usúario? ");
    string nome = Console.ReadLine()!;
    
    if (nome == "")
    {
        nomeCerto = false;
    }
    else
    {
        nomeCerto = true;
    }

}while(nomeCerto == false);

bool idadeCerta = true;

do
{
    Console.WriteLine($"Qual é a idade do usúario? ");
    int idade = int.Parse(Console.ReadLine()!);
    
    if (idade < 0 || idade > 100)
    {
        idadeCerta = false;
    }
    else
    {
        idadeCerta = true;
    }

}while(idadeCerta == false);

bool salarioCerto = true;

do
{
    Console.WriteLine($"Qual é o salario do usúario? ");
    float salario = float.Parse(Console.ReadLine()!);
    
    if (salario <= 0)
    {
        salarioCerto = false;
    }
    else
    {
        salarioCerto = true;
    }

}while(salarioCerto == false);

bool estadoCivilCerto = true;

do
{
    Console.WriteLine($"Qual é o estado civil do usúario? ");
    char estadoCivil = char.Parse(Console.ReadLine()!);
    
    if (estadoCivil != 's' && estadoCivil != 'c'&& estadoCivil != 'v' && estadoCivil != 'd')
    {
        estadoCivilCerto = false;
    }
    else
    {
        estadoCivilCerto = true;
    }

}while(estadoCivilCerto == false);
