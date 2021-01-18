using System;

namespace URI1157
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0;
            n = double.Parse(Console.ReadLine());

            for (double i = 0; i <= n; i++)
            {
                double resultado = n % i;
                if (resultado == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
