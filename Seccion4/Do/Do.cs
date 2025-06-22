using System.Collections;
using static System.Console;
namespace Do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("*** OPERACIONES ARITMÉTICAS CON SWITCH (INTEGRANDO DO) ***");

            decimal num1, num2, resultado;
            int opcion;

            do
            {
                WriteLine("1. Suma");
                WriteLine("2. Resta");
                WriteLine("3. Multiplicacion");
                WriteLine("4. División");
                Write("Escoge una opción: ");
                opcion = int.Parse(ReadLine());
            }

            while ((opcion < 1) || (opcion > 4));
                WriteLine("Dame el primer número: ");
                num1 = int.Parse(ReadLine());
                WriteLine("Dame el segundo número: ");
                num2 = int.Parse(ReadLine());

            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    WriteLine($"La suma es: {resultado}");
                    break;
                case 2:
                    resultado = num1 - num2;
                    WriteLine($"La resta es: {resultado}");
                    break;
                case 3:
                    resultado = num1 * num2;
                    WriteLine($"La multiplicación es: {resultado}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        WriteLine($"La división es: {resultado}");
                    } else {
                        WriteLine("No se puede dividir entre cero!"); }
                    break;
                default:
                    WriteLine("Elegir una opción válida!");
                break;
            }
            ReadLine();
        } 
    }
}