using AbstractFactoryPattern.ProductInterfaces;
using AbstractFactoryPattern.Products.Wood;

namespace AbstractFactoryPattern.Factories
{
    public class WoodFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new WoodChair();
        }

        public ITable CreateTable()
        {
            return new WoodTable();
        }
    }
}
