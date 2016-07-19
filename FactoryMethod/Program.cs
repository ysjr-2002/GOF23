using FactoryMethod.Example1;
using FactoryMethod.Example2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Test2();
            Console.Read();
        }

        static void Test2()
        {
            IPerson person = ConcreteFactory.CreateProduct<ConretePerson>();

            person.Angry();

            person.Cry();

            person.Eat();

            person.Smile();
        }

        static void Test1()
        {
            IProduct1 product1 = new ConcreteFacotry1().CreateProduct1();
            IProduct2 product2 = new ConcreteFactory2().CreateProduct2();
            product1.Create();
            product1.Read();
            product1.Update();
            product1.Delete();
            product2.GetName(0);
        }
    }
}
