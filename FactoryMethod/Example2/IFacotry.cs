using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example2
{
    interface IFacotry<T>
    {
        T GetProduct();
    }
}
