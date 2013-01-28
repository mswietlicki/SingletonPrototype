using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SingletonPrototype.Tests
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void SingletonTest()
        {
            Assert.AreEqual(A.Instance.Print(), "A");
            Assert.AreEqual(B.Instance.Print(), "B");
            Assert.AreEqual(A.Instance.Print(), "A");

            var aa = A.Instance;

            Assert.AreEqual(aa.Print(), "A");
        }
    }
}
