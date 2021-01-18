using System;

namespace URI1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, valor3, valor4, valor5, totalPares, totalImpares, totalPositivos, totalNegativos;

            valor1 = int.Parse(Console.ReadLine());
            valor2 = int.Parse(Console.ReadLine());
            valor3 = int.Parse(Console.ReadLine());
            valor4 = int.Parse(Console.ReadLine());
            valor5 = int.Parse(Console.ReadLine());
            totalPares = 0;
            totalImpares = 0;
            totalPositivos = 0;
            totalNegativos = 0;

            if (valor1 % 2 == 0)
            {
                totalPares++;
            }
            else
            {
                totalImpares++;
            }

            if (valor2 % 2 == 0)
            {
                totalPares++;
            }
            else
            {
                totalImpares++;
            }

            if (valor3 % 2 == 0)
            {
                totalPares++;
            }
            else
            {
                totalImpares++;
            }

            if (valor4 % 2 == 0)
            {
                totalPares++;
            }
            else
            {
                totalImpares++;
            }

            if (valor5 % 2 == 0)
            {
                totalPares++;
            }
            else
            {
                totalImpares++;
            }

            if (valor1 != 0)
            {
                if (valor1 > 0)
                {
                    totalPositivos++;
                }
                else
                {
                    totalNegativos++;
                }
            }

            if (valor2 != 0)
            {
                if (valor2 > 0)
                {
                    totalPositivos++;
                }
                else
                {
                    totalNegativos++;
                }
            }

            if (valor3 != 0)
            {
                if (valor3 > 0)
                {
                    totalPositivos++;
                }
                else
                {
                    totalNegativos++;
                }
            }

            if (valor4 != 0)
            {
                if (valor4 > 0)
                {
                    totalPositivos++;
                }
                else
                {
                    totalNegativos++;
                }
            }

            if (valor5 != 0)
            {
                if (valor5 > 0)
                {
                    totalPositivos++;
                }
                else
                {
                    totalNegativos++;
                }
            }

            Console.WriteLine(totalPares + " valor(es) par(es)");
            Console.WriteLine(totalImpares + " valor(es) impar(es)");
            Console.WriteLine(totalPositivos + " valor(es) positivo(s)");
            Console.WriteLine(totalNegativos + " valor(es) negativo(s)");
        }
    }
}
