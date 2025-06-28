using static System.Console;
namespace SinParametroNiTipo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("*** MÉTODOS SIN PARÁMETRO NI TIPO ***");
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

                    break;
                case 3:

                case 4:

                    break;
                default:
                    break;
            }
            ReadLine();
        }// Cierre de Main
        static void Sumar()
        {
            decimal num1, num2, resultado;
            WriteLine("Ingrese el primer número: ");
            num1 = int.Parse(ReadLine());
            WriteLine("Ingrese el segundo número: ");
            num2 = int.Parse(ReadLine());
            resultado = num1 + num2;
            Write($"El resultado es: {resultado}");
        }
    }
}