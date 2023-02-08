using FactoryMethodPattern.Products;

namespace FactoryMethodPattern.Creators
{
    internal class ConcreteCreatorB : Creator
    {
        public override IProduct CreateProduct()
        {
            return new ConcreteProductB();
        }
    }
}
