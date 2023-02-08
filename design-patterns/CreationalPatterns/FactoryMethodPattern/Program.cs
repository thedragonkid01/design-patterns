using FactoryMethodPattern.Creators;
using System;

namespace FactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------- Client A ----------");
            var clientA = new Client(new ConcreteCreatorA());
            clientA.DoOperation();

            Console.WriteLine("----------- Client B ----------");
            var clientB = new Client(new ConcreteCreatorB());
            clientB.DoOperation();
        }
    }
}
