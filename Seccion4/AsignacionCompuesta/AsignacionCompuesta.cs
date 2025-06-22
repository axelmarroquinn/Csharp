using static System.Console;
namespace AsignacionCompuesta
{
    internal class AsignacionCompuesta
    {
        static void Main(string[] args)
        {
            WriteLine("*** Asignación Compuesta ***");

            int x = 2;
            WriteLine(x);

            x += 5; // x = x + 5, x ya vale 7.
            WriteLine(x);

            x -= 3; // x = x - 3, x ya valía 7.
            WriteLine(x);   
        }
    }
}
