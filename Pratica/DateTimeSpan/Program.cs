using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.Clear();

            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);    //  00:00:00
            Console.WriteLine("\n");

            var timeSpanNanoseconds = new TimeSpan(1);
            Console.WriteLine(timeSpanNanoseconds);    //  00:00:00.0000001
            Console.WriteLine("\n");

            var timeSpanHoursMinutesSeconds = new TimeSpan(1, 2, 3);   //  1 hora, 2 minutos e 3 segundos
            Console.WriteLine(timeSpanHoursMinutesSeconds);    //  00:01:02.00000003
            Console.WriteLine("\n");

            var timeSpanDaysHoursMinutesSeconds = new TimeSpan(1, 2, 3, 4);   //  1 dia, 2 horas, 3 minutos e 4 segundos
            Console.WriteLine(timeSpanDaysHoursMinutesSeconds);    //  00:00:01.000000024
            Console.WriteLine("\n");

            var timeSpanDaysHoursMinutesSecondsMiliSeconds = new TimeSpan(1, 2, 3, 4, 5);   //  1 dia, 2 horas, 3 minutos, 4 segundos e 5 milisegundos
            Console.WriteLine(timeSpanDaysHoursMinutesSecondsMiliSeconds);    //  00:00:01.0000025
            Console.WriteLine("\n");

  
        }
    }
}
