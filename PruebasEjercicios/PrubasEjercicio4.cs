using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;ç
using NUnit;

namespace PruebasEjercicios
{
    internal class PrubasEjercicio4
    {
        Division d;

        public void Setup()
        {
            d = new Division();
        }

        [Test]
        public void TestValido()
        {
            double res = 2.5;
            Assert.AreEqual(d.Dividir(5,2),res);
        }
    }

    internal class Division()
    {
        public double Dividir(double a, double b)
        {
            double resultado = 0;
            if (b != 0)
            {
                resultado = a / b;
            }
            else
            {
                Console.WriteLine("No se puede dividir entre cero");
            }
            return resultado;
        }
    }
}
