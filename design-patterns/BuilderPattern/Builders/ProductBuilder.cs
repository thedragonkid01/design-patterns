using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builders
{
    internal class ProductBuilder : IProductBuilder
    {
        private Product _product;

        public ProductBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            _product = new Product();
        }

        public void BuildPartA()
        {
            _product.Add("Part A");
        }

        public void BuildPartB()
        {
            _product.Add("Part B");
        }

        public void BuildPartC()
        {
            _product.Add("Part C");
        }

        public void BuildPartD()
        {
            _product.Add("Part D");
        }

        public Product GetProduct()
        { 
            Product product = _product;
            Reset();
            return product;
        }
    }
}
