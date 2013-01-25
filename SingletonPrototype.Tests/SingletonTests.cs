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

        [TestMethod]
        public void SomeBaseTest()
        {
            SomeChild.StaticValue = 3;
            Assert.AreEqual(SomeChild.StaticValue, 3);

            SomeOtherChild.StaticValue = 5;
            Assert.AreEqual(SomeOtherChild.StaticValue, 5);

            Assert.AreEqual(SomeChild.StaticValue, 3);

            //But if SomeThirdChild and SomeChild are the same type;
            SomeThirdChild.StaticValue = 10;
            Assert.AreEqual(SomeThirdChild.StaticValue, 10);

            Assert.AreEqual(SomeChild.StaticValue, 10);
        }
    }
}
