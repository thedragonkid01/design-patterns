using AbstractFactoryPattern.ProductInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Products.Standard
{
    public class StandardChair : IChair
    {
        public void hasLeg()
        {
            Console.WriteLine("StandardChair has 4 legs");
        }

        public void sitOn()
        {
            Console.WriteLine("StandardChair sit on");
        }
    }
}
