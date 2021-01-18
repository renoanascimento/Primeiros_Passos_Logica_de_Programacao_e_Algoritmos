using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, soma = 0;
            int[,] matriz;

            n = int.Parse(Console.ReadLine());
            matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(entradas[j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j > i)
                    {
                        soma += matriz[i, j];
                    }
                }
            }

            Console.WriteLine(soma);
            
        }
    }
}
