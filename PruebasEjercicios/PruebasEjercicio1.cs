using Ejercicio1;
using NUnit;

namespace PruebasEjercicios
{
    public class Tests
    {
        Calculadora c;

        [SetUp]
        public void Setup()
        {
            c=new Calculadora();
        }

        [Test]
        public void TestSuma()
        {
            double res = 10;
            Assert.AreEqual(c.Calcular(5, 5, "sumar"), res);
        }

        [Test]
        public void TestResta()
        {
            double res = 1;
            Assert.AreEqual(c.Calcular(5, 4, "resta"), res);
        }

        [Test]
        public void TestMultiplicacion()
        {
            double res = 20;
            Assert.AreEqual(c.Calcular(2,5,"multiplicacion"), res);
        }

        [Test]
        public void TestInvalido()
        {
            double res = double.NaN;
            Assert.AreEqual(c.Calcular(5,8,"X"),res);
        }
    }

    internal class Calculadora
    {
        public double Calcular(double a, double b, string operacion)
        {
            double resultado = 0;
            if (operacion == "suma")
            {
                resultado = a + b;
            }
            else if (operacion == "resta")
            {
                resultado = a - b;
            }
            else if (operacion == "multiplicacion")
            {
                resultado = a * b;
            }
            else
            {
                resultado = double.NaN;
            }
            return resultado;
        }
    }
}