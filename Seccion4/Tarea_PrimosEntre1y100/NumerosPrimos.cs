using static System.Console;
namespace Tarea_PrimosEntre1y100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("*** CALCULAR LOS NÚMEROS PRIMOS ENTRE 1 Y 100 ***");

            for (int i = 1; i <= 100; i++)
            {
                int divisores = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0) divisores++;
                }
                if (divisores == 2) Console.Write(i + " ");
            } ReadKey();
        }
    }
}