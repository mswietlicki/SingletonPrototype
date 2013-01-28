using System;
using System.Reflection;

namespace SingletonPrototype
{
    public abstract class SingletonBase<T> where T :class
    {
        private static class DummyNested
        {
            static DummyNested()
            {
                try
                {
                    INSTANCE =
                        Activator.CreateInstance(typeof (T), BindingFlags.Instance | BindingFlags.NonPublic, null,
                                                 new object[] {}, null) as T;
                }
                catch (MissingMethodException)
                {
                    INSTANCE = Activator.CreateInstance(typeof (T)) as T;
                }
            }

            public static readonly T INSTANCE;
        }

        public static T Instance
        {
            get
            {
                return DummyNested.INSTANCE;
            }
        }
    }
}
