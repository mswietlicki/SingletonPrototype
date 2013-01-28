namespace SingletonPrototype
{
    /// <summary>
    ///  True singleton with private constructor
    /// </summary>
    public class A: SingletonBase<A>
    {
        private A(){} 

        public string Print()
        {
            return "A";
        }
    }
}