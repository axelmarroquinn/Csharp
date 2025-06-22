using static System.Console;
namespace EjercicioCalificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("*** SUMA Y PROMEDIO DE CALIFICACIONES ***");

            byte i, numAlumnos;
            double calificacion, sumaCalif = 0, promedio;

            Write("Ingresa el número de alumnos a calificar: ");
            numAlumnos = Convert.ToByte(ReadLine());

            for (i = 1; i <= numAlumnos; i++)
            {
                Write("Ingresa la calificación: ");
                calificacion = Convert.ToDouble(ReadLine());

                sumaCalif += calificacion;
            }

            promedio = sumaCalif / numAlumnos;

            WriteLine($"El promedio es {promedio}");
            WriteLine($"La suma de las calificaciones es {sumaCalif}");
        }
    }
}
