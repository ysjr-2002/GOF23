using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example1
{
    class ConcreteFacotry1 : IFactory1
    {
        public IProduct1 CreateProduct1()
        {
            return new ConcreteProduct1();
        }
    }
}
