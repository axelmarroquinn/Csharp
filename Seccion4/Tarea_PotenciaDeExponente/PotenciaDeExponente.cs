using static System.Console;
namespace Tarea_PotenciaDeExponente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("*** CALCULAR LA POTENCIA DE CUALQUIER EXPONENTE ***");
            double numeroBase, resultado;
            int exponente;

            WriteLine("Escribe la base: ");
            numeroBase = double.Parse(Console.ReadLine());
            WriteLine("Escribe el exponente: ");
            exponente = int.Parse(Console.ReadLine());

           resultado = Math.Pow(numeroBase, exponente);
            WriteLine($"El resultado es: {resultado}");
            ReadKey();
        }
    }
}
