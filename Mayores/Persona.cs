using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayores
{
    internal class Persona
    {
        private string Nombre{ get; set;}
        private int Edad {  get; set;}

        public Persona(String nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public int getEdad() { return Edad; }

        public void info()
        {
            Console.WriteLine(this.Nombre + " " + this.Edad + " años");
        }
    }
}
