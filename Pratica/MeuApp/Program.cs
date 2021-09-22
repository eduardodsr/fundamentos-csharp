using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MeuMetodo();

            string NomeSobrenome = RetornaNome("Eduardo", "Rodrigues");
            Console.WriteLine(NomeSobrenome);

        }
        static void MeuMetodo()
        {
            Console.WriteLine("C# é legal!");
        }
        static string RetornaNome(string Nome, string Sobrenome)
        {
            return Nome + " " + Sobrenome;
        }
    }
}
