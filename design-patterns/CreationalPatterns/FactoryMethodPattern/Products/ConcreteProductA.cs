using System;

namespace FactoryMethodPattern.Products
{
    internal class ConcreteProductA : IProduct
    {
        public void DoOperation()
        {
            Console.WriteLine("Product worked from ConcreteProductA");
        }
    }
}
