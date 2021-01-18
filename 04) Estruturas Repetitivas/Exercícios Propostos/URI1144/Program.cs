using System;

namespace URI1144
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

                quadrado = Math.Pow(i, 2);
                cubo = Math.Pow(i, 3);

                Console.WriteLine(i + " " + quadrado + " " + cubo);
                Console.WriteLine(i + " " + (quadrado + 1.0) + " " + (cubo + 1.0));
            }
        }
    }
}
