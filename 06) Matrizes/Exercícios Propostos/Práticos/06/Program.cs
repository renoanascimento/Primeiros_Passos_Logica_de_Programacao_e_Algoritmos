using System;
using System.Globalization;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, indiceLinha = 0, indiceColuna = 0;
            double somaPositivos = 0.0;
            double[,] matrizPrincipal;
            double[,] matrizAlterada;
            string[] entradas;

            n = int.Parse(Console.ReadLine());
            matrizPrincipal = new double[n, n];
            matrizAlterada = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                entradas = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matrizPrincipal[i, j] = double.Parse(entradas[j], CultureInfo.InvariantCulture);

                    if (matrizPrincipal[i, j] > 0)
                    {
                        somaPositivos += matrizPrincipal[i, j];
                    }
                }
            }

            indiceLinha = int.Parse(Console.ReadLine());
            indiceColuna = int.Parse(Console.ReadLine());

            Console.WriteLine("SOMA DOS POSITIVOS: " + somaPositivos.ToString("F1", CultureInfo.InvariantCulture));
            Console.Write("LINHA ESCOLHIDA: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == indiceLinha)
                    {
                        Console.Write(matrizPrincipal[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                }
            }

            Console.WriteLine();
            Console.Write("COLUNA ESCOLHIDA: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == indiceColuna)
                    {
                        Console.Write(matrizPrincipal[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                }
            }

            Console.WriteLine();
            Console.Write("DIAGONAL PRINCIPAL: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(matrizPrincipal[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            Console.WriteLine();
            Console.WriteLine("MATRIZ ALTERADA:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrizPrincipal[i, j] < 0)
                    {
                        matrizAlterada[i, j] = Math.Pow(matrizPrincipal[i, j], 2);
                    }
                    else
                    {
                        matrizAlterada[i, j] = matrizPrincipal[i, j];
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == n - 1)
                    {
                        Console.WriteLine(matrizAlterada[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                    else
                    {
                        Console.Write(matrizAlterada[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                }
            }
        }
    }
}
