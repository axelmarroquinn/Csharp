using static System.Console;
namespace TomaDeDecisiones
{
    internal class VariablesBooleanas
    {
        static void Main(string[] args)
        {
            WriteLine("*** TOMA DE DECISIONES CON VARIABLES BOOLEANAS ***");

            WriteLine("Operadores de igualdad o desigualdad: ");
            int a = 3, b = 4;
            WriteLine(a == b); // Devolverá un booleano False, ya que no son iguales.
            int c = 5, d = 5;
            WriteLine(c == d); // Devolverá un booleano True, ya que sí son iguales.

            WriteLine("Operadores de comparación: ");
            WriteLine(5 > 4); // Devolverá True, ya que 5 es mayor que 4.
            WriteLine (5 <= 5); // Devolverá True, ya que 5 es igual que 5.
        }
    }
}