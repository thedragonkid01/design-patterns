using BuilderPattern.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Director
    {
        private IProductBuilder _builder;

        public IProductBuilder Builder { set { _builder = value; } }

        public void BuildMinimalProduct()
        {
            _builder.BuildPartA();
            _builder.BuildPartD();
        }

        public void BuildFullProduct()
        {
            _builder.BuildPartA();
            _builder.BuildPartB();
            _builder.BuildPartC();
            _builder.BuildPartD();
        }
    }
}
