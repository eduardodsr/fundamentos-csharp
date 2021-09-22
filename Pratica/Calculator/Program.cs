using System;

namespace Calculator
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
            Console.WriteLine("Bem Vindo! A calculadora em C#.");
            Console.WriteLine("");
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Divisao");
            Console.WriteLine("4 - Multiplicao");
            Console.WriteLine("5 - Sair do programa");
            Console.WriteLine("");
            Console.WriteLine("Selecione a operação: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

            Console.ReadKey();

        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");

            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");

            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;

            // Console.WriteLine("O resultado da soma é " + resultado);
            // Console.WriteLine("O resultado da soma é " + (v1 + v2));
            // Console.WriteLine($"O resultado da soma é {v1 + v2}.");
            Console.WriteLine($"O resultado da soma é {resultado}.");

            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");

            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");

            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;

            Console.WriteLine($"O resultado da subtracao é {resultado}.");

            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");

            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");

            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da divisão é {resultado}.");

            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");

            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");

            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação é {resultado}.");

            Console.ReadKey();
            Menu();
        }

    }
}
