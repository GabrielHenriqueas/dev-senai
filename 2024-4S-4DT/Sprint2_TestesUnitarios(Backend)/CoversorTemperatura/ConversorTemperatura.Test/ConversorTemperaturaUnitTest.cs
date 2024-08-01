using ConversorTemperaturas;

namespace ConversorTemperatura.Test
{
    public class ConversorTemperaturaUnitTest
    {
        [Fact]
        public void ConverterCelsiusParaFahrenheit()
        {
            var n1 = 0.0;

            var valorEsperado = 32.0;

            var conversao = Formula.CelsiusParaFahrenheit(n1);

            Assert.Equal(valorEsperado, conversao);
        }
    }
}