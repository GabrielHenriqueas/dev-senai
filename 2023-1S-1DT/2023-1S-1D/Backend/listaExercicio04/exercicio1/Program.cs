//1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

Console.WriteLine($"Informe o ano atual: ");
int ano = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o ano de seu nascimento: ");
int nasc = int.Parse(Console.ReadLine()!);

if (ano - nasc >= 16) {
    Console.WriteLine($"Vocé esta apto a votar!");
    
}

else {
    Console.WriteLine($"Você não possui idade o suficiente para votar.");
    
}