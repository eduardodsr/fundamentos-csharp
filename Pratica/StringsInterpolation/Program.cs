using System;

namespace StringsInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            var price = 9.99;

            var texto = $"O preço do produto é {price} apenas na promoção!!!";
            Console.WriteLine(texto);
            Console.WriteLine("");

            // var textoMultiplasLinhas = $@"O preço do produto é ===========================
            // {price} ===============================";
            // Console.WriteLine(textoMultiplasLinhas);
            // Console.WriteLine("");

            var textoInterpolacao = $" O preço do produto é \n {price} apenas na promoção. \n Volte Sempre. \n Tenha um excelente dia.";
            Console.WriteLine(textoInterpolacao);
            Console.WriteLine("");

            var price1 = 10.1;
            var texto1 = "O preço do produto é " + price1;
            Console.WriteLine(texto1);
            Console.WriteLine("");

            var price2 = 10.2;
            var texto2 = "O preço do produto é " + price2 + " apenas na promoção.";
            Console.WriteLine(texto2);
            Console.WriteLine("");

            var price3 = 10.3;
            var texto3 = string.Format(
                "O preço do produto é {0} apenas na promoção.",
                price3);
            Console.WriteLine(texto3);
            Console.WriteLine("");

            var price4 = 10.4;
            var texto4 = string.Format(
                "O preço do produto é {1} apenas na promoção {0}.",
                price4,
                true);
            Console.WriteLine(texto4);

        }
    }
}

