using Microsoft.VisualStudio.TestTools.UnitTesting;

using SecondTask;
namespace test2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void check_point()
        {
            test c = new test();
            int x = 0, y = 0;
            Assert.AreEqual(c.check_point(x, y), "the point is on the border.\n");
        }
        [TestMethod]
        public void check_point2()
        {
            test c = new test();
            int x = 12, y = 12;
            Assert.AreEqual(c.check_point(x, y), "the point is on the border.\n");
        }
        [TestMethod]
        public void check_point3()
        {
            test c = new test();
            int x = -2, y = -3;
            Assert.AreEqual(c.check_point(x, y), "The point is outside the area.\n");
        }
        [TestMethod]
        public void check_point4()
        {
            test c = new test();
            int x = 5, y = 0;
            Assert.AreEqual(c.check_point(x, y), "The point is outside the area.\n");
        }
    }
}