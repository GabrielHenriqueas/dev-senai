// Nesta aula vamos fazer um pequeno sistema de cadastro de alunos, em um projeto de console no VsCode.

// Vamos desenvolver um programa que cadastre e mostre os dados de um aluno.

// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos:

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.

// Acrescente o que achar necessário.

using ProjetoAlunos;

Aluno aluno = new Aluno();

Console.WriteLine($"Qual é o nome do aluno?");
aluno.nome = Console.ReadLine()!;
Console.Clear();

Console.WriteLine($"Qual é o nome do curso?");
aluno.curso = Console.ReadLine()!;
Console.Clear();

Console.WriteLine($"Qual é a idade do aluno?");
aluno.idade = int.Parse(Console.ReadLine()!);
Console.Clear();

Console.WriteLine($"Qual é o RG do aluno?");
aluno.rg = Console.ReadLine()!;
Console.Clear();

Console.WriteLine($"O aluno é bolsista? S/N");
string opBolsista = Console.ReadLine()!.ToUpper();
Console.Clear();

while(opBolsista != "S" && opBolsista != "N")
{
    Console.WriteLine($"Entrada inválida, tente novamente. O aluno é bolsista?");
    opBolsista = Console.ReadLine()!.ToUpper();
    Console.Clear();
}

if(opBolsista == "S")
{
    aluno.bolsista = true;
}

else
{
    aluno.bolsista = false;
}

Console.WriteLine($"Qual é a média final do aluno?");
aluno.mediaFinal = float.Parse(Console.ReadLine()!);
Console.Clear();

Console.WriteLine($"Qual é o valor da mensalidade do aluno?");
aluno.valorMensalidade = float.Parse(Console.ReadLine()!);
Console.Clear();

String opcao;

do
{
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(@$"

=========================================
Seja bem-vindo.
Selecione uma das seguingtes opções:

[1] - VER MÉDIA FINAL DO ALUNO
[2] - VER MENSALIDADE DO ALUNO
[0] - Sair.
==========================================

");
Console.ResetColor();

opcao = Console.ReadLine()!;

switch (opcao)
{
    case "0":  
    {
        break;
    }

    case "1":
    {
        aluno.VerMediaFinal();
        break;
    }

    case "2":
    {
        aluno.VerMensalidade();
        break;
    }

    default:
        Console.Clear();
        Console.WriteLine($"Entrada inválida. Tente novamente");
        break;
}
} while (opcao != "0");
