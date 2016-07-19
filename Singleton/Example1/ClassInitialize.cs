using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Example1
{
    public class BaseA
    {
        public static MyTest a1 = new MyTest("a1");

        public MyTest a2 = new MyTest("a2");

        static BaseA()
        {
            MyTest a3 = new MyTest("a3");
        }

        public BaseA()
        {
            MyTest a4 = new MyTest("a4");
        }

        public virtual void MyFun()
        {
            MyTest a5 = new MyTest("a5");
        }
    }

    public class BaseB : BaseA
    {
        public static MyTest b1 = new MyTest("b1");

        public MyTest b2 = new MyTest("b2");

        static BaseB()
        {
            MyTest b3 = new MyTest("b3");
        }

        public BaseB()
        {
            MyTest b4 = new MyTest("b4");
        }

        public new void MyFun()
        {
            MyTest b5 = new MyTest("b5");
        }
    }


    public class MyTest
    {
        public MyTest(string info)
        {
            Console.WriteLine(info);
        }
    }



    public class ysja
    {
        public static MyTest a1 = new MyTest("a1");

        public MyTest a3 = new MyTest("a3");

        public MyTest a4 = new MyTest("a4");

        static ysja()
        {
            MyTest a2 = new MyTest("a2");
        }

        public ysja()
        {
            MyTest a5 = new MyTest("a5");
        }
    }

    public class ysjb : ysja
    {
        public static MyTest b1 = new MyTest("b1");

        public MyTest b3 = new MyTest("b3");

        public MyTest b4 = new MyTest("b4");

        static ysjb()
        {
            MyTest b2 = new MyTest("b2");
        }

        public ysjb()
        {
            MyTest b5 = new MyTest("b5");
        }
    }

    public class ysjc : ysjb
    {
        public static MyTest c1 = new MyTest("c1");

        public MyTest c3 = new MyTest("c3");

        public MyTest c4 = new MyTest("c4");


        static ysjc()
        {
            MyTest c2 = new MyTest("c2");
        }

        public ysjc()
        {
            MyTest c5 = new MyTest("c5");
        }
    }


    class OK
    {
        static MyTest d1 = new MyTest("d1");
        static readonly MyTest d3 = new MyTest("d2");
        readonly MyTest d2 = new MyTest("d4");

        static OK()
        {
            d3 = new MyTest("d3");
        }

        public OK()
        {
            d2 = new MyTest("d5");
        }

        public void Test()
        {
            //d2 = new MyTest("d5");
        }
    }
}
