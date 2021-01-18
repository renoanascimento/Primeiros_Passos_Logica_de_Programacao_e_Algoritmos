using System;

namespace URI1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, soma = 0, total = 0, cont = 0;

            x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                if (x % 2 != 0)
                {
                    soma = x + 1;
                }
                else
                {
                    soma = x;
                }
                total = soma;
                while (cont < 4)
                {
                    soma = soma + 2;
                    total += soma;
                    cont++;
                }

                Console.WriteLine(total);
                
                total = 0;
                soma = 0;
                cont = 0;

                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
