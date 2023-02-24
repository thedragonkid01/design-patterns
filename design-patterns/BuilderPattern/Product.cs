using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Product
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        { 
            _parts.Add(part);
        }

        public void ShowParts()
        {
            Console.WriteLine($"Product parts: {string.Join("-", _parts)}");
        }
    }
}
