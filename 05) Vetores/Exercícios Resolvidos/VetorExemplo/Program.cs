using System;
using System.Globalization;

namespace VetorExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            double[] numeros;

            n = int.Parse(Console.ReadLine());
            numeros = new double[n];

            for (int i = 0; i < n; i++)
            {
                numeros[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(numeros[j].ToString(CultureInfo.InvariantCulture));
            }
        }
    }
}
