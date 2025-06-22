using static System.Console;
namespace IfElse
{
    internal class MayorDeEdad
    {
        static void Main(string[] args)
        {
            WriteLine("*** USO DE IF ELSE ***");
            WriteLine("Determinar si eres mayor de edad.");
            int edad;
            Write("Ingresa tu edad: ");
            edad = int.Parse(ReadLine());

            if ( edad > 18 )
            {
                WriteLine("Eres mayor de edad :D ");
            }
            else
            {
                WriteLine("Eres menor de edad :( ");
            }
        }
    }
}
