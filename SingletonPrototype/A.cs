namespace SingletonPrototype
{
    public class A: SingletonBase<A>
    {
        public string Print()
        {
            return "A";
        }
    }
}