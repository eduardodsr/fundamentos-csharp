using System;

namespace MeuApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma estrutura (Struct)
            var mouse = new Product();
            // var mouse = new Product(1, "Mouse gamer", 199.97, EProductType.Product);
            var repair = new Product(2, "Repair PC", 399.99, EProductType.Service);

            mouse.Id = 1;
            mouse.Name = "Mouse gamer";
            mouse.Price = 199.99;

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine((int)mouse.Type);

            Console.WriteLine(repair.Id);
            Console.WriteLine(repair.Name);
            Console.WriteLine(repair.Price);
            Console.WriteLine((int)repair.Type);
        }
        struct Product
        {
            public Product(int id, string name, double price, EProductType type)
            {
                Id = id;
                Name = name;
                Price = price;
                Type = type;
            }
            public int Id;
            public string Name;
            public double Price;
            public EProductType Type;

            // public double PriceInDolar(double dolar)
            // {
            //     return Price * dolar;
            // }
        }

        enum EProductType
        {
            Product = 1,
            Service = 2
        }
    }
}

