using System;

namespace StringsEndsWith
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este texto é um teste";

            // texto.EndsWith() - Verifica se String termina com a expressão

            Console.WriteLine(texto.EndsWith("TESTE", StringComparison.OrdinalIgnoreCase)); // True
            Console.WriteLine(texto.EndsWith("Teste")); // False
            Console.WriteLine(texto.EndsWith("teste")); // True
            Console.WriteLine(texto.EndsWith("texto")); // False

        }
    }
}
