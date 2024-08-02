// Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:

// "Telefonou para a vítima?"
// "Esteve no local do crime?"
// "Mora perto da vítima?"
// "Devia para a vítima?"
// "Já trabalhou com a vítima?"

// O programa deve no final emitir uma classificação sobre a participação da pessoa no crime. Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como “Culpado“. Caso contrário, ele será classificado como "Inocente“.

int culpa = 0;

Console.WriteLine($"Telefonou para a vítima? S/N");
string resposta1 = Console.ReadLine()!.ToUpper();
if(resposta1 == "S")
{
    culpa++;
}

Console.WriteLine($"Esteve no local do crime? S/N");
string resposta2 = Console.ReadLine()!.ToUpper();
if(resposta2 == "S")
{
    culpa++;
}

Console.WriteLine($"Mora perto da vítima? S/N");
string resposta3 = Console.ReadLine()!.ToUpper();
if(resposta3 == "S")
{
    culpa++;
}

Console.WriteLine($"Devia para a vítima? S/N");
string resposta4 = Console.ReadLine()!.ToUpper();
if(resposta4 == "S")
{
    culpa++;
}

Console.WriteLine($"Já trabalhou com a vítima? S/N");
string resposta5 = Console.ReadLine()!.ToUpper();
if(resposta5 == "S")
{
    culpa++;
}

if( culpa == 2)
{
    Console.WriteLine($"Pessoa considerada SUSPEITA!"); 
}
else if(culpa == 3 || culpa == 4)
{
    Console.WriteLine($"Pessoa considerada CÚMPLICE!"); 
}
else if(culpa == 5)
{
    Console.WriteLine($"Pessoa considerada CULPADA!"); 
}
else
{
    Console.WriteLine($"Pessoa considerada INOCENTE!"); 
}