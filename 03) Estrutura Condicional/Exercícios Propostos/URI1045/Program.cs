using System;
using System.Globalization;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, valor1, valor2, valor3;
            string[] valores;

            valores = Console.ReadLine().Split(' ');
            valor1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            valor2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            valor3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            if (valor1 > valor2 && valor1 > valor3)
            {
                a = valor1;
                if (valor2 > valor3)
                {
                    b = valor2;
                    c = valor3;
                }
                else
                {
                    b = valor3;
                    c = valor2;
                }
            }
            else if (valor2 > valor3)
            {
                a = valor2;
                if (valor1 > valor3)
                {
                    b = valor1;
                    c = valor3;
                }
                else
                {
                    b = valor3;
                    c = valor1;
                }
            }
            else
            {
                a = valor3;
                if (valor1 > valor2)
                {
                    b = valor1;
                    c = valor2;
                }
                else
                {
                    b = valor2;
                    c = valor1;
                }
            }

            if (a >= (b + c))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if (Math.Pow(a, 2) == (Math.Pow(b, 2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (Math.Pow(a, 2) > (Math.Pow(b, 2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if (Math.Pow(a, 2) < (Math.Pow(b, 2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if (((a + b + c) / 3.0 == a))
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
