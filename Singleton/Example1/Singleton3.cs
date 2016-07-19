using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Example1
{
    /// <summary>
    /// 单例模式
    /// 加锁+双判断
    /// 只有在instance为null时才使用锁
    /// </summary>
    class Singleton3
    {
        private static Singleton3 _instance = null;

        private static object obj = new object();

        private static int count = 0;

        private Singleton3()
        {
            count++;
            Console.WriteLine(count);
        }

        public static Singleton3 GetInstance()
        {
            if (_instance == null)
            {
                lock (obj)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton3();
                    }
                }
            }
            return _instance;
        }

        public void Write()
        {
            Console.WriteLine("{0} write->" + DateTime.Now, count);
        }
    }
}
