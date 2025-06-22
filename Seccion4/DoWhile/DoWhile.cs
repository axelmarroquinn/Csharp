using static System.Console;
namespace DoWhile
{
    internal class DoWhile
    {
        static void Main(string[] args)
        {
            WriteLine("*** USO DE DO WHILE ***");

            int i = 0;

            do
            {
                WriteLine(i++); // Imprime de 0 a 10 aumentando de uno en uno.
            }
            while (i <= 10);

        }
    }
}
