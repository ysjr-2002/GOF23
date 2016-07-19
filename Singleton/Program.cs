using Singleton.Example1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton4 instanc1 = null;
            Singleton4 instanc2 = null;
            Singleton4 instanc3 = null;
            Singleton4 instanc4 = null;
            new Thread(() =>
            {
                instanc1 = Singleton4.GetInstance();
            }).Start();

            new Thread(() =>
            {
                instanc2 = Singleton4.GetInstance();
            }).Start();

            new Thread(() =>
            {
                instanc3 = Singleton4.GetInstance();
            }).Start();

            new Thread(() =>
            {
                instanc4 = Singleton4.GetInstance();
            }).Start();


            Thread.CurrentThread.Join(500);
            if ((instanc1 == instanc2) && (instanc3 == instanc4))
            {
                Console.WriteLine("singleton");
            }
            else
            {
                Console.WriteLine("singleton error");
            }

            Console.Read();
        }
    }
}
