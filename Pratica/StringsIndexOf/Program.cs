using System;

namespace StringsIndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este é um teste";
            // [index]   0123456789....14

            // texto.IndexOf() - Retorna a indice da String se for encontrada. Retorna -1 caso não encontrado.

            Console.WriteLine(texto.IndexOf("é")); // 5

            Console.WriteLine(texto.IndexOf("um")); // 7

            Console.WriteLine(texto.IndexOf("o")); // -1


            // texto.LastIndexOf() - Retorna a indice da Last (Ultima) palavra encontrada na String. Retorna -1 caso não encontrado.

            Console.WriteLine(texto.LastIndexOf("e")); // 14


            /* 
                Método String.IndexOf() -> Relata o índice da String caso for encontrada.
                
                O método retorna -1 caso não seja encontrado nessa instância.

                https://docs.microsoft.com/pt-br/dotnet/api/system.string.indexof?view=net-5.0
             */
        }
    }
}
