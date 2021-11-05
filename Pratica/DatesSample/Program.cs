using System;
using System.Collections.Generic;
using System.Linq;

namespace DateSample // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            // create a new date with system default initial value

            var dataInicial = new DateTime(); // data padrao (data iniciada do sistema) 
            Console.WriteLine(dataInicial); 
            // 1/1/0001 00:00:00

            // create a new date with a today value

            var dataAtual = DateTime.Now; // data atual (hoje)
            Console.WriteLine(dataAtual); 
            // 11/5/2021 4:48:57 PM

            // create a new date with a specific value
            var dataEspecifica = new DateTime(2021, 11, 5, 4, 59, 59); // data especifica
            Console.WriteLine(dataEspecifica); 
            // 11/5/2021 4:59:59 AM

            // ccreate a new date with a specific value
            var data = new DateTime(2020, 10, 12, 13, 14, 15, DateTimeKind.Local); // data especifica
            Console.WriteLine(data);
            Console.Write("Year: ");
            Console.WriteLine(data.Year);
            Console.Write("Month: ");
            Console.WriteLine(data.Month);
            Console.Write("Day: ");
            Console.WriteLine(data.Day);
            Console.Write("Hour: ");
            Console.WriteLine(data.Hour);
            Console.Write("Minute: ");
            Console.WriteLine(data.Minute);
            Console.Write("Second: ");
            Console.WriteLine(data.Second);

            // retornar o dia da semana
            var dataSemana = DateTime.Now;
            Console.Write("\nDia da Semana: ");
            Console.WriteLine((int)dataSemana.DayOfWeek); // 0 = Sunday, 1 = Monday, etc.
            // retornar o dia da semana 
            // 5 = Friday

            // retorna a data formatada
            var dataFormatada = DateTime.Now.ToString("dd/MM/yyyy"); /// data formatada (PT-BR)
            Console.Write("\nData Formatada (PT-BR): ");
            Console.WriteLine(dataFormatada);

            // formatar a data
            var data2 = DateTime.Now;

            var dataFormatada2 = String.Format("{0}", data2); // data formatada (EN-US)
            Console.Write("\nData Formatada (EN-US): ");
            Console.WriteLine(dataFormatada2);

            var dataFormatada3 = data2.ToString("dd/MM/yyyy hh:mm:ss ff zz"); // data formatada, ff = milisegundos, zz = time zone
            Console.Write("\nData Formatada: ");
            Console.WriteLine(dataFormatada3);

            var dataFormatada4 = data2.ToString("t"); // data formatada, t = AM/PM
            Console.Write("\nData Formatada: ");
            Console.WriteLine(dataFormatada4);

            var dataFormatada5 = data2.ToString("d"); // data formatada, d = short date
            Console.Write("\nData Formatada: ");
            Console.WriteLine(dataFormatada5);

            var dataFormatada6 = data2.ToString("D"); // data formatada, D = long date
            Console.Write("\nData Formatada: ");
            Console.WriteLine(dataFormatada6);

            var dataFormatada7 = data2.ToString("f"); // data formatada, f = full date
            Console.Write("\nData Formatada: ");
            Console.WriteLine(dataFormatada7);

            var dataFormatada8 = data2.ToString("F"); // data formatada, F = full date long time
            Console.Write("\nData Formatada: ");
            Console.WriteLine(dataFormatada8);

            var dataFormatada9 = data2.ToString("g"); // data formatada, g = general date
            Console.Write("\nData Formatada: ");
            Console.WriteLine(dataFormatada9);

            var dataFormatada10 = data2.ToString("G"); // data formatada, G = general date long time
            Console.Write("\nData Formatada: ");
            Console.WriteLine(dataFormatada10);

            var dataFormatada11 = data2.ToString("m"); // data formatada, m = month
            Console.Write("\nData Formatada: ");
            Console.WriteLine(dataFormatada11);

            var dataFormatada12 = data2.ToString("r"); // data formatada, r = RFC1123 date format
            Console.Write("\nData Formatada: ");
            Console.WriteLine(dataFormatada12); // Fri, 05 Nov 2021 20:48:27 GMT

            var dataFormatada13 = data2.ToString("s"); // data formatada, s = sortable date
            Console.Write("\nData Formatada: ");
            Console.WriteLine(dataFormatada13); // 2021-11-05T20:48:27 // JSON Data Format
           
        }
    }
}
