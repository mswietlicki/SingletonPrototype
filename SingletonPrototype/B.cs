namespace SingletonPrototype
{
    /// <summary>
    /// Not really true singleton. Has default public constructor;
    /// </summary>
    public class B : SingletonBase<B>
    {
        public string Print()
        {
            return "B";
        }
    }
}