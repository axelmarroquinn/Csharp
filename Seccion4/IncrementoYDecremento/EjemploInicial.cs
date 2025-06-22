using static System.Console;
namespace IncrementoYDecremento
{
    internal class EjemploInicial
    {
        static void Main(string[] args)
        {
            WriteLine("*** OPERADORES DE INCREMENTO Y DECREMENTO ***");

            int i;
            i = 10;

            WriteLine($"Valor inicial del operando: {i}");
            WriteLine($"\nInicialización del incremento de 1...... Ahora es {i++}");
            WriteLine($"Valor incrementado: {i}");
            WriteLine($"Inicialización del decremento de 1...... Ahora es {i--} ");
            WriteLine($"Valor decrementado: {i}");
        }
    }
}
