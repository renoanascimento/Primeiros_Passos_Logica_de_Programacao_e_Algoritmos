using System;
using System.Runtime.Serialization;

namespace URI1158
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, x = 0, y = 0, soma = 0, cont = 0;
            string[] valores = null;

            n = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < n; i++)
            {
                valores = Console.ReadLine().ToString().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);

                soma = 0;
                cont = 0;

                if (x % 2 != 0)
                {
                    soma = x;
                    y--;
                }

                for (int j = x + 1; cont < y; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma += j;
                        cont++;
                    }
                    
                }

                Console.WriteLine(soma);
            }
        }
    }
}
