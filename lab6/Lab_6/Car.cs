using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Car: Auto
    {
        private static int max_speed = 50;
        public override string funk1()
        {
            return "this is the object of Car class";
        }
        public Car()
        {
            Console.WriteLine("CAR constructor");
            over();
        }
        ~Car()
        {
            Console.WriteLine("CAR destruktor");
        }
        public override string funk2()
        {
            return " overrided funk 2 of car";
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
            Console.WriteLine("CAR funk hided by using \"new\" key word");
        }
    }
}
