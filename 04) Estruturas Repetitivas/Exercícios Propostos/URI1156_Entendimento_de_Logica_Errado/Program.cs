using System;
using System.Globalization;

namespace URI1156
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Nesse problema eu havia entendido que a sequência era S = 1 + 3/2 + 5/4 + 7/8 + 9/10  + 13/12 +
             * 15/14 + 17/18 + 19/20 + 23/22 + 25/24 + 27/28 + 29/30 + 33/32 + 35/34 + 37/38 + 39/40.
             * Onde o total de interações no loop é igual a 24 porque é a quantidade de parcelas (17), mais
             * a quantidade de "pulos" ao chegar nos números terminados em 1 ou 6 (que são 7 vezes).
            */

            double s = 0.0, cont = 1.0, vezes = 1.0;

            for (double i = 1.0; i <= 24.0; i++)
            {
                i = Math.Round(i, 2);
                if (i == 1.00)
                {
                    s += i;
                }
                else if (vezes < 3.0)
                {
                    s = s + ((i + cont) / (i + cont - 1.0));
                    cont++;
                    vezes++;
                }
                else if (vezes == 3.0)
                {
                    vezes += 1.0;
                }
                else if (vezes < 6.0)
                {
                    s = s + ((i + cont - 1.0) / (i + cont));
                    cont++;
                    vezes++;
                }
                else
                {
                    vezes = 1.0;
                }
            }

            Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
