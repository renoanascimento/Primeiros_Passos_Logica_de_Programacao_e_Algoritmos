using System;

namespace URI1143
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                double quadrado = 0.0, cubo = 0.0;

                quadrado = Math.Pow(i, 2.0);
                cubo = Math.Pow(i, 3.0);

                Console.WriteLine(i + " " + quadrado + " " + cubo);
            }
        }
    }
}
