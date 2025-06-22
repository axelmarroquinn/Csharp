using static System.Console;
namespace InstruccionSwitch
{
    internal class InstruccionSwitch
    {
        static void Main(string[] args)
        {
            WriteLine("*** INSTRUCCIÓN SWITCH ***");
            Write("Ingrese un número de 1 a 3 para seleccionar una opción: ");
            int opcion = int.Parse(ReadLine());

            switch (opcion)
            {
                case 1:
                    WriteLine("Opción 1: Ver archivos.");
                    break;
                case 2:
                    WriteLine("Opción 2: Editar archivos.");
                    break;
                case 3:
                    WriteLine("Opción 3: Salir del programa.");
                    break;
                default:
                    WriteLine("Elegir opción válida.");
                    break;
            }
        }
    }
}
