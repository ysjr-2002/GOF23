using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Example1
{
    /// <summary>
    /// 单例模式
    /// 全加锁，频繁访问性能不收影响
    /// </summary>
    /// <remarks>
    /// 加锁是要损耗性能的
    /// </remarks>
    public class Singleton2
    {
        private static Singleton2 _instance = null;

        private static object obj = new object();

        private static int count = 0;

        private Singleton2()
        {
            count++;
            Console.WriteLine(count);
        }

        public static Singleton2 GetInstance()
        {
            lock (obj)
            {
                if (_instance == null)
                {
                    _instance = new Singleton2();
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
