//Crie um programa que permita que o usuário cadastre 5 nomes em um vetor. Após o cadastro, o programa deve imprimir na tela os nomes cadastrados em ordem alfabética. Utilize um laço for para o cadastro e um método de ordenação de sua preferência (por exemplo, bubble sort) para ordenar os nomes.

Console.Clear();

string[] nomes = new string [5];

Console.WriteLine($"A seguir digite 5 nomes");

Console.WriteLine($"Digite um nome");
nomes[0] = Console.ReadLine()!;

for (int i = 1; i <= 4; i++)
{
    Console.WriteLine($"Digite mais um nome");
    nomes[i] = Console.ReadLine()!;   
    Console.Clear();
}
Array.Sort(nomes);

foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}