using static System.Console;
namespace IfElseAnidado
{
    internal class OperacionesBasicas2
    {
        static void Main(string[] args)
        {
            WriteLine("*** USO DE IF-ELSE ***");

            int num1, num2, operacion;

            WriteLine("1. Suma");
            WriteLine("2. Resta");
            WriteLine("3. Multiplicación");
            WriteLine("4. División");
            Write("Ingrese la operación a realizar según su número: ");
            operacion = int.Parse(ReadLine());

            Write("Ingrese el primer número: ");
            num1 = int.Parse(ReadLine());

            Write("Ingrese el segundo número: ");
            num2 = int.Parse(ReadLine());

            if (operacion == 1)
            {
                int resultado = num1 + num2;
                WriteLine($"El resultado es: {resultado}");
            }
            else if (operacion == 2)
            {
                int resultado = num1 - num2;
                WriteLine($"El resultado es: {resultado}");
            }
            else if (operacion == 3)
            {
                int resultado = num1 * num2;
                WriteLine($"El resultado es: {resultado}");
            }
            else if (operacion == 4)
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
            else
            {
                WriteLine("Opción no válida. Por favor, elija un número del 1 al 4.");
            }
        }
    }
}
