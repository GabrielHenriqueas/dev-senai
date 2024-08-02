// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.

string[] nomeProduto = new string[10];
float[] precoProduto = new float[10];
bool[] promocaoProduto = new bool[10];

string opcao;

static void CadastrarProduto(string[] nomeProduto, float[] precoProduto, bool[] promocaoProduto)
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Qual é o nome do produto que deseja cadastrar?");
        nomeProduto[i] = Console.ReadLine()!;

        Console.WriteLine($"Qual é o preço do produto?");
        precoProduto[i] = float.Parse(Console.ReadLine()!);

        while (precoProduto[i] < 0)
        {
            Console.WriteLine($"Entrada inválida. Qual é o preço do produto?");
            precoProduto[i] = float.Parse(Console.ReadLine()!);
        }

        Console.WriteLine($"O produto está em promoção? S/N");
        string promocao = Console.ReadLine()!.ToUpper();

        while (promocao != "S" && promocao != "N")
        {
            Console.WriteLine($"Entrada inválida. O produto está em promoção? S/N");
            promocao = Console.ReadLine()!.ToUpper();
        }

        if (promocao == "S")
        {
            promocaoProduto[i] = true;
        }

        else
        {
            promocaoProduto[i] = false;
        }


        Console.WriteLine($"Deseja Cadastrar mais algum produto?");
        string opcaoCadastro = Console.ReadLine()!.ToUpper();

        while (opcaoCadastro != "S" && opcaoCadastro != "N")
        {
            Console.WriteLine($"Entrada inválida. Deseja Cadastrar mais algum produto?");
            opcaoCadastro = Console.ReadLine()!.ToUpper();
        }

        if (opcaoCadastro == "N")
        {
            i = 10;
        }

    }
}

static void ListarProduto(string[] nomeProduto, float[] precoProduto, bool[] promocaoProduto)
{
    string promocao;

    for (int i = 0; i < 10; i++)
    {
        if (promocaoProduto[i] == true)
        {
            promocao = "Este produto está em promoção!";
        }

        else
        {
            promocao = "Este produto não está em promoção!";
        }

        Console.WriteLine(@$"

            {i + 1}º PRODUTO:
            Produto: {nomeProduto[i]}
            Preço: {precoProduto[i]}
            {promocao}

        ");

        Console.WriteLine($"Deseja Listar mais algum produto?");
        string opcaoCadastro = Console.ReadLine()!.ToUpper();

        while (opcaoCadastro != "S" && opcaoCadastro != "N")
        {
            Console.WriteLine($"Entrada inválida. Deseja Cadastrar mais algum produto?");
            opcaoCadastro = Console.ReadLine()!.ToUpper();
        }

        if (opcaoCadastro == "N")
        {
            i = 10;
        }
    }
}


do
{

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@$"

=========================================
Seja bem-vindo ao menu de Produtos!
Selecione uma das seguingtes opções:

[1] - Cadastrar Produtos.
[2] - Listar Produtos.
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
                CadastrarProduto(nomeProduto, precoProduto, promocaoProduto);
                break;
            }

        case "2":
            {
                ListarProduto(nomeProduto, precoProduto, promocaoProduto);
                break;
            }

        default:
            Console.WriteLine($"Opção inválida. Tente Novamente");
            Console.Clear();
            break;
    }
} while (opcao != "0");


