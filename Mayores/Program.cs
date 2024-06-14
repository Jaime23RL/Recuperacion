namespace Mayores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona[] p=new Persona[8];
            p[0] = new Persona("Carlos", 25);
            p[1] = new Persona("Maria", 40);
            p[2] = new Persona("Juan",18);
            p[3] = new Persona("Pedro",30);
            p[4] = new Persona("Izaskun",80);
            p[5] = new Persona("Bruno",3);
            p[6] = new Persona("Isabel",31);
            p[7] = new Persona("Ana",15);

            for(int i=0; i<p.Length; i++)
            {
                int num = p[i].getEdad();
                if (num > 30)
                    p[i].info();
            }
        }
    }
}
