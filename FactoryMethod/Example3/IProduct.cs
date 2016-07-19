using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.Example3
{
    public interface IProduct
    {
        void Eat();
        void Cry();
        /// <summary>
        /// 微笑
        /// </summary>
        string Simle();
    }
}