using System;

namespace URI1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0;
            int posicao = 0;

            for (int i = 1; i <= 100; i++)
            {
                int numero = int.Parse(Console.ReadLine());

                if (numero > maior)
                {
                    maior = numero;
                    posicao = i;
                }
            }

            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}
