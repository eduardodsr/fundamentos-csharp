using System;
using System.Globalization; // System.Globalization.CultureInfo

namespace DatesCultureInfo // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            var date = DateTime.Now;    

            Console.Write("\nData formatada: ");
            Console.WriteLine(date.ToString("dddd, dd MMMM yyyy"));

            Console.Write("\nData não formatada: ");
            Console.WriteLine(DateTime.Now);

            // CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern
            // CultureInfo.CurrentCulture.DateTimeFormat.LongDatePattern

            var cultureInfoBR = new System.Globalization.CultureInfo("pt-BR");
            Console.Write("\nData formatada (pt-BR): ");
            Console.WriteLine(date.ToString("d", cultureInfoBR));

            var cultureInfoUS = new System.Globalization.CultureInfo("en-US");
            Console.Write("\nData formatada (en-US): ");
            Console.WriteLine(date.ToString("d", cultureInfoUS));

            // Outra forma mais simples de formatar a data (a mesma coisa que o exemplo acima)
            var br = new System.Globalization.CultureInfo("pt-BR");
            var en = new System.Globalization.CultureInfo("en-US");

            Console.Write("\nData formatada (pt-BR): ");
            Console.WriteLine(DateTime.Now.ToString("d", br));

            Console.Write("\nData formatada (en-US): ");
            Console.WriteLine(DateTime.Now.ToString("d", en));

            // ==================================================================
            // Example CultureInfo (System.Globalization.CultureInfo) e Long Date
            // Using System.Globalization; // linha 2
            // CultureInfo // nas linhas 47 a 53
            // ==================================================================

            var br1 = new CultureInfo("pt-BR"); //  var br = new System.Globalization.CultureInfo("pt-BR");
            Console.Write("\nData formatada (pt-BR): ");
            Console.WriteLine(DateTime.Now.ToString("D", br1)); // long date

            var us1 = new CultureInfo("en-US"); // var us = new System.Globalization.CultureInfo("en-US");
            Console.Write("\nData formatada (en-US): ");
            Console.WriteLine(DateTime.Now.ToString("D", us1)); // long date

            // Cultura Atual do Sistema Operacional
            // CultureInfo.CurrentCulture

            var cultureInfoAtualSistema = CultureInfo.CurrentCulture;

            Console.WriteLine("\nLinguagem Padrao do Sistema Operacional: " + cultureInfoAtualSistema);

            Console.Write("\nData padrao do Sistema Operacional: ");
            Console.WriteLine(DateTime.Now.ToString("D", cultureInfoAtualSistema));
        
         }
    }
}
