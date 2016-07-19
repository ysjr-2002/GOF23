using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public class AppleProduct : Example3.IProduct
    {
        public void Cry()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public string Simle()
        {
            throw new NotImplementedException();
        }
    }
}