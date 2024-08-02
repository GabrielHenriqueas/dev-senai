//Coca cola
//Pepsi
//Fanta
//Monster

//crie um menu de opções e peça para o usuário escolher uma das opções
//a depender da opção, exiba uma mensagem se gostaria de acrescentar gelo
//se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo
//caso contrário, a bebida é sem gelo adicional


Console.WriteLine(@$"

BEM-VINDO AO BAR DO SEU ZÉ!
Escolha sua bebida!
Cardapio abaixo:


-------------------------------------
|      Programa de calculadora      |   
|                                   | 
|   Informe o tipo de Bebida        |
|                                   |
|    (1) Pepsi Black                |
|    (2) Coca-Cola                  |
|    (3) Fanta Maracuja             |
|    (4) Corote Azul                |
|    (5) Suco de uva                |
|    (6) Cha Mate                   |
|    (7) Combo de Jack Daniels`s    |
|    (8) Combo de Cockland          |
|    (9) Combo de Gin               |
|                                   |
-------------------------------------
");

Console.WriteLine($"Informe o numero da sua bebida:");
int operacao = int.Parse(Console.ReadLine());
int gelo = 0;
//processamento
//saida

switch (operacao)
{
    case 1:
        Console.WriteLine($"Voce escolheu Pepsi Black");
        Console.WriteLine(@$"Gostaria de adicionar gelo?
        1- Com gelo
        2- Sem gelo");
        gelo = int.Parse(Console.ReadLine()!);

        switch (gelo)
        {
            case 1:
                Console.WriteLine($"Você escolheu uma Pepsi Black com gelo.");
                break;

            case 2:
                Console.WriteLine($"Você escolheu uma Pepsi Black sem gelo.");
                break;

            default:
                Console.WriteLine($"Escolha inválida.");
                break;
        }
        break;

    case 2:
        Console.WriteLine($"Voce escolheu Coca-Cola");
        Console.WriteLine(@$"Gostaria de adicionar gelo?
        1- Com gelo
        2- Sem gelo");
        gelo = int.Parse(Console.ReadLine()!);
        switch (gelo)
        {
            case 1:
                Console.WriteLine($"Você escolheu uma Coca-cola com gelo.");
                break;
                
            case 2:
                Console.WriteLine($"Você escolheu uma Coca-cola sem gelo.");
                break;

            default:
                Console.WriteLine($"Escolha inválida.");
                break;
        }
        break;

    case 3:
        Console.WriteLine($"Voce escolheu Fanta Maracuja");
        Console.WriteLine(@$"Gostaria de adicionar gelo?
        1- Com gelo
        2- Sem gelo");
        gelo = int.Parse(Console.ReadLine()!);
        switch (gelo)
        {
            case 1:
                Console.WriteLine($"Você escolheu uma Fanta Maracuja com gelo.");
                break;

            case 2:
                Console.WriteLine($"Você escolheu uma Fanta Maracuja sem gelo.");
                break;

            default:
                Console.WriteLine($"Escolha inválida.");
                break;
        }
        break;

    case 4:
        Console.WriteLine($"Voce escolheu Corote Azul");
        Console.WriteLine(@$"Gostaria de adicionar gelo?
        1- Com gelo
        2- Sem gelo");
        gelo = int.Parse(Console.ReadLine()!);
        switch (gelo)
        {
            case 1:
                Console.WriteLine($"Você escolheu uma Corote Azul com gelo.");
                break;

            case 2:
                Console.WriteLine($"Você escolheu uma Corote Azul sem gelo.");
                break;

            default:
                Console.WriteLine($"Escolha inválida.");
                break;
        }
        break;

    case 5:
        Console.WriteLine($"Voce escolheu Suco de uva");
        Console.WriteLine(@$"Gostaria de adicionar gelo?
        1- Com gelo
        2- Sem gelo");
        gelo = int.Parse(Console.ReadLine()!);
        switch (gelo)
        {
            case 1:
                Console.WriteLine($"Você escolheu uma Suco de uva com gelo.");
                break;

            case 2:
                Console.WriteLine($"Você escolheu uma Suco de uva sem gelo.");
                break;

            default:
                Console.WriteLine($"Escolha inválida.");
                break;
        }
        break;

    case 6:
        Console.WriteLine($"Voce escolheu Cha Mate");
        Console.WriteLine(@$"Gostaria de adicionar gelo?
        1- Com gelo
        2- Sem gelo");
        gelo = int.Parse(Console.ReadLine()!);
        switch (gelo)
        {
            case 1:
                Console.WriteLine($"Você escolheu uma Cha Mate com gelo.");
                break;

            case 2:
                Console.WriteLine($"Você escolheu uma Cha Mate sem gelo.");
                break;

            default:
                Console.WriteLine($"Escolha inválida.");
                break;
        }
        break;

    case 7:
        Console.WriteLine($"Voce escolheu Combo de Jack Daniels`s");
        Console.WriteLine(@$"Gostaria de adicionar gelo?
        1- Com gelo
        2- Sem gelo");
        gelo = int.Parse(Console.ReadLine()!);
        switch (gelo)
        {
            case 1:
                Console.WriteLine($"Você escolheu uma Combo de Jack Daniels`s com gelo.");
                break;

            case 2:
                Console.WriteLine($"Você escolheu uma Combo de Jack Daniels`s sem gelo.");
                break;

            default:
                Console.WriteLine($"Escolha inválida.");
                break;
        }
        break;

    case 8:
        Console.WriteLine($"Voce escolheu Combo de Cockland");
        Console.WriteLine(@$"Gostaria de adicionar gelo?
        1- Com gelo
        2- Sem gelo");
        gelo = int.Parse(Console.ReadLine()!);
        switch (gelo)
        {
            case 1:
                Console.WriteLine($"Você escolheu uma Combo de Cockland com gelo.");
                break;

            case 2:
                Console.WriteLine($"Você escolheu uma Combo de Cockland sem gelo.");
                break;

            default:
                Console.WriteLine($"Escolha inválida.");
                break;
        }
        break;

    case 9:
        Console.WriteLine($"Voce escolheu Combo de Gin");
        Console.WriteLine(@$"Gostaria de adicionar gelo?
        1- Com gelo
        2- Sem gelo");
        gelo = int.Parse(Console.ReadLine()!);
        switch (gelo)
        {
            case 1:
                Console.WriteLine($"Você escolheu uma Combo de Gin com gelo.");
                break;

            case 2:
                Console.WriteLine($"Você escolheu uma Combo de Gin sem gelo.");
                break;

            default:
                Console.WriteLine($"Escolha inválida.");
                break;
        }
        break;

    default:
        Console.WriteLine($"Operação inválida, repita o processo!");        
        break;
}