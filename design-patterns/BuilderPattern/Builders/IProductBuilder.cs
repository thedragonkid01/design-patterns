using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builders
{
    internal interface IProductBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();
        void BuildPartD();
    }
}
