//faça um método para calcular imposto sobre a renda

//regras de negócio
//tabela de imposto vs renda
//até $1500 - isento
//de $1501 até $3500 - 20% de imposto
//de $3501 até $6000 - 25% de imposto
//acima de $6000 - 35% de imposto


//receber o renda via console
//chamar o método passando a renda como parâmetro
//exibir o valor do imposto referente á renda

static float LeaoFaminto(float imposto)
{
    if(imposto <= 1500)
    {
        return 0.00f;
    }

    else if(imposto > 1500 && imposto <= 3500)
    {
        return imposto * 0.20f;
    }

    else if(imposto > 3500 && imposto <= 6000)
    {
        return imposto * 0.25f;
    }

    else
    {
        return imposto * 0.25f;
    }
}

Console.WriteLine($"Qual é o valor da sua renda? ");
float imposto = float.Parse(Console.ReadLine()!);

Console.WriteLine($"O valor do seu imposto é: R${LeaoFaminto(imposto)}");