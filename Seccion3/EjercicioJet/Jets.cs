using static System.Console;
namespace EjercicioJet
{
    internal class Jets
    {
        static void Main(string[] args)
        {
            WriteLine("*** EJERCICIO JET ***");

            bool propulsor1, propulsor2;
            int bateria;

            Write("Ingrese el funcionamiento del propulsor 1 (true o false): ");
            propulsor1 = Convert.ToBoolean(ReadLine());

            Write("Ingrese el funcionamiento del propulsor 2 (true o false): ");
            propulsor2 = Convert.ToBoolean(ReadLine());

            Write("Ingrese el porcentaje de la batería: ");
            bateria = Convert.ToInt32(ReadLine());

            if (((propulsor1 && propulsor2 == true) && (bateria >= 75)) || ((propulsor1 || propulsor2 == true) && (bateria == 100)))
            {
                WriteLine("Puedes despegar.");
            }
            else
            {
                WriteLine("No puedes despegar.");
            }
        }
    }
}
