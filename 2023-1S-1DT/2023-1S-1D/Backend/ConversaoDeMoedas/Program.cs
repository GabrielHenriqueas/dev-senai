using ConversaoDeMoedas;


float reais;
float resultadoDollar;
float resultadoEuro;
float resultadoIene;
string opcao;

do
{

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($@"
============================================
Bem-vindo ao Conversor de Moeda!
Escolha a opção que mais atende aos seus desejos!

[1] - Converter Real para Dollar.
[2] - Converter Real para Euro.
[3] - Converter Real para Iene.
[0] - Encerrar sistema.
=============================================
");
    Console.ResetColor();
    opcao = Console.ReadLine()!;

    switch (opcao)
    {
        case "1":
            Console.Clear();
            Console.WriteLine($"Digite o valor em Reais para conversão em Dollars: ");
            reais = float.Parse(Console.ReadLine()!);
            resultadoDollar = Conversao.RealToDollar(reais);
            Console.WriteLine($"{resultadoDollar}");
            break;

        case "2":
            Console.Clear();
            Console.WriteLine($"Digite o valor em Reais para conversão em Euros: ");
            reais = float.Parse(Console.ReadLine()!);
            resultadoEuro = Conversao.RealToEuro(reais);
            Console.WriteLine($"{resultadoEuro}");
            break;

        case "3":
            Console.Clear();
            Console.WriteLine($"Digite o valor em Reais para conversão em Ienes: ");
            reais = float.Parse(Console.ReadLine()!);
            resultadoIene = Conversao.RealToIene(reais);
            Console.WriteLine($"{resultadoIene}");
            break;

        case "0":
            Console.Clear();
            Console.WriteLine($"Encerrando o sistema...");
            break;

        default:
            break;
    }
} while (opcao != "0");
