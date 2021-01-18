using System;
using System.Globalization;

namespace URI1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, media;
            const double peso1 = 3.5, peso2 = 7.5, pesoTotal = peso1 + peso2;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * peso1;
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * peso2;

            media = (A + B) / pesoTotal;

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
