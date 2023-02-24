using BuilderPattern.Builders;
using System;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            ProductBuilder builder = new ProductBuilder();

            director.Builder = builder;

            director.BuildMinimalProduct();
            Console.WriteLine("=== Product 1 ===");
            builder.GetProduct().ShowParts();

            director.BuildFullProduct();
            Console.WriteLine("=== Product 2 ===");
            builder.GetProduct().ShowParts();
        }
    }
}
