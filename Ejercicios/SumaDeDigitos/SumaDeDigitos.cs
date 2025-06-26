using static System.Console;
namespace SumaDeDigitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("*** EJERCICIO: SUMAR LOS DÍGITOS DE UN ENTERO ***");
            WriteLine("Escribe un número entero positivo: ");
            int entrada = int.Parse(ReadLine());
            int numero;

            if (entrada < 0)
            {
                WriteLine("El número debe ser positivo!");
                return;
            }

            int suma = 0; // Inicialización de variables para guardar la suma de los dígitos

            while (entrada > 0) // Se ejecuta mientras el número aún tenga dígitos
            {
                int digito = entrada % 10;  // Obtiene el último dígito 
                suma += digito; // Suma el dígito a la variable suma
                entrada /= 10;   // Elimina el último dígito dividiendo entre 10            
            }

            WriteLine($"La suma de los dígitos es: {suma}");
            ReadKey();
        }
    }
}
