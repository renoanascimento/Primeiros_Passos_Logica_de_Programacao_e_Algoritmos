using System;

namespace Resolvido01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int[] vetor = null;
            string[] valores = null;

            n = int.Parse(Console.ReadLine());
            vetor = new int[n];
            valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vetor[i] = int.Parse(valores[i]);
            }

            for (int j = 0; j < n; j++)
            {
                if (vetor[j] < 0)
                {
                    Console.WriteLine(vetor[j]);
                }
            }
        }
    }
}
