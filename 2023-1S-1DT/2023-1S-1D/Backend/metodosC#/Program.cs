//criar método para multiplicar 2 números
//criar método para dividir 2 números
//criar método para subtrair 2 números

Console.WriteLine($"Escolha o 1º número: ");
int n1 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Escolha o 1º número: ");
int n2 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Escolha a opração: ");
char op = char.Parse(Console.ReadLine()!);

while(op != '*' && op != '/' && op != '-' && op != '+')
{
    Console.WriteLine($"Entrada Inválida. Escolha a opração novamente: ");
    op = char.Parse(Console.ReadLine()!);
}

if(op == '*')
{
static int Multiplicacao(int n1, int n2)
{
    int r = n1 * n2;
    return r;
}

int resultadoMult = Multiplicacao(n1, n2);

Console.WriteLine($"Resultado: {resultadoMult}");
}

//////////////////////////////////////////////////////
else if(op == '/')
{
static int Divisao(int n1, int n2)
{
    int r = n1 / n2;
    return r;
}

int resultadoDiv = Divisao(n1, n2);

Console.WriteLine($"Resultado: {resultadoDiv}");
}
//////////////////////////////////////////////////////////////////
else if(op == '-')
{
static int Subtracao(int n1, int n2)
{
    int r = n1 - n2;
    return r;
}

int resultadoSub = Subtracao(n1, n2);

Console.WriteLine($"Resultado: {resultadoSub}");
}
//////////////////////////////////////////////////////////////////
else if(op == '+')
{
static int Adicao(int n1, int n2)
{
    int r = n1 + n2;
    return r;
}

int resultadoSub = Adicao(n1, n2);

Console.WriteLine($"Resultado: {resultadoSub}");
}