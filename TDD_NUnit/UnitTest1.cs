using NUnit.Framework;
using System.IO;
using System;

namespace Comprobaciones_Simples
{
    public class Tests
    {

        [Test]
        public void Suma_Verificar()
        {
            int N1 = 3;
            int N2 = 4;
            int Esperado = 7;

            var Actual = CS.Calculos.Calcular_Suma(N1, N2);
            Assert.AreEqual(Esperado, Actual);
        }

        [Test]
        public void Resta_Verificar()
        {
            int N1 = 10;
            int N2 = 20;
            int Esperado = -10;

            var Actual = CS.Calculos.Calcular_Resta(N1, N2);
            Assert.AreEqual(Esperado, Actual);
        }

        [Test]
        public void Multiplicar_Verificar()
        {
            double N1 = 1.0312;
            double N2 = 32.9432;
            double Esperado = 33.971027839999991;

            var Actual = CS.Calculos.Calcular_Multiplicacion(N1, N2);
            Assert.AreEqual(Esperado, Actual);
        }

        [Test]

        // manejo de excepcion de divicion por 0
        //[ExpectedException(typeof(DivideByZeroException))]

        public void Dividir_Verificar()
        {
            int N1 = 0;
            int N2 = 10;
            int Esperado = 0;

            var Actual = CS.Calculos.Calcular_division(N1, N2);
            Assert.AreEqual(Esperado, Actual);
        }

        [Test]
        public void String_Verificar()
        {

            string Esperado = "Comprobacion De Un String";

            using (var SW = new StringWriter())
            {
                Console.SetOut(SW);
                CS.Calculos.Main();

                var Resultado = SW.ToString().Trim();
                Assert.AreEqual(Esperado, Resultado);
            }
        }

    }
}