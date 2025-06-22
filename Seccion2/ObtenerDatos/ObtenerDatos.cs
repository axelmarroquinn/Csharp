using static System.Console;
namespace ObtenerDatos
{
    internal class ObtenerDatos
    {
        static void Main(string[] args)
        {
            WriteLine("*** OBTENER DATOS CON READLINE ***");

            string nombre;

            Write("Escriba su nombre: ");
            nombre = ReadLine();

            WriteLine("¡Hola {0}!", nombre);

            int num1, num2;

            Write("Escriba el primer número: ");
            num1 = Convert.ToInt32(ReadLine()); 
            Write("Escriba el segundo número: ");
            num2 = int.Parse(ReadLine());
            int suma = num1 + num2;
            int resta = num1 - num2;
            int multi = num1 * num2;
            int divi = num1 / num2;

            WriteLine("La suma es {0}", suma);
            WriteLine("La resta es {0}", resta);
            WriteLine("La multiplicación es {0}", multi);
            WriteLine("La división es {0}", divi);
            Write("¡Gracias por usar este programa!");
        }
    }
}
