using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Example1
{
    /// <summary>
    /// 单例模式
    /// Lazy load
    /// </summary>
    class Singleton4
    {
        private static int count;
        private Singleton4()
        {
            count++;
            Console.WriteLine(count);
        }

        private static class LazyHolder
        {
            public static Singleton4 _instance = new Singleton4();
        }

        public static Singleton4 GetInstance()
        {
            return LazyHolder._instance;
        }

        public void Write()
        {
            Console.WriteLine("{0} write->" + DateTime.Now, count);
        }
    }
}
