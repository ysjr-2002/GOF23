using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.Example1;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("beigin cliebtra----------->");

            Festival bus = new Bus();
            Festival train = new Train();
            Festival air = new Air();

            bus.Happy();
            train.Happy();
            air.Happy();

            Console.Read();
        }
    }
}
