namespace SumaPares
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Valor de N:");
            int N = int.Parse(Console.ReadLine());

            int suma = SumarNumerosPares(N);

            Console.WriteLine("La suma de los primeros " + N + " numeros es: " + SumarNumerosPares(N));
        }

        static int SumarNumerosPares(int N)
        {
            int suma = 0; // Inicializar la variable suma a 0
            for (int i = 1; i <= N; i++) // Bucle que va desde 1 hasta N
            {
                int numeroPar = 2 * i; // Calcular el número par
                suma = suma + numeroPar; // Añadir el número par a la suma
            }
            return suma; // Devolver la suma total
        }


    }

}
