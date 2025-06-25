using static System.Console;
namespace IntroduccionMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("*** INTRODUCCIÓN Y SINTAXIS DE LOS MÉTODOS ***");
            Console.WriteLine("Escribe tu nombre: ");
            string nombre = Console.ReadLine();
            // tipoDeDato Nombre(parámetros){Código que se ejecuta & return valor; si el tipo no es void.}
            string Saludo(string nombre)
            {
                Console.WriteLine($"Hola {nombre}!");
                return nombre; // Se usa return ya que no es un método vacío (void).
            }
            Saludo(nombre);
            ReadKey();
        }
    }
}
