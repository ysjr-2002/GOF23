using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example1
{
    class ConcreteFactory2 : IFacotry2
    {
        public IProduct2 CreateProduct2()
        {
            return new ConcreteProduct2();
        }
    }
}
