using System.ComponentModel.Design;
using static System.Console;
namespace SwitchOperacionesAritmeticas
{
    internal class OperacionesAritmeticas
    {
        static void Main(string[] args)
        {
            WriteLine("*** OPERACIONES ARITMÉTICAS CON SWITCH ***");

            decimal num1, num2, resultado;
            int opcion;

            WriteLine("1. Suma");
            WriteLine("2. Resta");
            WriteLine("3. Multiplicación");
            WriteLine("4. División");
            Write("Ingrese una de las opciones: ");
            opcion = int.Parse(ReadLine());
            Write("Ingrese el número 1: ");
            num1 = int.Parse(ReadLine());
            Write("Ingrese el número 2: ");
            num2 = int.Parse(ReadLine());

            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    WriteLine($"La suma de los números es {resultado}");
                    break;

                case 2:
                    resultado = num1 - num2;
                    WriteLine($"La resta de los números es {resultado}");
                    break;

                case 3:
                    resultado = num1 * num2;
                    WriteLine($"La multiplicación de los números es {resultado}");
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        WriteLine($"La división de los números es {resultado}");
                    }
                    else { WriteLine("No se puede dividir entre cero."); }
                    break;

                default:
                    WriteLine("Elegir opción válida.");
                    break;
            }
        }
    }
}
