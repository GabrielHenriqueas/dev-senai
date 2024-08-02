// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.

using CelularPOO;

Celular act = new Celular();

String opcao;

do
{
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(@$"

=========================================
Seja bem-
Selecione uma das seguingtes opções:

[1] - LIGAR
[2] - DESLIGAR
[3] - FAZER LIGAÇÃO
[4] - ENVIAR MENSAGEM
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
        Console.Clear();
        if(act.ligado)
        {
            Console.WriteLine($"Seu aparelho celular já está ligado campeão!");
        }

        else
        {
        act.Ligar();
        }

        break;
    }

    case "2":
    {
        Console.Clear();
        if(act.ligado == false)
        {
            Console.WriteLine($"Seu aparelho celular já está desligado campeão!");
        }

        else
        {
        act.Desligar();
        }
        break;
    }

    case "3":
    {
        Console.Clear();
        if(act.ligado)
        {
        act.FazerLigacao();
        }
        else
        {
            Console.WriteLine($"Seu aparelho celular está desligado campeão!");
        }
        break;
    }

    case "4":
    {
        Console.Clear();
        if(act.ligado)
        {
        act.EnviarMensagem();
        }
        else
        {
            Console.WriteLine($"Seu aparelho celular está desligado campeão!");
        }
        break;
    }

    default:
        Console.Clear();
        Console.WriteLine($"Entrada inválida. Tente novamente");
        break;
}
} while (opcao != "0");