namespace Ejercicio3
{
    internal class Program
    {
        public static void ImprimirTablaMultiplicar()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"Tabla del {i}:");
                int j = 1;
                while(j <= 10)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                    j++;
                }
                i++;
            }
        }
        static void Main(string[] args)
        {
            ImprimirTablaMultiplicar();
        }
    }
}
