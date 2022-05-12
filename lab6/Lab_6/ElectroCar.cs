using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public sealed class ElectroCar : Car
    {
        private static int max_speed = 50;

        public override string funk1()
        {
            return "This is an object of Electrocar class)";
        }
        public ElectroCar() 
        {
            Console.WriteLine("ElectroCar constructor");
            over();
        }

        ~ElectroCar() 
        { 
            Console.WriteLine("ElectroCar destructor");
        }
    }
}
