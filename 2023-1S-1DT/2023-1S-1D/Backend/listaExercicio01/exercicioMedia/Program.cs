// Sabemos que um aluno é aprovado caso apresente média maior ou igual a 7.0 e frequência maior ou igual a 75%. Na verdade, em uma situação real, se o aluno obtiver a frequência mínima exigida e uma média entre 3 e 7, ainda teria direito a uma última avaliação de recuperação. Como faríamos para resolver o problema em questão utilizando apenas estruturas de condição se-então-senão? Poderíamos começar avaliando a frequência do aluno, e se a mesma for menor que 75% o aluno já estaria reprovado, porém caso a frequência respeite o mínimo exigido, começaríamos a avaliar a média para saber se está aprovado, em recuperação ou reprovado.

Console.WriteLine($"Qual e a media do aluno? ");
float media = float.Parse(Console.ReadLine());

Console.WriteLine($"Qual e a frequencia do aluno? ");
float freq = float.Parse(Console.ReadLine());

if (freq < 75)
{
    Console.WriteLine($"Aluno reprovado volte ano que vem KKKKKKKKKK!");
}

else if ((media >= 7) && (freq >= 75))
{
    Console.WriteLine($"APROVADO!");
}

else if ((media >= 3) && (freq >= 75))
{
    Console.WriteLine($"Voce tem direito a recuperacao! Ultima chance burro!");
}

else
{
    Console.WriteLine($"Aluno reprovado volte ano que vem KKKKKKKKKK!");
}