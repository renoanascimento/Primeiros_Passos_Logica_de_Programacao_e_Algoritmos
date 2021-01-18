using System;

namespace Resolvido02
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 0;
            int[,] matriz;
            int[] soma;
            string[] entradas = Console.ReadLine().Split(' ');

            m = int.Parse(entradas[0]);
            n = int.Parse(entradas[1]);

            matriz = new int[m, n];
            soma = new int[m];

            for (int i = 0; i < m; i++)
            {
                entradas = Console.ReadLine().Split(' ');

                for(int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(entradas[j]);

                    soma[i] += matriz[i, j];
                }
            }

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(soma[i]);
            }
        }
    }
}
