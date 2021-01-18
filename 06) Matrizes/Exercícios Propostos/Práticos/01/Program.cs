using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 0;
            string[] entradas;
            int[,] matriz;

            entradas = Console.ReadLine().Split(' ');
            m = int.Parse(entradas[0]);
            n = int.Parse(entradas[1]);
            matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                entradas = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(entradas[j]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        Console.WriteLine(matriz[i, j]);
                    }
                }
            }

        }
    }
}
