using FactoryMethod.Example2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example2
{
    class ConretePerson : IPerson
    {
        public void Angry()
        {
            Console.WriteLine("Angry");
        }

        public void Cry()
        {
            Console.WriteLine("Cry");
        }

        public void Eat()
        {
            Console.WriteLine("Eat");
        }

        public void Smile()
        {
            Console.WriteLine("Smile");
        }
    }
}
