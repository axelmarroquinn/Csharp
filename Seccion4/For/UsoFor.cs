using static System.Console;
namespace For
{
    internal class UsoFor
    {
        static void Main(string[] args)
        {
            WriteLine("*** Instrucciones de Iteración: For ***");

            int i;

            for ( i = 1; i <= 10; i++ ) // Cuenta desde 1 hasta 10 de uno en uno.
            {
                Console.WriteLine(i);
            }

            WriteLine("----------------------------------------------------");

            int x;

            for ( x = 0; x < 11; x += 2 ) // Cuenta desde 0 hasta 10 de dos en dos.
            {
                Console.WriteLine(x);
            }

            WriteLine("----------------------------------------------------");

            int y;

            for ( y = 20; y >= 0; y-= 2 ) // Cuenta desde 20 hasta 0 de dos en dos de manera descendente.
            {
                Console.WriteLine(y);
            }

            WriteLine("------------------------- CONTADOR #1 ---------------------------");

            int j;
            int contador = 0;

            for (j = 1; j <= 10; j++)
            {
                contador++;
                WriteLine($"Vuelta del ciclo número {contador}");
            }
            WriteLine($"El número de vueltas que dio el ciclo fue: {contador}");

            WriteLine("------------------------- CONTADOR #2 ---------------------------");

            int w;
            int contador2 = 0;

            for (w = 0; w < 11; w+=2)
            {
                contador2++;
                WriteLine($"{w}, vuelta del ciclo {contador2}");
            }
        }
    }
}
