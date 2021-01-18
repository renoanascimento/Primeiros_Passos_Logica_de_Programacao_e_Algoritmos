using System;
using System.Globalization;

namespace URI1155
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0;

            for (double i = 1; i <= 100; i++)
            {
                s = s + (1/i);
            }

            Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
