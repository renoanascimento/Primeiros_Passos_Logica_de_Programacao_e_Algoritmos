using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 0, cont = 0;
            int[,] matrizA;
            int[,] matrizB;
            int[,] matrizC;
            string[] entradas;

            entradas = Console.ReadLine().Split(' ');
            m = int.Parse(entradas[0]);
            n = int.Parse(entradas[1]);

            matrizA = new int[m, n];
            matrizB = new int[m, n];
            matrizC = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                entradas = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matrizA[i, j] = int.Parse(entradas[j]);
                }
            }

            for (int i = 0; i < m; i++)
            {
                entradas = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matrizB[i, j] = int.Parse(entradas[j]);
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }

            foreach (int valores in matrizC)
            {
                if (cont < n - 1)
                {
                    Console.Write(valores + " ");
                    cont++;
                }
                else
                {
                    Console.WriteLine(valores + " ");
                    cont = 0;
                }
            }

            //for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (j < n - 1)
            //        {
            //            Console.Write(matrizC[i, j] + " ");
            //        }
            //        else
            //        {
            //            Console.WriteLine(matrizC[i, j] + " ");
            //        }
            //    }
            //}
        }
    }
}
