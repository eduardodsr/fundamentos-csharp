using System;

namespace StringsComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este texto é um teste";

            // Comparação
            // Verificar se String contém a expressão
            Console.WriteLine(texto.Contains("teste")); // True
            Console.WriteLine(texto.Contains("Teste")); // False
            Console.WriteLine(texto.Contains("TesTE", StringComparison.OrdinalIgnoreCase));
            // StringComparison.OrdinalIgnoreCase - Ignora Case Sensitive (Maiúsculas e Minúsculas)

            // Sintax: bool string.Contains(string value) 
            // Return: True or False
        }
    }
}
