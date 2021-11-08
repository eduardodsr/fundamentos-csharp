using System;
using System.Collections.Generic;
using System.Linq;

namespace DateTimezone // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.Clear();

            var dateTime = DateTime.UtcNow; //  UTC = Universal Time Coordinated

            Console.Write("Date e Hora Global: ");
            Console.WriteLine(dateTime);    //  Date e Hora Global: 2019-08-14T21:00:00Z

            Console.Write("Date e Hora UTC: ");
            Console.WriteLine(dateTime.ToUniversalTime());  // ToUniversalTime() = Converte para UTC

            Console.Write("Date e Hora Local: ");
            Console.WriteLine(dateTime.ToLocalTime()); //  ToLocalTime() = Converte para Local

            Console.Write("\nHora Atual do Servidor: ");
            Console.WriteLine(DateTime.Now); //  DateTime.Now = Retorna a hora atual do servidor

            Console.Write("\n\n");

            // Examples Timezone
            var timeZoneBrazil = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
            Console.WriteLine("\nTimezone Brazil: " + timeZoneBrazil.DisplayName);

            var timeZoneNewYork = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            Console.WriteLine("\nTimezone New York: " + timeZoneNewYork.DisplayName);

            var timeZoneLondon = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            Console.WriteLine("\nTimezone London: " + timeZoneLondon.DisplayName);

            var timeZoneTokyo = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
            Console.WriteLine("\nTimezone Tokyo: " + timeZoneTokyo.DisplayName);

            // timeZone Brazil

            Console.Write("\n");

            var timeZone = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
            Console.WriteLine("\nTimezone Brazil: " + timeZone.DisplayName);
       
        }
    }
}