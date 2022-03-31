// Вариант 10
/*Дана точка на плоскости с координатами (х, у). Составить программу,
которая выдает одно из сообщений "Да", "Нет", "На границе" в зависимости от
того, лежит ли точка внутри заштрихованной области, вне заштрихованной
области или на ее границе.*/


namespace SecondTask
{
   public class test {
        public string check_point(int x, int y) {
            if (y < 0 || y > 12 || x > Math.Sqrt(y * y))
            {
                return "The point is outside the area.\n";
            }
            else if (y == Math.Abs(x) || (y == 12 && Math.Abs(x) <= 12))
            {
                return "the point is on the border.\n";
            }
            else if ((0 < y && y < 12) && (x < Math.Sqrt(y * y)))
            {
                return "The point is inside the area.\n";
            }
            else
                return "Smth goes wrong....";

        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            test c = new test();
            int chose;
            do {
                Console.WriteLine("Make a chose:\n1-check point.\n2-do not check point.\n");
                chose = Convert.ToInt32(Console.ReadLine());
                switch (chose) {
                    case 1:
                        Console.WriteLine("Input x and y (the koordinats of the point): ");
                        int x, y;
                        x = Convert.ToInt32(Console.ReadLine());
                        y = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine(c.check_point(x, y));
                        break;

                    default:
                        break;
                }
            } while (chose == 1);           
        }
    }
}
