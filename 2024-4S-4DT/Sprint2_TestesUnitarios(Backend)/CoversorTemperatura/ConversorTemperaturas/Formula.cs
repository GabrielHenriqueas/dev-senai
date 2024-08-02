//Exercício 3: Teste de Conversão de Temperatura
//Crie um teste unitário para o método ConverterCelsiusParaFahrenheit que verifica se a conversão de Celsius para Fahrenheit é calculada corretamente.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    public static class Formula
    {
        public static double CelsiusParaFahrenheit(double c)
        {
            return c * 9 / 5 + 32;
        }
    }
}
