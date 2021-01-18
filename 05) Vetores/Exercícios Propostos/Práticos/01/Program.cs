using System;
using System.Globalization;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, posicao = 0;
            double maior = 0.0;
            n = int.Parse(Console.ReadLine());

            double[] numeros = new double[n];
            string[] entradas = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                numeros[i] = double.Parse(entradas[i], CultureInfo.InvariantCulture);

                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                    posicao = i;
                }
            }

            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);
        }
    }
}
