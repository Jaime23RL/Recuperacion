namespace CadenaPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una cadena: ");
            String cadena=Console.ReadLine();

            for(int i = 0; i < cadena.Length; i++)
            {
                char c = cadena[i];
                if(c%2 == 0)
                    Console.Write(c);
            }
        }
    }
}
