using static System.Console;
namespace OperadoresLogicos
{
    internal class OperadoresLogicosBooleanos
    {
        static void Main(string[] args)
        {
            WriteLine("*** OPERADORES LÓGICOS BOOLEANOS ***");
            WriteLine("****** Negación ! ******"); // ***********************

            // Ejemplo básico

            bool p = true;

            WriteLine(p);
            WriteLine(!p);

            // Aplicación real

            bool batería;

            Write("Hay batería? (true/false): ");
            batería = Convert.ToBoolean(ReadLine());

            if (!(batería == true))
            {
                WriteLine("Conecte su teléfono.");
            }
            else
            {
                WriteLine("No es necesario conectar su teléfono.");
            }

            WriteLine("\n****** And lógico && ******"); // ***********************

            // Ejemplo básico

            bool q = true;
            bool r = true;

            WriteLine(q && r);

            // Aplicación real

            int edad;
            bool licencia;

            Write("Escribe tu edad: ");
            edad = int.Parse(ReadLine());
            Write("Escribe 'true' si tienes licencia, 'false' si no tienes licencia. ");
            licencia = Convert.ToBoolean(ReadLine());

            if ((edad >= 18) && (licencia == true))
            {
                WriteLine("Puedes conducir!");
            }
            else
            {
                WriteLine("Lo siento, no puedes conducir.");
            }


            WriteLine("\n****** Or lógico || ******"); // ***********************

            // Ejemplo básico

            bool a, b;

            a = true;
            b = false;

            WriteLine(a || b);

            // Aplicación real

            float calCarrera, calExamen;

            Write("Escribe el promedio de tu carrera nivel medio: ");
            calCarrera = Convert.ToSingle(ReadLine());
            Write("Escribe el resultado de tu examen de admisión: ");
            calExamen = Convert.ToSingle(ReadLine());

            if ((calCarrera >= 9) || (calExamen >= 9.5 ))
            {
                WriteLine("Felicidades, tienes la beca!");
            }
            else
            {
                WriteLine("Lo sentimos, no aplicas a la beca");
            }
        }
    }
}