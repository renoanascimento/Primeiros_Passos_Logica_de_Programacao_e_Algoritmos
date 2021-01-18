using System;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 0, filaParaGirar = 0, aux1 = 0;
            int[,] pelotao;
            int[] aux;

            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            pelotao = new int[m, n];
            aux = new int[n];

            //Leitura do pelotão
            for (int i = 0; i < m; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    pelotao[i, j] = int.Parse(entradas[j]);
                }
            }

            filaParaGirar = int.Parse(Console.ReadLine());

            //Montagem do vetor do giro do pelotão
            for (int i = 0; i < m; i++)
            {
                if (i == filaParaGirar - 1)
                {
                    for (int j = 0; j < n; j++)
                    {
                        aux[j] = pelotao[i, j];
                    }
                }
            }

            //Giro da fila escolhida do pelotão
            for (int i = 0; i < m; i++)
            {
                if (i == filaParaGirar - 1)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j == n - 1)
                        {
                            pelotao[i, 0] = aux[j];
                        }
                        else
                        {
                            pelotao[i, j + 1] = aux[j];
                        }
                    }
                }
            }

            //Impressão do pelotão com a fila girada
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == n - 1)
                    {
                        Console.WriteLine(pelotao[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(pelotao[i, j] + " ");
                    }
                }
            }
        }
    }
}
