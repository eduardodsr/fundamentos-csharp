using System;

namespace StringsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este texto é um teste";
            //  [index]  0123456789...  


            Console.WriteLine(texto.ToLower()); // este texto é um teste

            Console.WriteLine(texto.ToUpper()); // ESTE TEXTO É UM TESTE

            Console.WriteLine(texto.Insert(5, "AQUI ")); // Este AQUI texto é um teste

            Console.WriteLine(texto.Remove(0, 11)); // é um teste

            Console.WriteLine(texto.Remove(0, 7)); // xto um teste

            Console.WriteLine(texto.Remove(5, 6)); // Este é um teste

            Console.WriteLine(texto.Length); // 21

            Console.WriteLine(texto.Replace("Este", "Esse")); // Esse texto é um teste

            Console.WriteLine(texto.Replace("e", "x")); // Estx txxto é um txstx

            var divisao = texto.Split(' '); // [0]Este [1]texto [2]é [3]um [4]teste
            Console.WriteLine(divisao[0]); // Este
            Console.WriteLine(divisao[1]); // textp
            Console.WriteLine(divisao[2]); // é
            Console.WriteLine(divisao[3]); // um
            Console.WriteLine(divisao[4]); // teste

            var resultado = texto.Substring(0, 4);
            Console.WriteLine(resultado); // Este

            var resultado2 = texto.Substring(5, 5);
            Console.WriteLine(resultado); // texto

            var texto2 = "     Este é um teste     ";
            // * Trim() - It is used to remove all leading and trailing white-space characters from the current String object.
            Console.WriteLine(texto2.Trim()); // Este texto é um teste // limpar os espaços em branco no começo e no fim

            /* 
            Método String.ToLower()
            =====================
            ToLower() -> Retorna uma cópia dessa cadeia de caracteres convertida em minúsculas.


            Método String.ToUpper()
            =====================
            ToUpper() -> Retorna uma cópia dessa cadeia de caracteres convertida em maiúsculas.


            Método Insert(Int32, String)
            ===========================

            Insert(Int32, String) -> Retorna uma nova 'cadeia de caracteres', inserida em uma posição de índice especificada nesta instância.
                    |->  indice  

            Método Remove(int startIndex, int count)
            ======================================== 

            (int startIndex, int count) -> Retorna uma nova cadeia de caracteres em que um número especificado de caracteres na instância atual que começa na posição especificada foi excluído.          

            */
        }
    }
}

