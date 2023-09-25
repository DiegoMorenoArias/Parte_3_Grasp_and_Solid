using System;
using System.IO;

namespace Library
{
    public class ConsolePrinter : IPrinter // Implementa la interfaz IPrinter, utilizando así el principio de polimorfismo
    {
        public void PrintRecipe(Recipe recipe) // Se utiliza el patrón SRP para que el método tenga solo una responsabilidad: imprimir
        // todo en la consola.
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}