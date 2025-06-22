using static System.Console;
namespace While
{
    internal class While
    {
        static void Main(string[] args)
        {
            WriteLine("*** USO DE WHILE ***");

            byte numero = 1;

            while (numero <= 10)
            {
                WriteLine(numero);
                numero++;
            }
        }
    }
}
