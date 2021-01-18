using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            n = int.Parse(Console.ReadLine());

            int[] vetorA = new int[n];
            int[] vetorB = new int[n];
            int[] vetorC = new int[n];

            string[] numerosA = Console.ReadLine().Split(' ');
            string[] numerosB = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vetorA[i] = int.Parse(numerosA[i]);
                vetorB[i] = int.Parse(numerosB[i]);
                vetorC[i] = vetorA[i] + vetorB[i];
            }

            foreach (int valores in vetorC)
            {
                Console.Write(valores + " ");
            }
        }
    }
}
