using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, totalDePares = 0;
            n = int.Parse(Console.ReadLine());
            int[] numeros = new int[n];

            string[] entradas = new string[n];
            entradas = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                numeros[i] = int.Parse(entradas[i]);

                if (numeros[i] % 2 == 0)
                {
                    totalDePares++;
                    Console.Write(numeros[i] + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine(totalDePares);
        }
    }
}
