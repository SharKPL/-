using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");

            int p = Convert.ToInt32(Console.ReadLine());

            int b = 1;

            int c = 1;

            do
            {
                c *= b;

                ++b;
            }

            while (b <= p);

            Console.WriteLine(c);
        }
    }
}
