using System;

namespace URI1133
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, maior = 0, menor = 0, diferenca = 0;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

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

            diferenca = maior - menor;
            menor++;

            while (diferenca > 1)
            {
                if (menor % 5 == 2 || menor % 5 == 3)
                {
                    Console.WriteLine(menor);
                }

                menor++;
                diferenca--;
            }
        }
    }
}
