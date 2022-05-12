using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    abstract public class Auto
    {
        private int max_speed = 5;
        abstract public string funk1();

        public virtual string funk2() {
            return "funk 2 of abstract class";
        }
        public virtual int speed()
        {
            return max_speed * 5;
        }

        public Auto() 
        {
            Console.WriteLine("Base class constructor");
        }
        ~Auto()
        {
            Console.WriteLine("Base class destructor");
        }

        public static void over() 
        { 
            Console.WriteLine("not overrided funk from base class");
        }

        public virtual void SetSpeed(int sp)
        { 
            max_speed = sp; 
        }
        public void NewFunk()
        {
            Console.WriteLine("BASE funk to be hiden");
        }
    }
}
