using System;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string[] valores;

            valores = Console.ReadLine().Split(' ');

            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0)
                {
                    if (y > 0)
                    {
                        Console.WriteLine("primeiro");
                    }
                    else
                    {
                        Console.WriteLine("quarto");
                    }
                }

                else
                {
                    if (y < 0)
                    {
                        Console.WriteLine("terceiro");
                    }
                    else
                    {
                        Console.WriteLine("segundo");
                    }
                }

                valores = Console.ReadLine().Split(' ');

                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }
        }
    }
}
