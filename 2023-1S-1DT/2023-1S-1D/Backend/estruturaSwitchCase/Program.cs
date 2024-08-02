Console.WriteLine($"Informe o número correspondente ao dia da semana: ");
int diaSemana = int.Parse(Console.ReadLine());

switch (diaSemana)
{
    case 1:
        Console.WriteLine($"Domingo!");
        break;

    case 2:
        Console.WriteLine($"Segunda-feira");
        break;

    case 3:
        Console.WriteLine($"Terça-feira");
        break;

    case 4:
        Console.WriteLine($"Quarta-feira");
        break;

    case 5:
        Console.WriteLine($"Quinta-feira");
        break;

    case 6:
        Console.WriteLine($"Sexta-feira");
        break;

    case 7:
        Console.WriteLine($"Sábado");
        break;

    default:
        Console.WriteLine($"O dia informado não corresponde com nenhum dia da semana!");
        break;
}