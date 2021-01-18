using System;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2, valor3, valor4, valor5, valor6;
            int totalPositivos;

            valor1 = double.Parse(Console.ReadLine());
            valor2 = double.Parse(Console.ReadLine());
            valor3 = double.Parse(Console.ReadLine());
            valor4 = double.Parse(Console.ReadLine());
            valor5 = double.Parse(Console.ReadLine());
            valor6 = double.Parse(Console.ReadLine());
            totalPositivos = 0;

            if (valor1 > 0)
            {
                totalPositivos++;
            }

            if (valor2 > 0)
            {
                totalPositivos++;
            }

            if (valor3 > 0)
            {
                totalPositivos++;
            }

            if (valor4 > 0)
            {
                totalPositivos++;
            }

            if (valor5 > 0)
            {
                totalPositivos++;
            }

            if (valor6 > 0)
            {
                totalPositivos++;
            }

            Console.WriteLine(totalPositivos + " valores positivos");
        }
    }
}
