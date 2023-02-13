using AbstractFactoryPattern.ProductInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Products.Wood
{
    public class WoodTable : ITable
    {
        public void area()
        {
            Console.WriteLine("WoodTable has 28 cm2");
        }

        public void hasLeg()
        {
            Console.WriteLine("WoodTable has 4 legs");
        }

        public void shape()
        {
            Console.WriteLine("WoodTable is circle");
        }
    }
}
