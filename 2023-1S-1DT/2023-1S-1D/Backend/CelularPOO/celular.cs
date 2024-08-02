using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelularPOO
{
    public class Celular
    {
        public string cor = "";
        public string modelo = "";
        public string tamanho = "";
        public bool ligado;

        public void Ligar()
        {
            Console.Clear();
            ligado = true;
            Console.WriteLine($"Ligando...");
        }

        public void FazerLigacao()
        {
            Console.WriteLine($"Para quem você deseja ligar?");
            string contato = Console.ReadLine()!;
            Console.Clear();
            Console.WriteLine($"Ligando para {contato}...");
        }

        public void EnviarMensagem()
        {
            Console.WriteLine($"Para quem você deseja enviar mensagem?");
            string contato = Console.ReadLine()!;
            Console.Clear();

            Console.WriteLine($"Qual mensagem você deseja enviar: ");
            string mensagem = Console.ReadLine()!;
            Console.Clear();

            Console.WriteLine(@$"Enviando '{mensagem}' para {contato}...");
        }

        public void Desligar()
        {
            Console.Clear();
            
            ligado = false;
            Console.WriteLine($"Desligando...");
        }
    }
}