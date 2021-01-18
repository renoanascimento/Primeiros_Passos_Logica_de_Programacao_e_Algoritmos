using System;
using System.Globalization;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            string[] valores;

            valores = Console.ReadLine().Split(' ');
            x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x == y && x == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
