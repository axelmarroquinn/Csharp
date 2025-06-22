using static System.Console;
namespace AreaYPerimetro
{
    internal class AreaYPerimetro
    {
        static void Main(string[] args)
        {
            decimal b, a;

            WriteLine("*** CALCULAR ÁREA Y PERÍMETRO DE UN RECTÁNGULO ***");

            Console.Write("Escriba la base del rectángulo: ");
            b = decimal.Parse(ReadLine());
            Console.Write("Escriba la altura del rectángulo: ");
            a = decimal.Parse(ReadLine());

            decimal calculoArea = b * a;
            decimal calculoPerimetro = 2 * (b + a);

            Console.WriteLine("El área es de: {0}", calculoArea);
            Console.WriteLine("El perímetro es de: {0}", calculoPerimetro);
        }
    }
}
