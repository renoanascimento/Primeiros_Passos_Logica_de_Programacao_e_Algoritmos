using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, maisVelho = 0;
            string pessoaMaisVelha = null;
            n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            int[] idades = new int[n];
            string[] entradas = new string[1];

            for (int i = 0; i < n; i++)
            {
                entradas = Console.ReadLine().Split(' ');

                nomes[i] = entradas[0];
                idades[i] = int.Parse(entradas[1]);

                if (idades[i] > maisVelho)
                {
                    maisVelho = idades[i];
                    pessoaMaisVelha = nomes[i];
                }
            }

            Console.WriteLine("Pessoa mais velha: " + pessoaMaisVelha);
        }
    }
}
