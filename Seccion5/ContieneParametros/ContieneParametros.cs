using static System.Console;
namespace ContieneParametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("*** MÉTODOS QUE CONTIENEN PARÁMETROS ***");
            int opcion;
            decimal r; // Almacena el valor retornado de Restar en Case 2
            decimal num1Ar, num2Ar; // Argumentos para enviar una copia al método Multiplicar en Case 3

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
            switch (opcion)
            {
                case 1:
                    Sumar();
                    break;
                case 2:
                    r = Restar();
                    WriteLine($"El resultado de la resta es {r}");
                    break;
                case 3:
                    Write("Ingrese el primer número: ");
                    num1Ar = Decimal.Parse(ReadLine());
                    WriteLine("Ingrese el segundo número: ");
                    num2Ar = Decimal.Parse(ReadLine());
                    Multiplicar(num1Ar, num2Ar); // Tener siempre en cuenta el orden en el que estamos enviando los argumentos [num1Ar = num1Pa, num2Ar = num2Pa]
                    break;
                case 4:

                    break;
                default:
                    break;
            }
            ReadLine();
        } // Cierre de Main

        // Método sin parámetro ni tipo
        static void Sumar()
        {
            decimal num1, num2, resultado;
            WriteLine("Ingrese el primer número: ");
            num1 = int.Parse(ReadLine());
            WriteLine("Ingrese el segundo número: ");
            num2 = int.Parse(ReadLine());
            resultado = num1 + num2;
            WriteLine($"El resultado de la suma es: {resultado}");
        }

        // Método que devuelve un tipo
        static decimal Restar()
        {
            decimal num1, num2, resultado;
            WriteLine("Ingrese el primer número: ");
            num1 = int.Parse(ReadLine());
            WriteLine("Ingrese el segundo número: ");
            num2 = int.Parse(ReadLine());
            resultado = num1 - num2;
            // return es usado cuando no es un método vacío (void).
            return resultado;
        }

        // Método que contiene parámetros
        static void Multiplicar (decimal num1Pa, decimal num2Pa) // Pa significa parámetros.
        {
            decimal resultado;
            resultado = num1Pa * num2Pa;
            Write($"La multiplicación es: {num1Pa} * {num2Pa} = {resultado}");
        }
    }
}