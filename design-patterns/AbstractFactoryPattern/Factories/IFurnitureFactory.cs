using AbstractFactoryPattern.ProductInterfaces;

namespace AbstractFactoryPattern.Factories
{
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ITable CreateTable();
    }
}
