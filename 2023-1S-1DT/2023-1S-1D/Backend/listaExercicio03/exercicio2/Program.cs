﻿// 2. Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.

Console.WriteLine($"Informe o nome do usúario: ");
string nome = Console.ReadLine()!;

Console.WriteLine($"Informe a senha do usúario: ");
string senha = Console.ReadLine()!;

while(nome == senha)
{
    Console.WriteLine($"Senha inválida. Informe a senha do usúario novamente: ");
    senha = Console.ReadLine()!;
}
