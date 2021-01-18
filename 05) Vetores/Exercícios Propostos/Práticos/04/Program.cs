using System;
using System.Globalization;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            double soma = 0.0, media = 0.0;
            n = int.Parse(Console.ReadLine());

            double[] numeros = new double[n];
            string[] entradas = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                numeros[i] = double.Parse(entradas[i], CultureInfo.InvariantCulture);
                soma += numeros[i];
            }

            media = soma / n;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            foreach (double valores in numeros)
            {
                if (valores < media)
                {
                    Console.WriteLine(valores.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}
