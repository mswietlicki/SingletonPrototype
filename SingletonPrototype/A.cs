namespace SingletonPrototype
{
    public class A: SingletonBase<A>
    {
        private A(){}

        public string Print()
        {
            return "A";
        }
    }
}