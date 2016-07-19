using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Example1
{
    public abstract class Festival
    {
        protected void subscribeTicket()
        {
            Console.WriteLine("subscribeTicket");
        }

        protected abstract void Travel();

        protected void clebrate()
        {
            Console.WriteLine("clebrate");
        }


        public void Happy()
        {
            subscribeTicket();

            Travel();

            clebrate();

            Console.WriteLine("over");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
