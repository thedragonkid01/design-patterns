using AbstractFactoryPattern.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Client
    {
        private readonly IFurnitureFactory _factory;

        public Client(IFurnitureFactory factory)
        {
            this._factory = factory;
        }

        public void OrderFurniture()
        {
            Console.WriteLine("----- Order Funiture From Factory " + _factory.GetType().ToString());

            Console.WriteLine("-- Order Chair --");
            var chair = _factory.CreateChair();
            chair.hasLeg();
            chair.sitOn();

            Console.WriteLine("-- Order Table --");
            var table = _factory.CreateTable();
            table.hasLeg();
            table.shape();
            table.area();
        }
    }
}
