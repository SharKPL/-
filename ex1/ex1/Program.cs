using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");

            double first_number = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");

            double second_number = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third number: ");

            double third_number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Maximum number: {Math.MaxMagnitude((Math.MaxMagnitude(first_number, second_number)), third_number)}");
        }
    }
}
