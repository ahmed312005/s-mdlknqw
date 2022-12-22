using System;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("enter the first number");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the next number");
            y = int.Parse(Console.ReadLine());

            for (int i = x; i <= y; i++)
            {
                int z = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        z += j;
                }
                if (z == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
