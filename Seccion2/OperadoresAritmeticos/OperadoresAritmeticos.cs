using static System.Console;
namespace OperadoresAritmeticos
{
    internal class OperadoresAritmeticos
    {
        static void Main(string[] args)
        {
            WriteLine("*** OPERADORES ARITMÉTICOS ***");

            WriteLine(5 + 5);

            int num1 = 5, num2 = 10;
            WriteLine(num1 + num2);

            double num3 = 1.5;
            double resultado;
            resultado = num1 + num2 + num3;
            Console.WriteLine(resultado); // Sumas

            WriteLine(10 - 5); // Restas
            WriteLine(3 * 3); // Multiplicaciones
            WriteLine(15 / 3); // Divisiones
            WriteLine(5 % 2); // Residuo de una división [Resto ó Módulo]

            WriteLine("\n*** CONCATENAR ***"); // El \n hace un salto de línea en consola
            string saludo = "¡Hola";
            string nombre = "Constantino!";
            WriteLine(saludo + nombre); // Se imprime todo junto
            WriteLine(saludo + " " + nombre + " ¿Cómo estás?"); // Añade un espacio y la pregunta
        }
    }
}
