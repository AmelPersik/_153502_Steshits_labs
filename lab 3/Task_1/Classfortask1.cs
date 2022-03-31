using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class test
    {
        public double resulta;
        public double resultb;
        
        public test() { }
        public string minimum(double a, double b)
        {
            resulta = Math.Cos(a) - Math.Sin(2 * a);
            resultb = Math.Cos(b) - Math.Sin(2 * b);
            if (resultb == resulta) return "Полученный результат:A=B";
            else if (resulta > resultb) return "Полученный результат:A>B";
            else if (resulta < resultb) return "Полученный результат:A<B";
            else return "smth wrong";
        }
    }
}
