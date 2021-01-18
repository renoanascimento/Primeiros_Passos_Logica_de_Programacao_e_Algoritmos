using System;

namespace URI1044
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string[] valores;

            valores = Console.ReadLine().Split(' ');

            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);

            if (a > b && a % b == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }

            else if (b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
