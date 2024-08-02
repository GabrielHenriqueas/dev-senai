//2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

float precoGasolina = 5.30f;
float precoAlcool = 4.90f;
float valorPago = 0;

Console.WriteLine($"Informe qual é o tipo de combiustísvel. Álcool-A ou Gasolina-G:");
char combustivel = char.Parse(Console.ReadLine()!.ToUpper());

while(combustivel != 'A' && combustivel != 'G')
{
    Console.WriteLine($"Entrada inválida. Informe qual é o tipo de combiustísvel novamente. Álcool-A ou Gasolina-G: ");
    combustivel = char.Parse(Console.ReadLine()!.ToUpper());
}

Console.WriteLine($"Informe quantos litros você deseja abastecer: ");
float litros = float.Parse(Console.ReadLine()!);

while(litros <= 0)
{
    Console.WriteLine($"Entrada inválida. Informe quantos litros você deseja abastecer novamente: ");
    litros = int.Parse(Console.ReadLine()!);
}

if(combustivel == 'A' && litros <= 20)
{
    valorPago = (precoAlcool - (precoAlcool * 0.03f)) * litros;
}

else if(combustivel == 'A' && litros > 20)
{
    valorPago = (precoAlcool - (precoAlcool * 0.05f)) * litros;
}

else if(combustivel == 'G' && litros <= 20)
{
    valorPago = (precoGasolina - (precoGasolina * 0.04f)) * litros;
}

else if(combustivel == 'G' && litros > 20)
{
    valorPago = (precoGasolina - (precoGasolina * 0.06f)) * litros;
}

Console.WriteLine($"O valor total a ser pago é de: R${valorPago}");