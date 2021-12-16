using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int leg_length = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < leg_length; i++)
            {
                for (int a = 1; a < i; a++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();

            }
        }
    }
}
