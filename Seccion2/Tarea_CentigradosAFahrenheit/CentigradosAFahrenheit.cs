using static System.Console;
namespace Tarea_CentigradosAFahrenheit
{
    internal class CentigradosAFahrenheit
    {
        static void Main(string[] args)
        {
            double centigrados, fahrenheit, calculo;

            WriteLine("*** CONVERSIÓN DE CENTÍGRADOS A FAHRENHEIT ***");
            Write("Ingrese los grados centígrados a convertir: ");
            centigrados = double.Parse(Console.ReadLine());

            calculo = centigrados * 9 / 5 + 32;

            WriteLine($"Los {centigrados}C, son {calculo}F.");
        }
    }
}