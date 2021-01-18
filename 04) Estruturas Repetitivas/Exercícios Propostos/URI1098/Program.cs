using System;
using System.Globalization;

namespace URI1098
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double i = 0.0; i <= 2.0; i += 0.2)
            {
                for (double j = 1.0; j <= 3.0; j++)
                {
                    if ((i == 0.0) || (i ==1.0) || (i >= 1.9))
                    {
                        Console.WriteLine("I=" + i.ToString("F0", CultureInfo.InvariantCulture) + " " + "J=" + (j + i).ToString("F0", CultureInfo.InvariantCulture));
                    }
                    else
                    {
                        Console.WriteLine("I=" + i.ToString("F1", CultureInfo.InvariantCulture) + " " + "J=" + (j + i).ToString("F1", CultureInfo.InvariantCulture));
                    }
                }
            }
        }
    }
}
