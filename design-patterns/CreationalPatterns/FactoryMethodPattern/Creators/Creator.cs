using FactoryMethodPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Creators
{
    internal abstract class Creator
    {
        public abstract IProduct CreateProduct();
        public void DoOperation()
        {
            Console.WriteLine("Creator -> creating product");
            CreateProduct().DoOperation();
        }
    }
}
