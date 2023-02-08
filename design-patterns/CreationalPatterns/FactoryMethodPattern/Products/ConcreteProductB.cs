using System;

namespace FactoryMethodPattern.Products
{
    internal class ConcreteProductB : IProduct
    {
        public void DoOperation()
        {
            Console.WriteLine("Product worked from ConcreteProductB");
        }
    }
}
