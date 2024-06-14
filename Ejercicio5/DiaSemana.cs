using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class DiaSemana
    {
        public static void MostrarDiasDeLaSemana(int dia)
        {
            string nombreDia = "";
            switch (dia)
            {
                case 1:
                    nombreDia = "Lunes";
                    break;
                case 2:
                    nombreDia = "Martes";
                    break;
                case 3:
                    nombreDia = "Miercoles";
                    break;
                case 4:
                    nombreDia = "Jueves";
                    break;
                case 5:
                    nombreDia = "Viernes";
                    break;
                case 6:
                    nombreDia = "Sábado";
                    break;
                case 7:
                    nombreDia = "Domingo";
                    break;
                default:
                    Console.WriteLine("Día no válido");
                    break;

            }
            Console.WriteLine($"El día {dia} es {nombreDia}");
        }
    }
}
