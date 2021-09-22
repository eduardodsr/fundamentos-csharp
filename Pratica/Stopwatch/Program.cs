using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem Vindo! Ao programa Stopwatch.");
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0s = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            // ToLower() -> Converter para minúsculo
            char type = char.Parse(data.Substring(data.Length - 1, 1)); // Pegar o último digito
            int time = int.Parse(data.Substring(0, data.Length - 1)); // Obtendo o tempo digitado, menos o ultimo caractere
            // Substring() -> Recupera uma subcadeia (parte) de caracteres desta instância.

            int multiplier = 1;

            if (type == 'm') multiplier = 60;

            if (time == 0) System.Environment.Exit(0); // Sair

            PreStart(time * multiplier); // chamar o cronometro


            // Console.WriteLine(data); // mostra a data (o que foi digitado)
            // Console.WriteLine(time); // mostra o time
            // Console.WriteLine(type); // mostrar o ultimo caractere

        }
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2000);

            Start(time);
        }
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); // using System.Threading; 
                // esperar 1 seg
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(1000);
            Menu();

        }
    }
}
