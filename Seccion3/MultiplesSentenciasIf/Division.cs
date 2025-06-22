using static System.Console;
namespace MultiplesSentenciasIf
{
    internal class Division
    {
        static void Main(string[] args)
        {
            WriteLine("*** MÚLTIPLES SENTENCIAS EN IF ***");
            
            double dividendo, divisor, resultado;

            Write("Escribir el número a dividir (dividendo): ");
            dividendo = double.Parse(ReadLine());
            Write("Escribir el divisor: ");
            divisor = double.Parse(ReadLine());

            if (divisor != 0)
            {
                resultado = dividendo / divisor;
                WriteLine($"El resultado es {resultado}");
            }
        }
    }
}
