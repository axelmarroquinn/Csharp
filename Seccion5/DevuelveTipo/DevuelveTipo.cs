using static System.Console;
namespace DevuelveTipo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("*** MÉTODOS QUE DEVUELVEN UN TIPO ***");
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
            switch (opcion)
            {
                case 1:
                    Sumar();
                    break;
                case 2:
                    decimal r; // Almacena el valor retornado de Restar
                    r = Restar();
                    WriteLine($"El resultado de la resta es {r}");
                    break;
                case 3:

                case 4:

                    break;
                default:
                    break;
            }
            ReadLine();
        }// Cierre de Main

        // Sin parámetro ni tipo
        static void Sumar()
        {
            decimal num1, num2, resultado;
            WriteLine("Ingrese el primer número: ");
            num1 = int.Parse(ReadLine());
            WriteLine("Ingrese el segundo número: ");
            num2 = int.Parse(ReadLine());
            resultado = num1 + num2;
            Write($"El resultado de la suma es: {resultado}");
        }

        // Que devuelve un tipo
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
    }
}