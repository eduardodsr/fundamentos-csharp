using System;

namespace StringsStartsWith
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este texto é um teste";

            // texto.StartsWith() - Verifica se String começa com a expressão

            Console.WriteLine(texto.StartsWith("ESTE", StringComparison.OrdinalIgnoreCase)); // True
            Console.WriteLine(texto.StartsWith("Este")); // True
            Console.WriteLine(texto.StartsWith("este")); // False
            Console.WriteLine(texto.StartsWith("texto")); // False

            // StringComparison.OrdinalIgnoreCase - Ignora Case Sensitive (Maiúsculas e Minúsculas)
        }
    }
}
