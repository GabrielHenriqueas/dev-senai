// 5) Você vai criar um programa que armazena as notas de vários alunos em diferentes disciplinas. O programa deve calcular a média de cada aluno e determinar quais alunos têm médias acima de 7.0 (aprovados) e quais têm médias abaixo de 7.0 (reprovados). O programa deve usar foreach para iterar sobre as coleções de alunos e suas notas.

// Especificações:

// - Armazene as notas de 3 disciplinas para cada aluno.
// - Calcule a média de cada aluno.
// - Exiba a média e o status (aprovado/reprovado) de cada aluno.
// - Use foreach para iterar sobre os alunos e as disciplinas.

Console.Clear();

string[] disciplinas = ["Partugues, Matematica, Quimica"];

string[] alunos = ["Marta", "Lucas", "João"];

float[] notas = [10, 7, 8];

foreach (string aluno in alunos)
{
    Console.WriteLine(aluno);
    
    foreach (float nota in notas)
    {
        Console.WriteLine(nota);
        
    }
    
}