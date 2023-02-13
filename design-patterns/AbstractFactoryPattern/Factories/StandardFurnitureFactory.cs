using AbstractFactoryPattern.ProductInterfaces;
using AbstractFactoryPattern.Products.Standard;

namespace AbstractFactoryPattern.Factories
{
    public class StandardFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new StandardChair();
        }

        public ITable CreateTable()
        {
            return new StandardTable();
        }
    }
}
