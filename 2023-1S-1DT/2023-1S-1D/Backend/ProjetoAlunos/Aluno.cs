using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAlunos
{
    public class Aluno
    {
        public string nome = "";
        public string curso = "";
        public int idade;
        public string rg = "";
        public bool bolsista;
        public float mediaFinal;
        public float valorMensalidade;

        public void VerMediaFinal()
        {
            Console.Clear();
            Console.WriteLine($"A média final do aluno {nome} é de: {mediaFinal}");
        }
        public void VerMensalidade()
        {
            if (bolsista && mediaFinal >= 8)
            {
                Console.Clear();
                Console.WriteLine($"O aluno {nome}, matriculado no curso {curso}, com {idade} anos, Bolsista, com média final de {mediaFinal}, sua mesalidade é de: R${valorMensalidade * 0.5} ");
            }

            else if (bolsista && mediaFinal > 6 && mediaFinal < 8)
            {
                Console.Clear();
                Console.WriteLine($"O aluno {nome}, matriculado no curso {curso}, com {idade} anos, Bolsista, com média final de {mediaFinal}, sua mesalidade é de: R${valorMensalidade * 0.7} ");
            }

            else
            {
                Console.Clear();
                Console.WriteLine($"O aluno {nome}, matriculado no curso {curso}, com {idade} anos, Bolsista, com média final de {mediaFinal}, sua mesalidade é de: R${valorMensalidade} ");
            }
        }

    }
}