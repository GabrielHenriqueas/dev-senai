// As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.

Console.WriteLine($"Qual e o numero de macas compradas? ");
int macaCompradas = int.Parse(Console.ReadLine());

if (macaCompradas < 12)
{
    Console.WriteLine($"O valor total da compra e de: R${macaCompradas * 0.30}");
}

else
{
    Console.WriteLine($"O valor total da compra e de: R${macaCompradas * 0.25}");
}