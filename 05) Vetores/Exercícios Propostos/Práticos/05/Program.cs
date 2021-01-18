using System;
using System.Globalization;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, cont = 0;
            double soma = 0.0, media = 0.0;
            n = int.Parse(Console.ReadLine());

            int[] numeros = new int[n];
            string[] entradas = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                numeros[i] = int.Parse(entradas[i], CultureInfo.InvariantCulture);
                if (numeros[i] % 2 == 0)
                {
                    soma += numeros[i];
                    cont++;
                }
                
            }

            media = soma / cont;

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
