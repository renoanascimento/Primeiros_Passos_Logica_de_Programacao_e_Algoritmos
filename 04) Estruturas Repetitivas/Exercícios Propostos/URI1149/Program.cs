using System;

namespace URI1149
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, n = 0, soma = 0, i = 1;
            string[] numeros = Console.ReadLine().Split(' ');

            a = int.Parse(numeros[0]);
            n = int.Parse(numeros[i]);

            while (n <= 0)
            {
                i += 1;
                n = int.Parse(numeros[i]);
            }

            for (i = 0; i < n; i++)
            {
                soma += a + i;
            }

            Console.WriteLine(soma);
        }
    }
}
