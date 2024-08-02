using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalculadora
{
    public class Operador
    {
        public float n1;
        public float n2;

        public void Somar()
        {
            Console.WriteLine($"O resultado da soma é: {n1 + n2}");
        }
        public void Subtrair()
        {
            Console.WriteLine($"O resultado da subtração é: {n1 - n2}");
        }
        public void Multiplicar()
        {
            Console.WriteLine($"O resultado da multiplicação é: {n1 * n2}");
        }
        public void Dividir()
        {
            Console.WriteLine($"O resultado da divisao é: {n1 / n2}");
        }
    }
}