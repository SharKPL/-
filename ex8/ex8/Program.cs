using System;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int a = 2; a <= 6; a++)
                {
                    Console.Write($"{a} * {i} = {a * i}\t");

                }

                Console.WriteLine();

            }
        }
    }
}
