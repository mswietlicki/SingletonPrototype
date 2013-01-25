namespace SingletonPrototype
{
    public class SomeBase<T>
    {
        public static int StaticValue { get; set; }
        public int Value { get { return StaticValue; } }

    }

    public class SomeChild: SomeBase<int>
    {
        
    }

    public class SomeOtherChild : SomeBase<string>
    {

    }

    public class SomeThirdChild : SomeBase<int>
    {

    }
}
