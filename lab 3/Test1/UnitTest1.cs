using Microsoft.VisualStudio.TestTools.UnitTesting;

using Task_1;

namespace Test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void minimum()
        {
            test c = new test();
            double a = 0, b = 0;
            Assert.AreEqual(c.minimum(a, b), "Полученный результат:A=B");
        }
        [TestMethod]
        public void minimum2()
        {
            test c = new test();
            double a = 1, b = 0;
            Assert.AreEqual(c.minimum(a, b), "Полученный результат:A<B");
        }
        [TestMethod]
        public void minimum3()
        {
            test c = new test();
            double a = 0, b = 1;
            Assert.AreEqual(c.minimum(a, b), "Полученный результат:A>B");
        }
    }
}