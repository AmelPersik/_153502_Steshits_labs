// See https://aka.ms/new-console-template for more information

class Program {
    static void Main(string[] args) {
        double a, b, x;
        Console.Write("Input the first number: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second number: ");
        b = Convert.ToDouble(Console.ReadLine());
        x = a / b;
        Console.WriteLine(x);
    }
}
