using static System.Console;
namespace Tarea_Estacionamiento
{
    internal class Estacionamiento
    {
        static void Main(string[] args)
        {
            WriteLine("*** CÁLCULO DE PRECIO DE ESTACIONAMIENTO ***");
            Write("Ingrese cuantos minutos estuvo en el lugar: ");
            int minutos = int.Parse(ReadLine());
            // 60 minutos = $5.00, 2 horas(120 minutos) = $15.00, más de 2 horas = $40.00.
            if ((minutos >= 0) && (minutos <= 60))
            {
                WriteLine("Pague $5.");
            }
            else if (( minutos >= 61) && (minutos <= 120))
            {
                WriteLine("Pague $15.");
            }
            else if (minutos >= 121)
            {
                WriteLine("Pague $40.");
            }
        }
    }
}
