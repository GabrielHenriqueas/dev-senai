// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

string[] nome = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
string[] data = new string[5];

string opcao = "3";

static void Login()
{
Console.WriteLine($"Digite a senha de acesso.");
string senha = Console.ReadLine()!;

while(senha != "chapadinhanagaveta")
{
    Console.WriteLine($"Senha incorreta. Digite a senha de acesso novamente");
    senha = Console.ReadLine()!;
}
}

static void Cadastro(string[]nome, string[]origem, string[]destino, string[]data)
{
for(int i = 0; i <= 4; i++)
{
    Console.WriteLine($"Qual é o nome do passageiro? ");
    nome[i] = Console.ReadLine()!;

    Console.WriteLine($"Qual é a origem da viagem? ");
    origem[i] = Console.ReadLine()!;

    Console.WriteLine($"Qual é o destino da viagem? ");
    destino[i] = Console.ReadLine()!;

    Console.WriteLine($"Qual é a data do voo? ");
    data[i] = Console.ReadLine()!;

    Console.Clear();
    Console.WriteLine($"Deseja continuar o cadastro?");
    string resp = Console.ReadLine()!.ToUpper();

    if(resp == "N")
    {
        i = 5;
    }    
}
}

static void Listar(string[]nome, string[]origem, string[]destino, string[]data)
{
for(int i = 0; i <= 4; i++)
{
    Console.WriteLine(@$"
    {nome[i]}
    {origem[i]}
    {destino[i]}
    {data[i]}
    ");
}
}

Login();

do
{
    
Console.Clear();    
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(@$"

=========================================
Acesso ao Sistema concedido com SUCESSO!
Seja bem-vindo ao menu de viagens!
Selecione uma das seguingtes opções:

[1] - Cadastrar passagens.
[2] - Listar passagens.
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
        Cadastro(nome, origem, destino, data);
        break;
    }

    case "2":
    {
        Listar(nome, origem, destino, data);
        break;
    }

    default:
        break;
}
} while (opcao != "0");

