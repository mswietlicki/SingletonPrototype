namespace SingletonPrototype
{
    public abstract class SingletonBase<T> where T :class, new()
    {
        private static class DummyNested
        {
            static DummyNested() { }

            public static readonly T INSTANCE = new T();
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
