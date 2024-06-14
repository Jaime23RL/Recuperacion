using System.Security.Cryptography;

namespace ListaNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            Random random = new Random();
            for (int i = 0; i < num.Length; i++)
                num[i] = random.Next(1, 100);
            for (int i = 0; i < num.Length; i++) 
            { 
                int n = num[i];
                if (n % 2 == 0)
                    Console.WriteLine("Numeros pares: " + n);
            }
        }
    }
}
