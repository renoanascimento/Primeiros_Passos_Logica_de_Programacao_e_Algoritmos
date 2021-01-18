using System;

namespace URI1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n * 4; i++)
            {
                if (i % 4 != 0)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    Console.WriteLine("PUM");
                }
            }
        }
    }
}
