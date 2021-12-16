using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");

            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of the first {n} members of the arithmetic progression is {sum}");
        }
    }
}
