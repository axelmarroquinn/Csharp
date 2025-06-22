using static System.Console;
namespace Acumulador
{
    internal class Acumuladores
    {
        static void Main(string[] args)
        {
            WriteLine("*** USO DEL ACUMULADOR <4 ***");

            int i;
            int acumulador = 0;
            int precio;

            for (i = 0; i < 4; i++)
            {
                Write("Ingresa el precio del producto: ");
                precio = int.Parse(ReadLine());

                acumulador = acumulador + precio; // Acumula en cada vuelta el total de cada item.
            }

            WriteLine($"El total es {acumulador}");
            ReadLine();
        } 
    }
}
