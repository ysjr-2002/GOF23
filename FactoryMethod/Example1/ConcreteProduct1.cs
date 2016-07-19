using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example1
{
    class ConcreteProduct1 : IProduct1
    {
        public void Create()
        {
            Console.WriteLine("product1 create");
        }

        public void Delete()
        {
            Console.WriteLine("product1 Delete");
        }

        public void Read()
        {
            Console.WriteLine("product1 Read");
        }

        public void Update()
        {
            Console.WriteLine("product1 Update");
        }
    }
}
