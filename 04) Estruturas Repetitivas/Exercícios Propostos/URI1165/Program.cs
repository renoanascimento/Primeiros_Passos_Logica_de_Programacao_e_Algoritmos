using System;

namespace URI1165
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = 0, cont = 0;

                x = int.Parse(Console.ReadLine());

                for (int j = 1; j <= x; j++)
                {
                    if (x % j == 0)
                    {
                        cont++;
                    }
                }

                if (cont > 2)
                {
                    Console.WriteLine(x + " nao eh primo");
                }
                else
                {
                    Console.WriteLine(x + " eh primo");
                }
            }
        }
    }
}
