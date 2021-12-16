using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter purchase amount: ");

            double a = Convert.ToInt32(Console.ReadLine());

            if (a > 500 && a <= 1000)
                Console.WriteLine($"Purchase price including discount {a - (a * 0.03) }");
            else if (a > 1000)
                Console.WriteLine($"Purchase price including discount {a - (a * 0.05) }");
            else
                Console.WriteLine($"Purchase price including discount {a}");
        }
    }
}
