using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());

            double b = Convert.ToDouble(Console.ReadLine());

            double c = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= 3; i++)
            {
                if (i == a)
                {
                    Console.WriteLine(a);
                }
                if (i == b)
                {
                    Console.WriteLine(b);
                }
                if (i == c)
                {
                    Console.WriteLine(c);
                }
            }

        }
    }
}
