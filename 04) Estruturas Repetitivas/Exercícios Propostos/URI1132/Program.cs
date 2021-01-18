using System;

namespace URI1132
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, maior = 0, menor = 0, soma = 0, diferenca = 0;

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

            while (diferenca >= 0)
            {
                if (menor % 13 != 0)
                {
                    soma += menor;
                }
                menor++;
                diferenca = maior - menor;
            }

            Console.WriteLine(soma);
        }
    }
}
