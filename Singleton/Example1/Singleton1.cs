using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton.Example1
{
    /// <summary>
    /// 单例模式一 
    /// 静态变量声明，可以防止多线程
    /// 非延时创建
    /// </summary>
    public class Singleton1
    {
        private static Object obj = new object();
        private static Singleton1 _instance = new Singleton1();

        private Singleton1()
        {
            Console.WriteLine("被实例化");
        }

        public static Singleton1 GetInstance()
        {
            lock (obj)
            {
                Thread.Sleep(5000);
                return _instance;
            }
        }

        public void Write()
        {
            Console.WriteLine("write->" + DateTime.Now);
        }
    }
}
