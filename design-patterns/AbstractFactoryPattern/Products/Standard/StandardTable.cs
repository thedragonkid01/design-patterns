using AbstractFactoryPattern.ProductInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Products.Standard
{
    public class StandardTable : ITable
    {
        public void area()
        {
            Console.WriteLine("StandardTable has 32 cm2");
        }

        public void hasLeg()
        {
            Console.WriteLine("StandardTable has 4 legs");
        }

        public void shape()
        {
            Console.WriteLine("StandardTable is rectangle");
        }
    }
}
