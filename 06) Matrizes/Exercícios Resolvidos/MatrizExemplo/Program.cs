using System;

namespace MatrizExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 0, cont = 0;
            int[,] matriz;
            string[] estrutura = Console.ReadLine().Split(' ');

            m = int.Parse(estrutura[0]);
            n = int.Parse(estrutura[1]);
            matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(entradas[j]);
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
