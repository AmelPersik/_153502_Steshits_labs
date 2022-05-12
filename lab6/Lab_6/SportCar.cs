using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class SportCar : Car
    {
        private static int max_speed = 200;
        public override string funk1()
        {
            return "This is an object of SportCar";
        }
        public SportCar()
        {
            

            Console.WriteLine("SportCar constructor");
            over();
        }
        ~SportCar()
        {
            Console.WriteLine("SportCar destruktor");
        }
        public override string funk2()
        {
            return " overrided funk 2 of SportCar";
        }

        public override int speed()
        {
            return max_speed;
        }

        public override void SetSpeed(int sp)
        {
            max_speed = sp;
        }

        public new void NewFunk()
        {
            Console.WriteLine("SportCar hided funk even from CAR parent class");
        }
    }
}
