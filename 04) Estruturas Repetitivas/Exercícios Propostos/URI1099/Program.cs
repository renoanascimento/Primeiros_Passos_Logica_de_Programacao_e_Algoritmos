using System;

namespace URI1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                string[] numeros = Console.ReadLine().Split(' ');
                int x = 0, y = 0, maior = 0, menor = 0, soma = 0;

                x = int.Parse(numeros[0]);
                y = int.Parse(numeros[1]);

                if (x > y)
                {
                    maior = x;
                    menor = y;
                }
                else
                {
                    maior = y;
                    menor = x;
                }

                for (int i = menor + 1; i < maior; i++)
                {
                    if (i % 2 != 0)
                    {
                        soma += i;
                    }
                }

                Console.WriteLine(soma);

                n--;
            }
        }
    }
}
