using System;
using System.Globalization;

namespace Resolvido01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, contNegativos = 0;
            n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(entradas[j], CultureInfo.InvariantCulture);

                    if (matriz[i, j] < 0)
                    {
                        contNegativos++;
                    }
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + contNegativos);
        }
    }
}
