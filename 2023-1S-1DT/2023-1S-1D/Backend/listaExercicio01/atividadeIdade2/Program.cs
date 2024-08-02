Console.Write("Informe o ano de seu nascimento: ");
    int anoNascimento = int.Parse(Console.ReadLine()!);
    int idade = DateTime.Now.Year - anoNascimento;
    int semanas = idade * 52;

    Console.WriteLine($"Sua idade é: {idade} anos");
    Console.WriteLine($"Sua idade em semanas é: {semanas}");
