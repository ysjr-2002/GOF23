using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example2
{
    public class ConcreteFactory 
    {
        public static T CreateProduct<T>() where T : new()
        {
            T t = new T();
            return t;
        } 
    }
}
