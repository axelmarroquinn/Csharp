using static System.Console;
namespace Tarea_Meses
{
    internal class Meses
    {
        static void Main(string[] args)
        {
            WriteLine("*** MESES DEL AÑO ***");
            Write("Ingresa el número del que quieres conocer el mes: ");
            int opcion = int.Parse(ReadLine());

            switch (opcion)
            {
                case 1: WriteLine("1. Enero");
                    break;
                case 2: WriteLine("2. Febrero");
                    break;
                case 3: WriteLine("3. Marzo");
                    break;
                case 4: WriteLine("4. Abril");
                    break;
                case 5: WriteLine("5. Mayo");
                    break;
                case 6: WriteLine("6. Junio");
                    break;
                case 7: WriteLine("7. Julio");
                    break;
                case 8: WriteLine("8. Agosto");
                    break;
                case 9: WriteLine("9. Septiembre");
                    break;
                case 10: WriteLine("10. Octubre");
                    break;
                case 11: WriteLine("11. Noviembre");
                    break;
                case 12: WriteLine("12. Diciembre");
                    break;
                default: WriteLine("Ingresa un número de 1 a 12");
                    break;
            }
        }
    }
}
