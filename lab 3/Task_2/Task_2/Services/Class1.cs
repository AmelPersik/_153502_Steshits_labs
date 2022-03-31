using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Class1
    {
        public int z;


        public Class1()
        {
        }
        public string func( int z)
        {
            double x;
            if (z <= 0)
            {
                x = z * z + 5;
                Console.WriteLine("x = " + x);
            }
            else
            {
                x = 1 / (Math.Sqrt(z - 1));
                Console.WriteLine("x = " + x);
            }
            Console.WriteLine(Math.Pow(Math.Sin(x*x-1),3) + Math.Log(Math.Abs(x)) + Math.Exp(x));
            if (z <= 0)
                return "Ветка №2(x =  z * z + 5) при z<=0";
            else return "Ветка №1(x = 1 / (Math.Sqrt(z - 1)) при z>0";
        }
    }
}


