using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    sealed public class Combine : Auto
    {
        private static int max_speed = 20;
        public override string funk1()
        {
            return "This is an object of Combine class. ";
        }
        public Combine()
        {
            Console.WriteLine("Combine constructor");
            over();
        }
        ~Combine()
        {
            Console.WriteLine("Combine destruktor");
        }
        public override string funk2()
        {
            return " overrided funk 2 of combine";
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
            Console.WriteLine("Combine hided funk by using \"new\" but calling \"base\".funk()");
            base.NewFunk();
        }
    }
}
