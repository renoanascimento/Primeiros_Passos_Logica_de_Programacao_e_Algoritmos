using System;
using System.Security.Cryptography.X509Certificates;

namespace URI1101
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            string[] numeros = Console.ReadLine().Split(' ');

            n = int.Parse(numeros[0]);
            m = int.Parse(numeros[1]);

            while (n > 0 && m > 0)
            {
                int maior = 0, menor = 0, soma = 0;

                if (n > m)
                {
                    maior = n;
                    menor = m;
                }
                else
                {
                    maior = m;
                    menor = n;
                }

                for (int i = menor; i <= maior; i++)
                {
                    Console.Write(i + " ");
                    soma += i;
                }

                Console.WriteLine("Sum=" + soma);

                string[] numeros2 = Console.ReadLine().Split(' ');

                n = int.Parse(numeros2[0]);
                m = int.Parse(numeros2[1]);
            }
        }
    }
}
