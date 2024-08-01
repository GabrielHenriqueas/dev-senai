using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos.Test
{
    public class CalculoUnitTest
    {
        //pricípio AAA :  Act, Arrange e Assert
        //pricípio AAA :  Agir, Organizar e Provar

        [Fact]
        public void SomarDoisNumeros()
        {
            //Organizar (Arrange)
            var n1 = 3.3;

            var n2 = 2.2;

            var valorEsperado = 5.5;

            //Agir (Act)
            var soma = Calculo.Somar(n1, n2);

            //Provar (Asset)
            Assert.Equal(valorEsperado, soma);
        }

        [Fact]
        public void SubtrairDoisNumeros()
        {
            var n1 = 10.0;

            var n2 = 2.0;

            var valorEsperado = 8.0;

            var subtracao = Calculo.Subtrair(n1, n2);

            Assert.Equal(valorEsperado, subtracao);
        }

        [Fact]
        public void MultiplicarDoisNumeros()
        {
            var n1 = 2.0;

            var n2 = 10.0;

            var valorEsperado = 20.0;

            var multiplicacao = Calculo.Multiplicar(n1,n2);

            Assert.Equal(valorEsperado, multiplicacao);
        }

        [Fact]
        public void DivideDoisNumeros()
        {
            var n1 = 10.0;

            var n2 = 2.0;

            var valorEsperado = 5.0;

            var divisao = Calculo.Dividir(n1, n2);

            Assert.Equal(valorEsperado, divisao);
        }
    }
}
