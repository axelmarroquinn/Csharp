using System.Timers;
using static System.Console;
namespace IfAnidado
{
    internal class OperacionesBasicas
    {
        static void Main(string[] args)
        {
            WriteLine("*** USO DE IF ANIDADO ***");

            int suma, resta, multi, divi, num1, num2, operacion;

            WriteLine("1. Suma");
            WriteLine("2. Resta");
            WriteLine("3. Multiplicación");
            WriteLine("4. División");
            Write("Ingrese la operación a realizar según su número: ");
            operacion = int.Parse(Console.ReadLine());

            Write("Ingrese el primer número: ");
            num1 = int.Parse(Console.ReadLine());

            Write("Ingrese el segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            if (operacion == 1)
            {
                int resultado = num1 + num2;
                WriteLine($"El resultado es: {resultado}");
            }
            if (operacion == 2)
            {
                int resultado = num1 - num2;
                WriteLine($"El resultado es: {resultado}");
            }
            if (operacion == 3)
            {
                int resultado = num1 * num2;
                WriteLine($"El resultado es: {resultado}");
            }
            if (operacion == 4)
            {
                if (num2 != 0) 
                { 
                int resultado = num1 / num2;
                
                WriteLine($"El resultado es: {resultado}");
                }
                else 
                {
                    WriteLine("No es posible dividir entre cero!");
                }
            }
        }
    }
}
