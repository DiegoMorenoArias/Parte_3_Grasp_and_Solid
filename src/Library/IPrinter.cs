using System;
using System.IO;

namespace Library
{
    public interface IPrinter // Se crea una interfaz IPrinter pues es algo que hace tanto la consola como el archivo. Polimorfismo ;)
    {
        void PrintRecipe(Recipe recipe);
    }
}