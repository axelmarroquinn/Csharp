namespace Variables
{
    internal class Variables
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** VARIABLES ***");

            // Variables de enteros.
            int numeroLibros;
            int librosNiños;
            int librosMatematicas;

            // Inicialización de la variable numeroLibros.
            numeroLibros = 500;

            // Creación e inicialización de la variable promedioFinal.
            double promedioFinal = 9.8;
            decimal promedioExamenes = 9.9M; // Es necesario ponerle la M para que el compilador no "piense" que es un double.
            float promedioAdultos = 9.9F; // Se debe agregar la F para compilar correctamente.

            // Creación e inicialización de variables tipo char, string, bool.
            char salon = 'A';
            string saludo = "Hola!";
            bool x = true;
            bool y = false;

            /* Este es un bloque
             * de comentarios */
        }
    }
}
