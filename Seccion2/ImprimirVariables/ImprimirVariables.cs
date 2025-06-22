namespace ImprimirVariables
{
    internal class ImprimirVariables
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** IMPRIMIR VARIABLES ***");

            string saludo = "Hola";
            Console.WriteLine(saludo);

            char caracter = 'a';
            Console.WriteLine(caracter);

            int numero = 444;
            Console.WriteLine(numero);

            double i = 5.55;
            Console.WriteLine(i);

            int precioCamisa = 200;
            string colorCamisa = "Azul";
            Console.WriteLine("El precio de la camisa es de: {0}", precioCamisa); // Formato compuesto
            Console.WriteLine($"El precio de la camisa es de: {precioCamisa}"); // Interpolación de cadenas
            Console.WriteLine("El precio de la camisa es de {0} y es color {1}", precioCamisa, colorCamisa); // Formato compuesto
            Console.WriteLine($"El precio de la camisa es de {precioCamisa} y es color {colorCamisa}"); // Interpolación de cadenas

        }
    }
}
