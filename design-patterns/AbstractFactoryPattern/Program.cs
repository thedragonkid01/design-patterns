using AbstractFactoryPattern.Factories;
using System;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client clientA = new Client(new WoodFurnitureFactory());
            clientA.OrderFurniture();

            Client clientB = new Client(new StandardFurnitureFactory());
            clientB.OrderFurniture();
        }
    }
}
