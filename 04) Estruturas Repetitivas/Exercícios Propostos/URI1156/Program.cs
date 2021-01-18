using System;
using System.Globalization;

namespace URI1156
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0.0, denominador = 1.0;

            for (double numerador = 1.0; numerador <= 39; numerador += 2.0)
            {
                s += numerador / denominador;
                denominador *= 2;
            }

            Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}