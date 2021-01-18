using System;
using System.Globalization;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string[] valores;

            valores = Console.ReadLine().Split(' ');

            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            if ((Math.Abs(b - c) < a && a < (b + c)) || (Math.Abs(a - c) < b && b < (a + c)) || (Math.Abs(a - b) < c && c < (a + b)))
            {
                double perimetro;

                perimetro = a + b + c;

                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                double area;

                area = (a + b) * c / 2.0;

                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
