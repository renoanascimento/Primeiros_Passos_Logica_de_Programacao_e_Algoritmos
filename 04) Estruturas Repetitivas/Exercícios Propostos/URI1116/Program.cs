using System;
using System.Globalization;

namespace URI1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double x = 0.0, y = 0.0, divisao = 0.0;

                x = double.Parse(valores[0], CultureInfo.InvariantCulture);
                y = double.Parse(valores[1], CultureInfo.InvariantCulture);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    divisao = x / y;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }

                n--;
            }
        }
    }
}
