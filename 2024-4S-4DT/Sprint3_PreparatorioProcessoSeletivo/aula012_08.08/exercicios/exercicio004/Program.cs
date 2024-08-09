//Crie uma função que recebe um número como parâmetro e retorna a tabuada desse número até o número 10. Utilize um laço for para gerar os múltiplos do número.

Console.Clear();

void Tabuada (int num) {
    for (int i = 0; i <= 10; i++)
    {
        Console.WriteLine($"{num} x {i} = {num * i} ");
    }
}

Tabuada(2);