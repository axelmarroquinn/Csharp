using static System.Console;
namespace Tarea_PerimetroPoligono
{
    internal class PerimetroPoligono
    {
        static void Main(string[] args)
        {
            float longitud, cantidadLados;

            WriteLine("*** CÁLCULO DEL PERÍMETRO DE UN POLÍGONO ***");
            Write("Ingrese la longitud de cada lado: ");
            longitud = float.Parse(ReadLine());
            Write("Ingrese la cantidad de lados: ");
            cantidadLados = float.Parse(ReadLine());

            float calculoPerimetro = longitud * cantidadLados;

            WriteLine($"El perímetro es de {calculoPerimetro}");
        }
    }
}