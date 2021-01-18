using System;

namespace URI1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            x = int.Parse(Console.ReadLine());

            if (x % 2 != 0)
            {
                Console.WriteLine(x);
                Console.WriteLine(x + 2);
                Console.WriteLine(x + 4);
                Console.WriteLine(x + 6);
                Console.WriteLine(x + 8);
                Console.WriteLine(x + 10);
            }
            else
            {
                Console.WriteLine(x + 1);
                Console.WriteLine(x + 3);
                Console.WriteLine(x + 5);
                Console.WriteLine(x + 7);
                Console.WriteLine(x + 9);
                Console.WriteLine(x + 11);
            }
        }
    }
}
