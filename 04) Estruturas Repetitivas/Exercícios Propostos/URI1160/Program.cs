using System;
using System.Globalization;

namespace URI1160
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            
            t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int anos = 0;
                double pa = 0.0, pb = 0.0, g1 = 0.0, g2 = 0.0;
                string[] dados = Console.ReadLine().Split(' ');

                pa = double.Parse(dados[0]);
                pb = double.Parse(dados[1]);
                g1 = double.Parse(dados[2], CultureInfo.InvariantCulture);
                g2 = double.Parse(dados[3], CultureInfo.InvariantCulture);

                while (pa <= pb)
                {
                    pa = Math.Floor(pa + (pa * g1 / 100.0));
                    pb = Math.Floor(pb + (pb * g2 / 100.0));
                    anos++;

                    if (anos > 100)
                    {
                        Console.WriteLine("Mais de 1 seculo.");
                        break;
                    }
                }

                if (anos <= 100)
                {
                    Console.WriteLine(anos + " anos.");
                }
            }
        }
    }
}
