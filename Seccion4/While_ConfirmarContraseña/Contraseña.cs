using static System.Console;
namespace While_ConfirmarContraseña
{
    internal class Contraseña
    {
        static void Main(string[] args)
        {
            WriteLine("*** REGISTRO DE CONTRASEÑA ***");

            string contraseña1, contraseña2 = "";

            Write("Escribe tu contraseña: ");
            contraseña1 = Console.ReadLine();

            while (contraseña1 != contraseña2)
            {
                Write("Confirma la mismna contraseña una vez más: ");
                contraseña2 = Console.ReadLine();
            }

            WriteLine("Contraseña guardada exitosamente!");
        }
    }
}
