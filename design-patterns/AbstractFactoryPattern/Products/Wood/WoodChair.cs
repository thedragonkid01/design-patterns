using AbstractFactoryPattern.ProductInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Products.Wood
{
    public class WoodChair : IChair
    {
        public void hasLeg()
        {
            Console.WriteLine("WoodChair has 4 legs");
        }

        public void sitOn()
        {
            Console.WriteLine("WoodChair sit on");
        }
    }
}
