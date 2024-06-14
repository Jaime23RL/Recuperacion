namespace Ejercicio2
{
    internal class Program
    {
        public static void ContarHastaN(int n)
        {
            int count = 0;
            while (count < n)
            {
                Console.WriteLine(count);
                count++;
            }
        }
            static void Main(string[] args)
        {
            ContarHastaN(10);
        }
    }
}
