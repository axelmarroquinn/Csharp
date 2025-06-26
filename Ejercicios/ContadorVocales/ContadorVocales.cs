using static System.Console;
namespace ContadorVocales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("*** EJERCICIO: CONTADOR DE VOCALES EN UNA FRASE ***");


            WriteLine("Ingrese una frase para contar sus vocales: ");
            string frase = ReadLine();

            frase = frase.ToLower();

            int vocalA = 0, vocalE = 0, vocalI = 0, vocalO = 0, vocalU = 0;

            foreach (char c in frase)
            {
                if (c == 'a') vocalA++;
                else
                    if (c == 'e') vocalE++;
                else
                    if (c == 'i') vocalI++;
                else
                    if (c == 'o') vocalO++;
                else
                    if (c == 'u') vocalU++;
            }

            int totalVocales = vocalA + vocalE + vocalI + vocalO + vocalU;

            WriteLine($"A = {vocalA}");
            WriteLine($"E = {vocalE}");
            WriteLine($"I = {vocalI}");
            WriteLine($"O = {vocalO}");
            WriteLine($"U = {vocalU}");
            WriteLine($"Total de vocales: {totalVocales}");
            ReadKey();
        }
    }
}