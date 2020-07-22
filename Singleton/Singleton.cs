using System;

namespace Patterns.Singleton
{
    public sealed class SingletonThreadSafeBasic
    {
        private static SingletonThreadSafeBasic instance = null;

        private static readonly object lockerField = new object();

        public SingletonThreadSafeBasic()
        {

        }


        public static SingletonThreadSafeBasic Instance
        {
            get
            {
                lock (lockerField)
                {
                    if (instance == null)
                    {
                        instance = new SingletonThreadSafeBasic();
                        return instance;
                    }
                }

                return instance;
            }
        }
    }



    public sealed class SingletonThreadSafeAdvanced
    {
        private static readonly Lazy<SingletonThreadSafeAdvanced> _instance = new Lazy<SingletonThreadSafeAdvanced>(() => new SingletonThreadSafeAdvanced());
        private SingletonThreadSafeAdvanced() { }
        public static SingletonThreadSafeAdvanced Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}
