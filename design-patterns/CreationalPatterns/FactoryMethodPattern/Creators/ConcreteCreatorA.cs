using FactoryMethodPattern.Products;

namespace FactoryMethodPattern.Creators
{
    internal class ConcreteCreatorA : Creator
    {
        public override IProduct CreateProduct()
        {
            return new ConcreteProductA();
        }
    }
}
