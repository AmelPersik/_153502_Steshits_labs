/*Разработать метод f(x), который вычисляет значение по
следующей формуле:f(x)=cosx-sin2x. Определить, в какой из точек а или b,
функция принимает наименьшее значение.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите точку, в которой хотим узнать значение функции(точка A):");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите точку, в которой хотим узнать значение функции(точка B):");
            double b = Convert.ToDouble(Console.ReadLine());
            test obj = new test();

            Console.WriteLine(obj.minimum (a, b));

            Console.WriteLine("\nРезультат в точке A и B соответственно:");
            Console.WriteLine(obj.resulta);
            Console.WriteLine(obj.resultb);
        }
    }
}
