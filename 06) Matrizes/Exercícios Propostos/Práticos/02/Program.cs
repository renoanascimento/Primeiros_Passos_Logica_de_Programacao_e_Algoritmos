using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int[,] matriz;
            int[] soma;

            n = int.Parse(Console.ReadLine());
            matriz = new int[n, n];
            soma = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(entradas[j]);
                    soma[i] += matriz[i, j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(soma[i]);
            }
        }
    }
}
