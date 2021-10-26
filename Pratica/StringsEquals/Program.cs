using System;

namespace StringsEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este texto é um teste";

            // texto.Equals() - Verifica se o expressão é Igual a String (var texto)

            Console.WriteLine(texto.Equals("ESTE tExTo é um TeStE", StringComparison.OrdinalIgnoreCase)); // True
            Console.WriteLine(texto.EndsWith("este texto é um teste")); // False
            Console.WriteLine(texto.EndsWith("Este texto é um teste")); // True
            Console.WriteLine(texto.EndsWith("texto")); // False

        }
    }
}
