using System;
using System.Collections.Generic;
using System.Linq;

namespace DateValues // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            // Adicionando valores a data, e imprimindo na tela.
            // Adicionando (years, months, days, hours, minutes, seconds, milliseconds)): 

            var data = DateTime.Now; // Note: DateTime.Now retorna a data e hora atual.

            Console.WriteLine("=================================");
            Console.WriteLine("Data PT-BR: " + data.ToString("dd/MM/yyyy hh:mm:ss tt"));
            Console.WriteLine("Data atual: " + data);
            Console.WriteLine("=================================");
          
            // var res = data.AddDays(1); // adiciona 1 dia
            // Console.Write("\nData + 1 dia: " + res);

            Console.WriteLine("\n=================================");
             Console.WriteLine("Data + 1 y: " + data.AddYears(1) + "\n");   // adicionando 1 ano
            Console.WriteLine("Data + 1 d: " + data.AddDays(1) + "\n");     // adiciona 1 dia
            Console.WriteLine("Data + 1 h: " + data.AddHours(1) + "\n");    // adiciona 1 hora
            Console.WriteLine("Data + 1 m: " + data.AddMinutes(1) + "\n");  // adiciona 1 minuto
            Console.WriteLine("Data + 1 s: " + data.AddSeconds(1));         //  adiciona 1 segundo
            Console.WriteLine("\n=================================");
            

            // Exemplo de data nula (vazia)
            DateTime? dataNula = null;
            Console.WriteLine("\nData nula: " + dataNula);
            
            
                       
            // Comparando datas

            var dataComparacao = DateTime.Now;


            Console.WriteLine("\nComparando datas: ");

            if (dataComparacao.Date == DateTime.Now.Date)
            {
                Console.WriteLine("\nData comparação é igual a data atual.");
            }
            else
            {
                Console.WriteLine("\nData comparação é diferente da data atual.");
            }
                       
        }
    }
}


 