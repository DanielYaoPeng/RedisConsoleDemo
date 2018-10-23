using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisConsoleDemoOne
{
    /// <summary>
    /// 单例
    /// </summary>
    public sealed class SingletonLogic
    {
        /** 
         * 非线程安全的，
         * 2个不同的线程可以同时进入这个方法，如果instance为空的并且这里返回真的情况下，都可以创建实例
        private static SingletonLogic instance = null;

        private SingletonLogic()
        {

        }

        public static SingletonLogic Instance
        {
            get
            {
                if (instance == null) 
                {
                    instance = new SingletonLogic();
                }

                return instance;
            }
        }
        **/

        /**
         * 线程安全 ，设置了个共享锁，可能会有性能问题
        private static SingletonLogic instance = null;

        private static readonly object padlock = new object();

         SingletonLogic()
        {

        }

         public static SingletonLogic Instance
         {
             get
             {
                 lock (padlock)
                 {
                     if (instance == null)
                     {
                         instance = new SingletonLogic();
                     }

                     return instance;
                 }
             }
         }
        */

        
        //不完全懒汉模式，线程安全的 且不用锁
        private static readonly SingletonLogic instance = new SingletonLogic();
        //创建一个静态只读实例化类，访问时自动实例化一次

        //显式静态构造函数
        //告诉编译器没必要标记类型 - 在field初始化以前
        static SingletonLogic()
        {

        }
        private SingletonLogic() 
        {
        
        }

        public static SingletonLogic Instance
        {
            get { return instance; }
        }



        /// <summary>
        /// 完全lazy ，懒汉，线程安全
        /// </summary>
        //private SingletonLogic()
        //{

        //}

        //public static SingletonLogic instance { get { return Nested.instance; } }

        //private class Nested
        //{
        //    static Nested()
        //    {

        //    }
        //    internal static readonly SingletonLogic instance = new SingletonLogic();
        //}

        

    }


    public sealed class Singleton
    {
        //Laze<T>是线程安全的 ，在多线程环境下，第一个访问 Lazy<T> 对象的 Value 属性的线程将初始化 Lazy<T> 对象，
        //以后访问的线程都将使用第一次初始化的数据。
        private static readonly Lazy<Singleton> lazy =
            new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance { get { return lazy.Value; } }

        private Singleton()
        {
        }
    }
}
