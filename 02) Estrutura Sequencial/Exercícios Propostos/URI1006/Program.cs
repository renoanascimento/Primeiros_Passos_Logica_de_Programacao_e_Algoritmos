using System;
using System.Globalization;

namespace URI1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, media;
            const int pesoA = 2, pesoB = 3, pesoC = 5, pesoTotal = pesoA + pesoB + pesoC;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * pesoA;
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * pesoB;
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * pesoC;

            media = (A + B + C) / pesoTotal;

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
