using Microsoft.VisualStudio.TestTools.UnitTesting;

using FirstTask;

namespace test_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            int tnum = 27;
            int b = tnum % 10;
            int a = tnum / 10;

            int c = (a + b) % 3;

            Assert.AreEqual(0, c);
        }
        [TestMethod]
        public void TestMethod2()
        {

            int tnum = 19;
            int b = tnum % 10;
            int a = tnum / 10;

            int c = (a + b) % 3;

            Assert.AreEqual(1, c);
        }
        [TestMethod]
        public void TestMethod3()
        {

            int tnum = 99;
            int b = tnum % 10;
            int a = tnum / 10;

            int c = (a + b) % 3;

            Assert.AreEqual(0, c);
        }
    }
}