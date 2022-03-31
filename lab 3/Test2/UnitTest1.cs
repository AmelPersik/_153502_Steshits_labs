using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_2;
namespace Test2
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void func1()
        {
            Class1 c = new Class1();
            int z = 0;
            Assert.AreEqual(c.func(z), "Ветка №2(x =  z * z + 5) при z<=0");
        }
        [TestMethod]
        public void func2()
        {
            Class1 c = new Class1();
            int z = -2;
            Assert.AreEqual(c.func(z), "Ветка №2(x =  z * z + 5) при z<=0");
        }
        [TestMethod]
        public void func3()
        {
            Class1 c = new Class1();
            int z = 10;
            Assert.AreEqual(c.func(z), "Ветка №1(x = 1 / (Math.Sqrt(z - 1)) при z>0");
        }

    }
}