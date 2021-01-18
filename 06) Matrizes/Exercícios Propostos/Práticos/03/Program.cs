using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int[,] matriz;
            int[] maiorDaLinha;

            n = int.Parse(Console.ReadLine());
            matriz = new int[n, n];
            maiorDaLinha = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');
                maiorDaLinha[i] = 0;

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(entradas[j]);

                    if (matriz[i, j] > maiorDaLinha[i])
                    {
                        maiorDaLinha[i] = matriz[i, j];
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(maiorDaLinha[i]);
            }
        }
    }
}
