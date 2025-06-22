using static System.Console;
namespace Tarea_Numeros
{
    internal class Numeros
    {
        static void Main(string[] args)
        {
            WriteLine("*** AVERIGUAR SI ES NÚMERO PAR O IMPAR ***");
            Write("Ingresa el número a verificar: ");
            int ingreso = int.Parse(ReadLine());

            if ( ingreso % 2 == 0) // Si el residuo de dividir entre 2 es igual a 0, es par.
            {
                WriteLine("Es número par.");
            }
            else 
            {
                WriteLine("Es número impar.");
            }
        }
    }
}
