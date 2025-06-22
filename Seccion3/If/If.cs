using static System.Console;
namespace If
{
    internal class If
    {
        static void Main(string[] args)
        {
            WriteLine("*** USO DE IF ***");
            WriteLine("Determinar si un número entero es positivo o negativo.");
            Write("Escribe el número entero a verificar: ");
            int entrada = int.Parse(ReadLine());

            if (entrada > 0)
            {
                WriteLine("El número es positivo.");
            }
            if (entrada < 0)
            {
                WriteLine("El número es negativo");
            }
        }
    }
}
