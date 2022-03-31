// Вариант 10: кратна ли трем сумма цифр двузначного числа.
using System;

namespace FirstTask {
    class Program {
        static void Main(string[] args)
        {
            int chose;
            do
            {
                Console.WriteLine("input 1 0r 2: \n1-check number.\n2-exit.\n");
                
                chose = Convert.ToInt32(Console.ReadLine());
                switch (chose)
                {
                    case 1:
                        Console.WriteLine("input two-digit namber: ");
                        int tnum;
                    tnum = Convert.ToInt32(Console.ReadLine());
                    if ((tnum / 10 > 9) || (tnum / 10 < 1)) { Console.Write("input wrong number! "); }
                    else
                    {
                        int a, b;
                        b = tnum % 10;
                        a = tnum / 10;

                        int c = (a + b) % 3;

                        if (c == 0) Console.Write("The number is a multiple of three.\n");
                        else Console.Write("The number is not a multiple of three.\n");
                     }
                        break;
                        case 2: break;
                }
            }while (chose == 1);
        }
    }
}
