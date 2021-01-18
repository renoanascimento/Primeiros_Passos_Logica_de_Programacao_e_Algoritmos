using System;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, valor3, menor, medio, maior;
            string[] valores;

            valores = Console.ReadLine().Split(' ');

            valor1 = int.Parse(valores[0]);
            valor2 = int.Parse(valores[1]);
            valor3 = int.Parse(valores[2]);

            if (valor1 < valor2 && valor1 < valor3)
            {
                menor = valor1;

                if (valor2 < valor3)
                {
                    medio = valor2;
                    maior = valor3;
                }
                else
                {
                    medio = valor3;
                    maior = valor2;
                }
            }

            else if (valor2 < valor3)
            {
                menor = valor2;

                if (valor1 < valor3)
                {
                    medio = valor1;
                    maior = valor3;
                }
                else
                {
                    medio = valor3;
                    maior = valor1;
                }
            }

            else
            {
                menor = valor3;
                if (valor1 < valor2)
                {
                    medio = valor1;
                    maior = valor2;
                }
                else
                {
                    medio = valor2;
                    maior = valor1;
                }
            }

            Console.WriteLine(menor);
            Console.WriteLine(medio);
            Console.WriteLine(maior);
            Console.WriteLine();
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
            Console.WriteLine(valor3);
        }
    }
}
