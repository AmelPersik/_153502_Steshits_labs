using NUnit.Framework;

using Lab_6;

namespace zTest
{
    public class Tests
    {


        [Test]
        public void Test1()
        {

            Combine j = new Combine();

            j.SetSpeed(45);



            Assert.AreEqual(45, j.speed());
        }

        [Test]
        public void Test2()
        {

            ElectroCar j = new ElectroCar();

            j.SetSpeed(45);

            Car i = new Car();

            Assert.AreEqual(45, i.speed());
        }

        [Test]
        public void Test3()
        {

            Combine combine = new Combine();

            string a = "This is an object of Combine class. ";

            Assert.AreEqual(a, combine.funk1());
        }

        [Test]
        public void Test4()
        {

            string a = " overrided funk 2 of SportCar";

            SportCar cat = new SportCar();

            Assert.AreEqual(a, cat.funk2());
        }
    }
}