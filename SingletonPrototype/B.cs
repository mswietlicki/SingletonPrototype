namespace SingletonPrototype
{
    public class B : SingletonBase<B>
    {
        public string Print()
        {
            return "B";
        }
    }
}