using System;
using System.Globalization;

namespace URI1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; 
            double ratos = 0.0, sapos = 0.0, coelhos = 0.0, totalCobaias = 0.0;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] experimento = Console.ReadLine().Split(' ');
                char tipo;
                int quantidade;

                quantidade = int.Parse(experimento[0]);
                tipo = char.Parse(experimento[1]);

                if (tipo == 'C')
                {
                    coelhos += quantidade;
                }
                else if (tipo == 'R')
                {
                    ratos += quantidade;
                }
                else
                {
                    sapos += quantidade;
                }

                totalCobaias = coelhos + ratos + sapos;
            }

            Console.WriteLine("Total: " + totalCobaias + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de coelhos: " + ((coelhos * 100.0) / totalCobaias).ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + ((ratos * 100.0) / totalCobaias).ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + ((sapos * 100.0) / totalCobaias).ToString("F2", CultureInfo.InvariantCulture) + " %");
        }
    }
}
