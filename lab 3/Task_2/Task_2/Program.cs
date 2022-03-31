/* 12 variant */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите z:");
            int z = Convert.ToInt32(Console.ReadLine());
            Class1 obj = new Class1();
            obj.func(z);
            
        }
    }
}