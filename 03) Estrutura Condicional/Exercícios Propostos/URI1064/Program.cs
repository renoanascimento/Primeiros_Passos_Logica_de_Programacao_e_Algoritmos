using System;
using System.Globalization;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2, valor3, valor4, valor5, valor6, soma, media;
            int totalPositivos;

            valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valor3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valor4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valor5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valor6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalPositivos = 0;
            soma = 0;

            if (valor1 > 0)
            {
                totalPositivos++;
                soma += valor1;
            }

            if (valor2 > 0)
            {
                totalPositivos++;
                soma += valor2;
            }

            if (valor3 > 0)
            {
                totalPositivos++;
                soma += valor3;
            }

            if (valor4 > 0)
            {
                totalPositivos++;
                soma += valor4;
            }

            if (valor5 > 0)
            {
                totalPositivos++;
                soma += valor5;
            }

            if (valor6 > 0)
            {
                totalPositivos++;
                soma += valor6;
            }

            media = soma / totalPositivos;

            Console.WriteLine(totalPositivos + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
