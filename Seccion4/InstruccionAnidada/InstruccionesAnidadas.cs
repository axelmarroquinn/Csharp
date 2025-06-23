using static System.Console;
namespace InstruccionAnidada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("*** INSTRUCCIONES ANIDADAS ***");

            int i, j, resultado;

            for (i = 1; i <= 10; i++)
            {
                WriteLine($"Tabla de multiplicar del {i}");

                for (j = 1; j <= 10; j++)
                {
                    resultado = i * j;
                    WriteLine($"El resultado de {i} * {j} = {resultado}");
                } ReadLine();
            }
        }
    }
}
