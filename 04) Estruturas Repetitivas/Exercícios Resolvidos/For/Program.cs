using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, soma = 0;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int numero = int.Parse(Console.ReadLine());
                soma += numero;
            }

            Console.WriteLine(soma);
        }
    }
}
