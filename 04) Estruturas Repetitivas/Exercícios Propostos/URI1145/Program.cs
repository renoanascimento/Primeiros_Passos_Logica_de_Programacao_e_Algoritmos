using System;

namespace URI1145
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string[] numeros = Console.ReadLine().Split(' ');

            x = int.Parse(numeros[0]);
            y = int.Parse(numeros[1]);

            for (int i = 1; i <= y; i++)
            {
                if (i % x != 0)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
