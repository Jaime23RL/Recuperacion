using System;

namespace Ejercicio1
{
    class Calculadora
    {
        public static double Calcular(double a,double b,string operacion)
        {
            double resultado = 0;
            if (operacion == "suma")
            {
                resultado = a + b;
            }else if(operacion == "resta")
            {
                resultado=  a- b;
            }else if(operacion == "multiplicacion")
            {
                resultado = a * b;
            }
            else
            {
                resultado=double.NaN;
            }
            return resultado;
        }

        public Calculadora() { }
    }
}
