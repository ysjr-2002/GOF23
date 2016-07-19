using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Example1
{
    class Train : Festival
    {
        protected override void Travel()
        {
            Console.WriteLine("by train");
        }
    }
}
