using Microsoft.VisualStudio.TestTools.UnitTesting;

using laborotorywork4;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Zhes c = Zhes.Initialize();
            int result = c.TotalCostAllMonth();
            c.UpPrice(153);
            Assert.AreEqual(c.TotalCostAllMonth(), result+153);
            
        }
    }
}