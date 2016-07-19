using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example1
{
    class ConcreteProduct2 : IProduct2
    {
        public string GetName(int id)
        {
            Console.WriteLine("product Getname");
            return "product Getname";
        }
    }
}
