using System;
using System.IO;

namespace Library
{
    public class FilePrinter : IPrinter // Implementa la interfaz IPrinter, utilizando así el principio de polimorfismo.
    {
        public void PrintRecipe(Recipe recipe)  // Se utiliza el patrón SRP para que el método tenga una sola responsabilidad: Imprimir
        // todo el archivo.
        {
            File.WriteAllText("Ticket.txt", recipe.GetTextToPrint());
        }
    }
}