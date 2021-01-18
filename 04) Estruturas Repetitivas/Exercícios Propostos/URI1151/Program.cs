using System;

namespace URI1151
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x = 0, y = 1;
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int fibonacci = x;
                x = y;
                y += fibonacci;

                if (i + 1 == n)
                {
                    Console.WriteLine(fibonacci);
                }
                else
                {
                    Console.Write(fibonacci + " ");
                }
            }
        }
    }
}
